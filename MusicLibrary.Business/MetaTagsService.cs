using ATL;
using MusicLibrary.Business.Extensions;
using MusicLibrary.Business.Models;
using MusicLibrary.Common.Helpers;

namespace MusicLibrary.Business;

public class MetaTagsService
{
    public Task SetMetaTags(SearchResultModel[] files)
    {
        if (files.Length == 0) return Task.CompletedTask;

        try
        {
            Parallel.ForEach(files, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount - 1 }, file =>
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
