using ATL;
using MusicLibrary.Business.Extensions;
using MusicLibrary.Business.Models;
using MusicLibrary.Common.Helpers;

namespace MusicLibrary.Business;

public class MetaTagsService
{
    public void SetAndSaveMetaTags(SearchResultModel[] files)
    {
        if (files.Length == 0) return;

        try
        {
            Parallel.ForEach(files, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }, file =>
            {
                var track = new Track(file.FullFilePath);

                if (file == null) return;

                track.SetMetaTags(MetatagsHelpers.GetMetatags(file.Tags));
                _ = track.Save();
            });
        }
        catch (Exception)
        {
        }
    }
}
