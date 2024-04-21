using MusicLibrary.Business;
using MusicLibrary.Business.Models;
using MusicLibrary.Common;
using MusicLibrary.Common.Helpers;

namespace MusicLibrary.Forms;

public partial class MetaTagsForm : Form
{
    private readonly SearchResultModel[] _files;
    public bool MetaTagsUpdated { get; private set; } = false;

    public MetaTagsForm(SearchResultModel[] files)
    {
        _files = files;
        InitializeComponent();
    }

    private void MetaTagsForm_Load(object sender, EventArgs e)
    {
        if (_files == null || _files.Length == 0) return;

        dgFilesSelected.DataSource = _files;
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
        await Task.Run(() => metaTagsService.SetAndSaveMetaTags(_files));

        var cts = new CancellationTokenSource();
        var fi = new FileIndexer(cts.Token);

        await Task.Run(() => fi.StartIndexing(_files.Select(x => x.FullFilePath), null), cts.Token);

        this.Enabled = true;
        gbMetaTags.Enabled = true;
        MetaTagsUpdated = true;
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

        for (int i = 0; i < _files.Length; i++)
        {
            if (!string.IsNullOrEmpty(musicBrainz.Artist))
                _files[i].Artist = musicBrainz.Artist;

            if (!string.IsNullOrEmpty(musicBrainz.Release))
                _files[i].Album = musicBrainz.Release;

            if (!string.IsNullOrEmpty(musicBrainz.Year))
                _files[i].Year = string.IsNullOrEmpty(musicBrainz.Year) ? 0 : int.Parse(musicBrainz.Year);

            if (!string.IsNullOrEmpty(musicBrainz.Genre))
                _files[i].Genre = musicBrainz.Genre;

            if (!string.IsNullOrEmpty(musicBrainz.Tracks.ElementAtOrDefault(i)))
            {
                _files[i].TrackName = musicBrainz.Tracks.ElementAt(i);
                _files[i].TrackNumber = i + 1;
            }

            _files[i].Tags = MetatagsHelpers.CreateMetatags(
                _files[i].Artist,
                _files[i].Album,
                _files[i].Year.HasValue ? _files[i].Year.ToString() : string.Empty,
                _files[i].Genre,
                _files[i].TrackName,
                _files[i].TrackNumber.HasValue ? _files[i].TrackNumber.ToString() : string.Empty);
        }

        dgFilesSelected.Refresh();
    }

    private void dgFilesSelected_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        //Title
        if (e.ColumnIndex == 4)
        {
            var tags = MetatagsHelpers.GetMetatags(_files[e.RowIndex].Tags);
            tags[4] = (string)dgFilesSelected[e.ColumnIndex, e.RowIndex].Value;
            _files[e.RowIndex].Tags = string.Join("|", tags);
        }

        //Track no
        if (e.ColumnIndex == 5)
        {
            var tags = MetatagsHelpers.GetMetatags(_files[e.RowIndex].Tags);
            tags[5] = ((int)dgFilesSelected[e.ColumnIndex, e.RowIndex].Value).ToString();
            _files[e.RowIndex].Tags = string.Join("|", tags);
        }
    }

    private void txtArtist_TextChanged(object sender, EventArgs e)
    {
        if (txtArtist.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(_files[row.Index].Tags);
            tags[0] = txtArtist.Text;
            _files[row.Index].Artist = txtArtist.Text;
            _files[row.Index].Tags = string.Join("|", tags);
        }
    }

    private void txtAlbum_TextChanged(object sender, EventArgs e)
    {
        if (txtAlbum.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(_files[row.Index].Tags);
            tags[1] = txtAlbum.Text;
            _files[row.Index].Album = txtAlbum.Text;
            _files[row.Index].Tags = string.Join("|", tags);
        }
    }

    private void txtTrackTitle_TextChanged(object sender, EventArgs e)
    {
        if (txtTrackTitle.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(_files[row.Index].Tags);
            tags[4] = txtTrackTitle.Text;
            _files[row.Index].TrackName = txtTrackTitle.Text;
            _files[row.Index].Tags = string.Join("|", tags);
        }

        dgFilesSelected.Refresh();
    }

    private void txtYear_TextChanged(object sender, EventArgs e)
    {
        if (txtYear.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(_files[row.Index].Tags);
            tags[2] = txtYear.Text;
            _files[row.Index].Year = int.Parse(txtYear.Text);
            _files[row.Index].Tags = string.Join("|", tags);
        }
    }

    private void txtTrackNumber_TextChanged(object sender, EventArgs e)
    {
        if (txtTrackNumber.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(_files[row.Index].Tags);
            tags[5] = txtTrackNumber.Text;
            _files[row.Index].TrackNumber = int.Parse(txtTrackNumber.Text);
            _files[row.Index].Tags = string.Join("|", tags);
        }

        dgFilesSelected.Refresh();
    }

    private void txtGenre_TextChanged(object sender, EventArgs e)
    {
        if (txtGenre.Text.Equals(Constants.MultipleValues)) return;

        foreach (DataGridViewRow row in dgFilesSelected.SelectedRows)
        {
            var tags = MetatagsHelpers.GetMetatags(_files[row.Index].Tags);
            tags[3] = txtGenre.Text;
            _files[row.Index].Genre = txtGenre.Text;
            _files[row.Index].Tags = string.Join("|", tags);
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
