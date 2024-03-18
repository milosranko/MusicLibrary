using MusicLibrary.Business;
using MusicLibrary.Business.Models;
using MusicLibrary.Common;
using MusicLibrary.Common.Helpers;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary.Forms;

public partial class MetaTagsForm : Form
{
    public SearchResultModel[] Files { get; set; }

    public MetaTagsForm()
    {
        InitializeComponent();
    }

    private void MetaTagsForm_Load(object sender, EventArgs e)
    {
        if (Files == null || Files.Count() == 0) return;

        dgFilesSelected.DataSource = Files;
        dgFilesSelected.ClearSelection();
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (dgFilesSelected.SelectedRows.Count == 0) return;
        if (txtAlbum.Text.Equals(Constants.MultipleValues) &&
            txtArtist.Text.Equals(Constants.MultipleValues) &&
            txtGenre.Text.Equals(Constants.MultipleValues) &&
            txtTrackNumber.Text.Equals(Constants.MultipleValues) &&
            txtTrackTitle.Text.Equals(Constants.MultipleValues) &&
            txtYear.Text.Equals(Constants.MultipleValues)) return;

        this.Enabled = false;
        gbMetaTags.Enabled = false;

        var metaTagsService = new MetaTagsService();
        await metaTagsService.SetMetaTags(Files);

        var cts = new CancellationTokenSource();
        var fi = new FileIndexer(cts.Token);

        await Task.Run(() => fi.StartIndexing(Files.Select(x => x.Id), null), cts.Token);

        this.Enabled = true;
        gbMetaTags.Enabled = true;
        MessageBox.Show(this, "Saved succesfully!", "Meta tags saved", MessageBoxButtons.OK);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        dgFilesSelected.ClearSelection();
        btnSave.Enabled = false;
        ClearFormFields();
    }

    private void ClearFormFields()
    {
        txtArtist.ResetText();
        txtAlbum.ResetText();
        txtYear.ResetText();
        txtGenre.ResetText();
        txtTrackTitle.ResetText();
        txtTrackNumber.ResetText();
    }

    private void SetFormFieldsValue(
        string artist,
        string album,
        string year,
        string genre,
        string trackTitle,
        string trackNo)
    {
        txtArtist.Text = artist;
        txtAlbum.Text = album;
        txtYear.Text = year;
        txtGenre.Text = genre;
        txtTrackTitle.Text = trackTitle;
        txtTrackNumber.Text = trackNo;
    }

