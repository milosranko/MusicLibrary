using System;

namespace MusicLibrary.Common;

public static class Constants
{
	public const string MultipleValues = "< keep >";
	public static readonly string[] MusicFileExtensions = { "mp3", "flac" };
	public static int[] Bitrates = [128, 192, 256, 320];

	public static readonly string LocalAppDataShares =
		Environment.GetFolderPath(
			Environment.SpecialFolder.LocalApplicationData,
			Environment.SpecialFolderOption.Create) + "\\MusicLibrary\\Shares";

	public static readonly string LocalAppDataIndex =
		Environment.GetFolderPath(
			Environment.SpecialFolder.LocalApplicationData,
			Environment.SpecialFolderOption.Create) + "\\MusicLibrary\\Index";

	public static readonly string LocalAppDataLists =
		Environment.GetFolderPath(
			Environment.SpecialFolder.LocalApplicationData,
			Environment.SpecialFolderOption.Create) + "\\MusicLibrary\\Lists";
}
