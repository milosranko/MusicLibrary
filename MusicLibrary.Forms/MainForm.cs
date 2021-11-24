using MusicLibrary.Business;
using MusicLibrary.Business.Enums;
using MusicLibrary.Business.Models;
using MusicLibrary.Common;
using MusicLibrary.Common.Helpers;
using MusicLibrary.Indexer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary.Forms
{
    public partial class MainForm : Form
    {
        private delegate void SafeCallDelegate(string text);
        private CancellationTokenSource _cts;
        private IEnumerable<string> _fileList;
        private TimeSpan _duration;
        private bool _scanningStarted;
        private bool _hasFilesToIndex;
        private IProgress<ProgressArgs> _progress;
        private IList<string> _availableIndexes;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MainForm()
        {
            _progress = new Progress<ProgressArgs>(Progress);
            InitializeComponent();
        }

        private async Task InitializeDashboard()
        {
            var indexSearcher = new IndexSearcher();

            if (indexSearcher.IndexExists)
            {
                var res = await indexSearcher.GetIndexCounts();

                lvExtensionsTotal.Items.Clear();
                lvExtensionsTotal.Items.AddRange(
                    res.TotalFilesByExtension
                    .Select(x => new ListViewItem(new[] { x.Key, x.Value.ToString() }))
                    .ToArray());

                lvGenres.Items.Clear();
                lvGenres.Items.AddRange(
                    res.GenreCount
                    .Select(x => new ListViewItem(new[] { x.Key, x.Value.ToString() }))
                    .ToArray());

                lvReleaseYears.Items.Clear();
                lvReleaseYears.Items.AddRange(
                    res.ReleaseYears
                    .Select(x => new ListViewItem(new[] { x.Key, x.Value.ToString() }))
                    .ToArray());

                lvLatestAdditions.Items.Clear();
                lvLatestAdditions.Items.AddRange(
                    res.LatestAdditions
                    .Select(x => new ListViewItem(new[] { x.Item1, x.Item2 }))
                    .ToArray());

                lblTotalTracksValue.Text = res.TotalFiles.ToString();
            }

            ShowPanel(PanelEnum.Dashboard);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void btnDashboard_Click(object sender, EventArgs e)
        {
            await InitializeDashboard();
            ShowPanel(PanelEnum.Dashboard);
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelEnum.Index);
            //TODO check available indexes and populate _availableIndexes list
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelEnum.Search);
        }

        private void ShowPanel(PanelEnum panel)
        {
            switch (panel)
            {
                case PanelEnum.Dashboard:
                    pnlIndex.SendToBack();
                    pnlDashboard.BringToFront();
                    pnlSearch.SendToBack();
                    break;
                case PanelEnum.Index:
                    pnlIndex.BringToFront();
                    pnlDashboard.SendToBack();
                    pnlSearch.SendToBack();
                    break;
                case PanelEnum.Search:
                    pnlIndex.SendToBack();
                    pnlDashboard.SendToBack();
                    pnlSearch.BringToFront();
                    this.ActiveControl = txtSearchField;
                    break;
                default:
                    pnlSearch.Visible = false;
                    pnlIndex.Visible = false;
                    pnlDashboard.Visible = true;
                    break;
            }
        }

        enum PanelEnum
        {
            Dashboard,
            Index,
            Search
        }

        private void btnIndexFolder_Click(object sender, EventArgs e)
        {
            var dialogRes = folderBrowserDialog1.ShowDialog();
            if (dialogRes == DialogResult.OK)
            {
                lblIndexFolder.Text = folderBrowserDialog1.SelectedPath;
                btnScan.Enabled = true;
            }
        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            _cts ??= new CancellationTokenSource();

            if (_scanningStarted)
            {
                _cts.Cancel();
                _scanningStarted = false;
                ScanningStopped();
            }
            else
            {
                ScanningStarted();
                _scanningStarted = true;

                this.Update();

                _duration = TimeSpan.Zero;

                await StartScanning(_cts.Token);
                _scanningStarted = false;
            }
        }

        private void ScanningStarted()
        {
            btnScan.Text = "Stop scanning";
            statusStrip1.Items[1].Text = "scanning for music...";
        }

        private void ScanningStopped()
        {
            statusStrip1.Items[1].Text = "scanning stopped.";
            btnScan.Text = "Scan";
        }

        private void ScanningFinished()
        {
            statusStrip1.Items[1].Text = $"scanning finished in {_duration.TotalSeconds:####} sec. Found {_fileList.Count()} music files.";
            btnScan.Text = "Scan";

            if (_hasFilesToIndex)
            {
                btnIndexNewFiles.Enabled = true;
                btnIndex.Visible = true;
                btnIndex.Enabled = true;
            }
        }

        private async Task StartScanning(CancellationToken ct)
        {
            if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath)) return;

            try
            {
                var stopwatch = Stopwatch.StartNew();

                _fileList = await Task.Run(() => FileScanner.ScanForMusicFiles(folderBrowserDialog1.SelectedPath, _progress, ct), ct);

                stopwatch.Stop();
                _duration = stopwatch.Elapsed;

                _hasFilesToIndex = _fileList.Any();
                ScanningFinished();
            }
            catch (Exception e)
            {
                _scanningStarted = false;
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                _cts.Dispose();
                _cts = null;
            }
        }

        private async void btnIndex_Click_1(object sender, EventArgs e)
        {
            _cts ??= new CancellationTokenSource();

            if (_scanningStarted)
            {
                _cts.Cancel();
                _scanningStarted = false;
                IndexingStopped();
            }
            else
            {
                if (_fileList == null || !_fileList.Any())
                {
                    statusStrip1.Items[1].Text = "no files to index, please scan folder for files.";
                    return;
                }

                IndexingStarted();
                _scanningStarted = true;

                this.Update();

                _duration = TimeSpan.Zero;

                await StartIndexing(_cts.Token);

                _fileList = null;
                _scanningStarted = false;
                IndexingFinished();
            }
        }

        private void WriteTextSafe(string text)
        {
            if (statusStrip1.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                statusStrip1.Invoke(d, new object[] { text });
            }
            else
            {
                statusStrip1.Items[1].Text = text;
            }
        }

        private void IndexingStarted()
        {
            btnIndex.Text = "Stop indexing";
            statusStrip1.Items[1].Text = "indexing files...";
        }

        private void Progress(ProgressArgs args)
        {
            if (string.IsNullOrEmpty(args.Folder))
                WriteTextSafe($"indexing files... {args.Files} of {_fileList.Count()}");
            else
                WriteTextSafe($"scanning for music... {args.Folder}");
        }

        private void IndexingStopped()
        {
            statusStrip1.Items[1].Text = "indexing stopped.";
            btnIndex.Text = "Index";
        }

        private void IndexingFinished()
        {
            statusStrip1.Items[1].Text = $"indexing finished in {_duration.TotalSeconds:####} sec.";
            btnIndex.Text = "Index";
        }

        private async Task StartIndexing(CancellationToken ct, bool onlyNewFiles = false)
        {
            if (_fileList == null || !_fileList.Any()) return;

            try
            {
                var fi = new FileIndexer(ct);
                var stopwatch = Stopwatch.StartNew();

                await Task.Run(() => fi.StartIndexing(_fileList, _progress, onlyNewFiles), ct);

                stopwatch.Stop();
                _duration = stopwatch.Elapsed;

                IndexingFinished();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                _cts.Dispose();
                _cts = null;
            }
        }

        private void dgSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowItem = (SearchResultModel)dgSearchResult.CurrentRow.DataBoundItem;
            ShowFileInfo(rowItem);
        }

        private void ShowFileInfo(SearchResultModel model)
        {
            var metaTags = MetatagsHelpers.GetMetatags(model.Tags);
            var sb = new StringBuilder();

            sb.AppendLine($"Path: {model.Path}");
            sb.AppendLine($"File: {model.FileName}");
            sb.AppendLine($"Artist: {metaTags[0]}");
            sb.AppendLine($"Album: {metaTags[1]}");
            sb.AppendLine($"Year: {metaTags[2]}");
            sb.AppendLine($"Genre: {metaTags[3]}");
            sb.AppendLine($"Title: {metaTags[4]}");
            sb.AppendLine($"Track no: {metaTags[5]}");

            MessageBox.Show(sb.ToString(), "Track info", MessageBoxButtons.OK);
        }

        private async void btnSearchIndex_Click(object sender, EventArgs e)
        {
            await Search(SearchFieldsEnum.Text, txtSearchField.Text, null);
        }

        private async Task Search(SearchFieldsEnum searchField, string query, string[] terms)
        {
            var indexSearcher = new IndexSearcher();

            if (!indexSearcher.IndexExists) return;

            SearchStarted();

            var res = await Task.Run(() => indexSearcher.Search(query, terms, searchField));

            SearchFinished(res);

            dgSearchResult.DataSource = res.Hits
                .Select(x => new SearchResultModel
                {
                    Id = x.Id,
                    Artist = MetatagsHelpers.GetMetatags(x.Tags)[0], 
                    Album = MetatagsHelpers.GetMetatags(x.Tags)[1], 
                    Year = string.IsNullOrWhiteSpace(MetatagsHelpers.GetMetatags(x.Tags)[2]) || !int.TryParse(MetatagsHelpers.GetMetatags(x.Tags)[2], out int value1) ? default(int?) : value1, 
                    TrackName = MetatagsHelpers.GetMetatags(x.Tags)[4],
                    TrackNumber = string.IsNullOrWhiteSpace(MetatagsHelpers.GetMetatags(x.Tags)[5]) || !int.TryParse(MetatagsHelpers.GetMetatags(x.Tags)[5], out int value2) ? default(int?) : value2,
                    Tags = x.Tags,
                    Path = System.IO.Path.GetDirectoryName(x.Id),
                    FileName = System.IO.Path.GetFileName(x.Id),
                    Genre = MetatagsHelpers.GetMetatags(x.Tags)[3]
                })
                .OrderBy(x => x.Artist)
                .ThenBy(x => x.Year)
                .ThenBy(x => x.Album)
                .ThenBy(x => x.TrackNumber)
                .ToArray();
            dgSearchResult.Visible = true;
        }

        private void SearchStarted()
        {
            statusStrip1.Items[1].Text = "searching...";
        }

        private void SearchFinished(SearchResult res)
        {
            txtSearchField.Text = res.SearchText;
            statusStrip1.Items[1].Text = $"found {res.TotalHits} matches";
        }

        private void dgSearchResult_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = ctxFileOptions;
        }

        private void ctxFileOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ctxFileOptions.Hide();

            if (dgSearchResult.SelectedRows.Count > 0)
            {
                //Show file info
                if (e.ClickedItem.Name.Equals(toolStripShowFileInfo.Name))
                {
                    var rowItem = (SearchResultModel)dgSearchResult.CurrentRow.DataBoundItem;
                    ShowFileInfo(rowItem);
                }

                //Edit meta tags
                if (e.ClickedItem.Name.Equals(toolStripEditMetaTags.Name))
                {
                    var metaTagsDialog = new MetaTagsForm
                    {
                        Files = dgSearchResult.SelectedRows
                            .Cast<DataGridViewRow>()
                            .Select(x => (SearchResultModel)x.DataBoundItem)
                            .OrderBy(x => x.Path)
                            .ThenBy(x => x.FileName)
                            .ToArray()
                    };

                    metaTagsDialog.ShowDialog(this);
                }

                //Convert files
                if (e.ClickedItem.Name.Equals(toolStripConvertSelectedFiles.Name))
                {
                    var convertFilesDialog = new ConvertFilesForm
                    {
                        Files = dgSearchResult.SelectedRows
                            .Cast<DataGridViewRow>()
                            .Select(x => (SearchResultModel)x.DataBoundItem)
                            .Where(x => System.IO.Path.GetExtension(x.FileName).EndsWith("flac"))
                            .OrderBy(x => x.Path)
                            .ThenBy(x => x.FileName)
                            .ToArray()
                    };

                    convertFilesDialog.ShowDialog(this);
                }

                //Search ruTracker
                if (e.ClickedItem.Name.Equals(toolStripSearchRuTracker.Name))
                {
                    if (dgSearchResult.SelectedRows.Count > 0)
                    {
                        var item = (SearchResultModel)dgSearchResult.SelectedRows[0].DataBoundItem;
                        var query = Uri.EscapeDataString($"{item.Artist} {item.Album}");
                        var psi = new ProcessStartInfo
                        {
                            FileName = $"http://rutracker.org/forum/tracker.php?nm={query}",
                            UseShellExecute = true
                        };

                        Process.Start(psi);
                    }
                }

                //Remove from index
                if (e.ClickedItem.Name.Equals(toolStripRemoveFromIndex.Name))
                {
                    var sb = new StringBuilder();
                    var files = new string[dgSearchResult.SelectedRows.Count];
                    SearchResultModel hit;
                    var index = 0;

                    sb.AppendLine("Remove from index following files:");
                    sb.Append(Environment.NewLine);

                    foreach (DataGridViewRow item in dgSearchResult.SelectedRows)
                    {
                        hit = (SearchResultModel)item.DataBoundItem;
                        files[index] = hit.Id;
                        sb.AppendLine(hit.FileName);
                        
                        index++;
                    }

                    if (MessageBox.Show(sb.ToString(), "Remove from index", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var fi = new FileIndexer(CancellationToken.None);
                        fi.RemoveFromIndex(files);

                        btnSearchIndex.PerformClick();
                    }
                }

                //Open file location
                if (e.ClickedItem.Name.Equals(toolStripOpenFileLocation.Name))
                {
                    if (dgSearchResult.SelectedRows.Count > 0)
                    {
                        var item = (SearchResultModel)dgSearchResult.SelectedRows[0].DataBoundItem;

                        if (File.Exists(item.Id))
                        { 
                            var psi = new ProcessStartInfo
                            {
                                Arguments = string.Format("/select, \"{0}\"", item.Id),
                                FileName = "explorer.exe",
                                UseShellExecute = true
                            };

                            Process.Start(psi);
                        }
                        else
                        {
                            statusStrip1.Items[1].Text = $"file not found: {item.Id}";
                        }
                    }
                }

                //Play file
                if (e.ClickedItem.Name.Equals(toolStripPlayFile.Name))
                {
                    if (dgSearchResult.SelectedRows.Count > 0)
                    {
                        var item = (SearchResultModel)dgSearchResult.SelectedRows[0].DataBoundItem;

                        if (File.Exists(item.Id))
                        {
                            var psi = new ProcessStartInfo
                            {
                                Arguments = item.Id,
                                FileName = "explorer.exe",
                                UseShellExecute = true
                            };

                            Process.Start(psi);
                        }
                        else
                        {
                            statusStrip1.Items[1].Text = $"file not found: {item.Id}";
                        }
                    }
                }
            }
        }

        private async void txtSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                await Search(SearchFieldsEnum.Text, txtSearchField.Text, null);
            }
        }

        private void btnClearIndex_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really want to clear index?", "Clear index", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var fi = new FileIndexer(CancellationToken.None);
                fi.ClearIndex();
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await InitializeDashboard();

            //TODO initialize available indexes, check Index and Shares folders
            cmbAvailableIndexes.DataSource = _availableIndexes;
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchField.ResetText();
            dgSearchResult.DataSource = null;
        }

        private void lvExtensionsTotal_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (lvExtensionsTotal.Sorting)
            {
                case SortOrder.None:
                    lvExtensionsTotal.Sorting = SortOrder.Ascending;
                    break;
                case SortOrder.Ascending:
                    lvExtensionsTotal.Sorting = SortOrder.Descending;
                    break;
                case SortOrder.Descending:
                    lvExtensionsTotal.Sorting = SortOrder.Ascending;
                    break;
                default:
                    lvExtensionsTotal.Sorting = SortOrder.None;
                    break;
            }

            this.lvExtensionsTotal.ListViewItemSorter = new ListViewItemComparer(e.Column, lvExtensionsTotal.Sorting, e.Column == 1 ? typeof(int) : typeof(string));
        }

        private void lvGenres_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (lvGenres.Sorting)
            {
                case SortOrder.None:
                    lvGenres.Sorting = SortOrder.Ascending;
                    break;
                case SortOrder.Ascending:
                    lvGenres.Sorting = SortOrder.Descending;
                    break;
                case SortOrder.Descending:
                    lvGenres.Sorting = SortOrder.Ascending;
                    break;
                default:
                    lvGenres.Sorting = SortOrder.None;
                    break;
            }

            this.lvGenres.ListViewItemSorter = new ListViewItemComparer(e.Column, lvGenres.Sorting, e.Column == 1 ? typeof(int) : typeof(string));
        }

        private async void lvGenres_DoubleClick(object sender, EventArgs e)
        {
            if (lvGenres.SelectedItems.Count == 0) return;

            var item = lvGenres.SelectedItems[0];

            await Search(SearchFieldsEnum.Genre, item.Text, null);

            ShowPanel(PanelEnum.Search);
        }

        private async void lvExtensionsTotal_DoubleClick(object sender, EventArgs e)
        {
            if (lvExtensionsTotal.SelectedItems.Count == 0) return;

            var item = lvExtensionsTotal.SelectedItems[0];

            await Search(SearchFieldsEnum.Extension, item.Text, null);

            ShowPanel(PanelEnum.Search);
        }

        private void lvReleaseYears_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvReleaseYears.Sorting = lvReleaseYears.Sorting switch
            {
                SortOrder.None => SortOrder.Ascending,
                SortOrder.Ascending => SortOrder.Descending,
                SortOrder.Descending => SortOrder.Ascending,
                _ => SortOrder.None,
            };

            this.lvReleaseYears.ListViewItemSorter = new ListViewItemComparer(e.Column, lvReleaseYears.Sorting, typeof(int));
        }

        private async void lvReleaseYears_DoubleClick(object sender, EventArgs e)
        {
            if (lvReleaseYears.SelectedItems.Count == 0) return;

            var item = lvReleaseYears.SelectedItems[0];

            await Search(SearchFieldsEnum.Year, item.Text, null);

            ShowPanel(PanelEnum.Search);
        }

        private async void lvLatestAdditions_DoubleClick(object sender, EventArgs e)
        {
            if (lvLatestAdditions.SelectedItems.Count == 0) return;

            var item = lvLatestAdditions.SelectedItems[0];

            await Search(SearchFieldsEnum.Release, null, new string[2] { item.SubItems[0].Text, item.SubItems[1].Text });

            ShowPanel(PanelEnum.Search);
        }

        private async void btnOptimize_Click(object sender, EventArgs e)
        {
            btnOptimize.Visible = false;
            btnStopOptimize.Visible = true;
            statusStrip1.Items[1].Text = "optimizing index...";
            
            _cts ??= new CancellationTokenSource();
            
            var fi = new FileIndexer(_cts.Token);
            await Task.Run(async () => await fi.Optimize());

            statusStrip1.Items[1].Text = "index optimization finished.";
            btnOptimize.Visible = true;
            btnStopOptimize.Visible = false;
        }

        private void btnStopOptimize_Click(object sender, EventArgs e)
        {
            _cts.Cancel();

            btnStopOptimize.Visible = false;
            btnOptimize.Visible = true;
        }

        private async void btnIndexNewFiles_Click(object sender, EventArgs e)
        {
            _cts ??= new CancellationTokenSource();

            if (_scanningStarted)
            {
                _cts.Cancel();
                _scanningStarted = false;
                IndexingStopped();
            }
            else
            {
                if (_fileList == null || !_fileList.Any())
                {
                    statusStrip1.Items[1].Text = "no files to index, please scan folder for files.";
                    return;
                }

                IndexingStarted();
                _scanningStarted = true;

                this.Update();

                _duration = TimeSpan.Zero;

                await StartIndexing(_cts.Token, true);

                _fileList = null;
                _scanningStarted = false;
                IndexingFinished();
            }
        }

        private async void btnIndexShare_Click(object sender, EventArgs e)
        {
            //after zip file is created enable label field and copy button with unique index name
            //upload file to specific cloud location
            //implement progress bar
            //update status bar
            btnIndexShare.Enabled = false;
            statusStrip1.Items[1].Text = "sharing index...";

            _cts ??= new CancellationTokenSource();
            var fi = new FileIndexer(_cts.Token);
            var res = await Task.Run(async () => await fi.ShareIndex());

            if (res.Success)
            {
                statusStrip1.Items[1].Text = $"index sharing finished. File name: {res.FileName}";
            }
            else
            {
                statusStrip1.Items[1].Text = "no index files to be shared.";
            }

            btnIndexShare.Enabled = true;
        }

        private void btnLoadIndex_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = Constants.LocalAppDataShares;
            openFileDialog2.Filter = "MusicLibrary archive (*.mla)|*.mla";

            var res = openFileDialog2.ShowDialog();

            if (res == DialogResult.OK)
            {
                var targetFolder = System.IO.Path.Combine(
                    Constants.LocalAppDataShares, 
                    System.IO.Path.GetFileNameWithoutExtension(openFileDialog2.FileName));

                if (Directory.Exists(targetFolder))
                {
                    foreach (var item in Directory.GetFiles(targetFolder))
                        File.Delete(item);
                }
                else
                {
                    Directory.CreateDirectory(targetFolder);
                }
                
                using var archive = ZipFile.OpenRead(openFileDialog2.FileName);

                foreach (var entry in archive.Entries)
                {
                    var destinationPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(targetFolder, entry.FullName));
                    entry.ExtractToFile(destinationPath, true);
                }

                _availableIndexes.Add(System.IO.Path.GetFileNameWithoutExtension(openFileDialog2.FileName));
                //TODO Set default index folder to a new one or show index selector (drop-down list)
                //it will check Index folder and sub folders under Shares folder if they are not empty
            }

            openFileDialog2.Reset();
        }
    }

    class ListViewItemComparer : IComparer
    {
        private int col;
        private Type _type;
        private SortOrder _order;

        public ListViewItemComparer()
        {
            col = 0;
            _type = null;
            _order = SortOrder.None;
        }

        public ListViewItemComparer(int column, SortOrder order, Type type)
        {
            col = column;
            _type = type;
            _order = order;
        }

        public int Compare(object x, object y)
        {
            var item1 = ((ListViewItem)x).SubItems[col].Text;
            var item2 = ((ListViewItem)y).SubItems[col].Text;

            if (_type != null)
            {
                if (_type == typeof(string))
                {
                    if (_order == SortOrder.Descending) return String.Compare(item2, item1);
                    else return String.Compare(item1, item2);
                }
                
                if (_type == typeof(int))
                {
                    if (_order == SortOrder.Descending)
                    {
                        if (int.Parse(item1) < int.Parse(item2)) return 1;
                        if (int.Parse(item1) == int.Parse(item2)) return 0;
                        if (int.Parse(item1) > int.Parse(item2)) return -1;
                    }
                    else
                    { 
                        if (int.Parse(item1) < int.Parse(item2)) return -1;
                        if (int.Parse(item1) == int.Parse(item2)) return 0;
                        if (int.Parse(item1) > int.Parse(item2)) return 1;
                    }
                }
            }

            return String.Compare(item1, item2);
        }
    }
}
