using MusicLibrary.Business;
using MusicLibrary.Business.Models;
using MusicLibrary.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary.Forms;

public partial class ConvertFilesForm : Form
{
	public SearchResultModel[] Files { get; set; }
	private CancellationTokenSource _cts;
	private delegate void SafeCallDelegate(string text);
	private string _conversionStarted = "File conversion has started... {0} files";
	private string _conversionInProgress = "File conversion in progress... {0} left of {1} files";

	public ConvertFilesForm()
	{
		InitializeComponent();
	}

	private async void btnConvert_Click(object sender, EventArgs e)
	{
		try
		{
			await ConvertFiles(
				new Queue<string>(
					Files
					.Where(x => Path.GetExtension(x.FileName).EndsWith("flac"))
					.Select(x => x.Id)),
				cbBitRate.SelectedIndex);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
			ConversionStopped();
		}
	}

	private async Task ConvertFiles(Queue<string> files, int bitrateSelectedIndex)
	{
		_cts ??= new CancellationTokenSource();
		ConversionStarted(files.Count);

		var fc = new FileConverter(files, folderBrowserDialog1.SelectedPath, ConversionProgress, _cts.Token);
		await Task.Run(async () => await fc.ConvertFiles(bitrateSelectedIndex));

		ConversionFinished();
	}

	private void ConversionStarted(int filesCount)
	{
		lblConversionStatus.Text = string.Format(_conversionStarted, filesCount);
		btnConvert.Visible = false;
		btnStopConversion.Visible = true;
		btnClose.Enabled = false;
		cbBitRate.Enabled = false;
	}

	private void WriteTextSafe(string text)
	{
		if (lblConversionStatus.InvokeRequired)
		{
			var d = new SafeCallDelegate(WriteTextSafe);
			lblConversionStatus.Invoke(d, new object[] { text });
		}
		else
		{
			lblConversionStatus.Text = text;
		}
	}

	private void ConversionProgress(int fileNo)
	{
		WriteTextSafe(string.Format(_conversionInProgress, fileNo, Files.Length));
	}

	private void ConversionFinished()
	{
		lblConversionStatus.Text = "Conversion finished.";
		btnStopConversion.Visible = false;
		btnConvert.Visible = true;
		btnClose.Enabled = true;
		cbBitRate.Enabled = true;
	}

	private void ConversionStopped()
	{
		lblConversionStatus.Text = "Conversion stopped.";
		btnStopConversion.Visible = false;
		btnConvert.Visible = true;
		btnClose.Enabled = true;
		cbBitRate.Enabled = true;
	}

	private void btnStopConversion_Click(object sender, EventArgs e)
	{
		_cts?.Cancel();
		ConversionStopped();
	}

	private void ConvertFilesForm_Load(object sender, EventArgs e)
	{
		if (Files == null || Files.Count() == 0) return;

		lvFiles.Items.AddRange(Files.Select(x => new ListViewItem { Text = x.Id }).ToArray());

		cbBitRate.Items.AddRange(Constants.Bitrates.Select(x => $"{x} kbps").ToArray());
		cbBitRate.SelectedIndex = 2;
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		this.Close();
	}

	private void btnDestinationFolder_Click(object sender, EventArgs e)
	{
		var dialogRes = folderBrowserDialog1.ShowDialog(this);

		if (dialogRes == DialogResult.OK)
		{
			lblSelectedFolder.Text = folderBrowserDialog1.SelectedPath;
		}
	}
}
