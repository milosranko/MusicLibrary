using MusicLibrary.Business;
using MusicLibrary.Business.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary.Forms;

public partial class OnlineMetatagsForm : Form
{
	private readonly MusicBrainzService _mbService;
	public MusicBrainzSearchResult Result { get; set; }
	private IEnumerable<MusicBrainzSearchResult> Releases { get; set; }
	public string Artist, Release, Year;

	public OnlineMetatagsForm()
	{
		InitializeComponent();

		_mbService = new MusicBrainzService();
	}

	private void OnlineMetatagsForm_Load(object sender, EventArgs e)
	{
		Releases = Task.Run(async () => await _mbService.Search(Artist, Release, Year)).Result;

		if (!Releases.Any()) return;

		lvReleases.Items.AddRange(Releases.Select(x => new ListViewItem($"{x.Artist} - {x.Release} - {x.Year} - {x.NumberOfTracks} tracks")).ToArray());
	}

	private void lvReleases_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
	{
		if (e.ItemIndex >= 0 && lvReleases.SelectedItems.Count > 0) btnNext.Enabled = true;
		else btnNext.Enabled = false;
	}

	private async void btnNext_Click(object sender, EventArgs e)
	{
		if (lvReleases.SelectedItems.Count == 0) return;

		Result = await _mbService.GetTracks(Releases.ElementAt(lvReleases.SelectedItems[0].Index));

		if (Result.Equals(MusicBrainzSearchResult.Empty)) return;

		pnlReleases.Visible = false;
		pnlTracks.Visible = true;

		lblArtist.Text = Result.Artist;
		lblRelease.Text = Result.Release;
		lblGenre.Text = Result.Genre;
		lblYear.Text = Result.Year;

		if (Result.Tracks != null && Result.Tracks.Any())
		{
			var index = 1;

			lvTracks.Clear();
			lvTracks.Items.AddRange(Result.Tracks.Select(x => new ListViewItem($"{index++} {x}")).ToArray());
		}
	}

	private void btnBack_Click(object sender, EventArgs e)
	{
		pnlReleases.Visible = true;
		pnlTracks.Visible = false;
	}

	private void btnApply_Click(object sender, EventArgs e)
	{
		this.DialogResult = DialogResult.OK;
		this.Close();
	}
}