    private void dgFilesSelected_SelectionChanged(object sender, EventArgs e)
    {
        if (dgFilesSelected.SelectedRows.Count > 1)
        {
            var artist = string.Empty;
            var album = string.Empty;
            var year = string.Empty;
            var genre = string.Empty;
            var trackTitle = string.Empty;
            var trackNo = string.Empty;
            var selectedItems = dgFilesSelected.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(x => (SearchResultModel)x.DataBoundItem)
                .ToArray();

            for (int i = 0; i < selectedItems.Length; i++)
            {
                var tags = selectedItems[i].Tags.Split("|");

                if (i == 0)
                {
                    artist = tags[0];
                    album = tags[1];
                    year = tags[2];
                    genre = tags[3];
                    trackTitle = tags[4];
                    trackNo = tags[5];
                }
                else
                {
                    if (artist.Equals(Constants.MultipleValues) &&
                        album.Equals(Constants.MultipleValues) &&
                        year.Equals(Constants.MultipleValues) &&
                        genre.Equals(Constants.MultipleValues) &&
                        trackTitle.Equals(Constants.MultipleValues) &&
                        trackNo.Equals(Constants.MultipleValues)) break;

                    if (!artist.Equals(Constants.MultipleValues) && !artist.Equals(tags[0]))
                        artist = Constants.MultipleValues;
                    if (!album.Equals(Constants.MultipleValues) && !album.Equals(tags[1]))
                        album = Constants.MultipleValues;
                    if (!year.Equals(Constants.MultipleValues) && !year.Equals(tags[2]))
                        year = Constants.MultipleValues;
                    if (!genre.Equals(Constants.MultipleValues) && !genre.Equals(tags[3]))
                        genre = Constants.MultipleValues;
                    if (!trackTitle.Equals(Constants.MultipleValues) && !trackTitle.Equals(tags[4]))
                        trackTitle = Constants.MultipleValues;
                    if (!trackNo.Equals(Constants.MultipleValues) && !trackNo.Equals(tags[5]))
                        trackNo = Constants.MultipleValues;
                }
            }

            SetFormFieldsValue(artist, album, year, genre, trackTitle, trackNo);
        }
        else if (dgFilesSelected.SelectedRows.Count == 1)
        {
            var row = ((SearchResultModel)dgFilesSelected.SelectedRows
                .Cast<DataGridViewRow>()
                .Single()
                .DataBoundItem);

            SetFormFieldsValue(
                row.Artist,
                row.Album,
                row.Year.HasValue ? row.Year.ToString() : string.Empty,
                row.Genre,
                row.TrackName,
                row.TrackNumber.HasValue ? row.TrackNumber.ToString() : string.Empty);
        }
        else
        {
            ClearFormFields();
        }

        btnSave.Enabled = true;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnGetMetadata_Click(object sender, EventArgs e)
    {
        var onlineMetatagsForm = new OnlineMetatagsForm
        {
            Artist = txtArtistName.Text,
            Release = txtAlbumName.Text,
            Year = txtReleaseYear.Text
        };

        if (onlineMetatagsForm.ShowDialog(this) == DialogResult.OK)
        {
            ApplyOnlineMetatags(onlineMetatagsForm.Result);
        }
        else
        {
            MessageBox.Show(this, "No results, try again with different parameters!", "Online search result", MessageBoxButtons.OK);
        }
    }

    private void btnUseCurrent_Click(object sender, EventArgs e)
    {
        if (dgFilesSelected.SelectedRows.Count > 0)
        {
            var firstSelected = (SearchResultModel)dgFilesSelected.SelectedRows
                .Cast<DataGridViewRow>()
                .First()
                .DataBoundItem;

            txtArtistName.Text = firstSelected.Artist;
            txtAlbumName.Text = firstSelected.Album;
            txtReleaseYear.Text = firstSelected.Year.HasValue ? firstSelected.Year.Value.ToString() : string.Empty;
        }
    }

    private void ApplyOnlineMetatags(MusicBrainzSearchResult musicBrainz)
    {
        if (musicBrainz.Tracks == null || !musicBrainz.Tracks.Any()) return;

        for (int i = 0; i < Files.Length; i++)
        {
            if (!string.IsNullOrEmpty(musicBrainz.Artist))
                Files[i].Artist = musicBrainz.Artist;

            if (!string.IsNullOrEmpty(musicBrainz.Release))
                Files[i].Album = musicBrainz.Release;

            if (!string.IsNullOrEmpty(musicBrainz.Year))
                Files[i].Year = string.IsNullOrEmpty(musicBrainz.Year) ? 0 : int.Parse(musicBrainz.Year);

            if (!string.IsNullOrEmpty(musicBrainz.Genre))
                Files[i].Genre = musicBrainz.Genre;

            if (!string.IsNullOrEmpty(musicBrainz.Tracks.ElementAtOrDefault(i)))
            {
                Files[i].TrackName = musicBrainz.Tracks.ElementAt(i);
                Files[i].TrackNumber = i + 1;
            }

            Files[i].Tags = MetatagsHelpers.CreateMetatags(
                Files[i].Artist,
                Files[i].Album,
                Files[i].Year.HasValue ? Files[i].Year.ToString() : string.Empty,
                Files[i].Genre,
                Files[i].TrackName,
                Files[i].TrackNumber.HasValue ? Files[i].TrackNumber.ToString() : string.Empty);
        }

        dgFilesSelected.Refresh();
    }

    private void dgFilesSelected_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        //Title
        if (e.ColumnIndex == 4)
        {
            var tags = MetatagsHelpers.GetMetatags(Files[e.RowIndex].Tags);
            tags[4] = (string)dgFilesSelected[e.ColumnIndex, e.RowIndex].Value;
            Files[e.RowIndex].Tags = string.Join("|", tags);
        }

        //Track no
        if (e.ColumnIndex == 5)
        {
            var tags = MetatagsHelpers.GetMetatags(Files[e.RowIndex].Tags);
            tags[5] = ((int)dgFilesSelected[e.ColumnIndex, e.RowIndex].Value).ToString();
            Files[e.RowIndex].Tags = string.Join("|", tags);
        }
    }

    private void txtArtist_TextChanged(object sender, EventArgs e)
    {
        if (txtArtist.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(Files[row.Index].Tags);
            tags[0] = txtArtist.Text;
            Files[row.Index].Artist = txtArtist.Text;
            Files[row.Index].Tags = string.Join("|", tags);
        }
    }

    private void txtAlbum_TextChanged(object sender, EventArgs e)
    {
        if (txtAlbum.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(Files[row.Index].Tags);
            tags[1] = txtAlbum.Text;
            Files[row.Index].Album = txtAlbum.Text;
            Files[row.Index].Tags = string.Join("|", tags);
        }
    }

    private void txtTrackTitle_TextChanged(object sender, EventArgs e)
    {
        if (txtTrackTitle.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(Files[row.Index].Tags);
            tags[4] = txtTrackTitle.Text;
            Files[row.Index].TrackName = txtTrackTitle.Text;
            Files[row.Index].Tags = string.Join("|", tags);
        }

        dgFilesSelected.Refresh();
    }

    private void txtYear_TextChanged(object sender, EventArgs e)
    {
        if (txtYear.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(Files[row.Index].Tags);
            tags[2] = txtYear.Text;
            Files[row.Index].Year = int.Parse(txtYear.Text);
            Files[row.Index].Tags = string.Join("|", tags);
        }
    }

    private void txtTrackNumber_TextChanged(object sender, EventArgs e)
    {
        if (txtTrackNumber.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(Files[row.Index].Tags);
            tags[5] = txtTrackNumber.Text;
            Files[row.Index].TrackNumber = int.Parse(txtTrackNumber.Text);
            Files[row.Index].Tags = string.Join("|", tags);
        }

        dgFilesSelected.Refresh();
    }

    private void txtGenre_TextChanged(object sender, EventArgs e)
    {
        if (txtGenre.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(Files[row.Index].Tags);
            tags[3] = txtGenre.Text;
            Files[row.Index].Genre = txtGenre.Text;
            Files[row.Index].Tags = string.Join("|", tags);
        }
    }

    private void dgFilesSelected_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
        {
            dgFilesSelected.EditMode = DataGridViewEditMode.EditOnEnter;
            dgFilesSelected.BeginEdit(true);
        }
    }
}
