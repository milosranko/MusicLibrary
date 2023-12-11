using ATL;
using MusicLibrary.Business.Extensions;
using MusicLibrary.Business.Models;
using MusicLibrary.Common.Helpers;
using System;
using System.Threading.Tasks;

namespace MusicLibrary.Business;

public class MetaTagsService
{
	public Task SetMetaTags(SearchResultModel[] files)
	{
		if (files.Length == 0) return Task.CompletedTask;

		try
		{
			Parallel.ForEach(files, file =>
			{
				var track = new Track(file.Id);

				if (file == null) return;

				track.SetMetaTags(MetatagsHelpers.GetMetatags(file.Tags));
			});
		}
		catch (Exception)
		{
		}

		return Task.CompletedTask;
	}
}
