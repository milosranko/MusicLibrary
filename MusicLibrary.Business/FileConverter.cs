using MusicLibrary.Common;
using Xabe.FFmpeg;

namespace MusicLibrary.Business;

public class FileConverter
{
    private readonly Queue<string> _filesQueue;
    private readonly string _outputPath;
    private SemaphoreSlim _semaphore;
    private Action<int> _statusProgress;
    private CancellationToken _ct;

    public FileConverter(
        Queue<string> files,
        string outputPath,
        Action<int> statusProgress,
        CancellationToken ct)
    {
        _filesQueue = files;
        _outputPath = outputPath;
        _semaphore = new SemaphoreSlim(Environment.ProcessorCount, Environment.ProcessorCount);
        _statusProgress = statusProgress;
        _ct = ct;
    }

    public async Task ConvertFiles(int bitrateIndex)
    {
        if (string.IsNullOrEmpty(FFmpeg.ExecutablesPath))
            FFmpeg.SetExecutablesPath($"{Environment.CurrentDirectory}\\ffmpeg");

        var tasks = new List<Task>(_filesQueue.Count);

        while (_filesQueue.Count > 0)
            tasks.Add(await Task.Factory.StartNew(async () => await StartConversion(_filesQueue.Dequeue(), bitrateIndex, _filesQueue.Count)));

        Task.WaitAll(tasks.ToArray(), _ct);
    }

    private async Task StartConversion(string file, int bitrateIndex, int index)
    {
        await _semaphore.WaitAsync(_ct);

        try
        {
            var outputPath = GetOutputPath(file);
            var mediaInfo = await FFmpeg.GetMediaInfo(file);
            var audioStream = mediaInfo.AudioStreams.FirstOrDefault()
                ?.SetCodec(AudioCodec.mp3);

            _statusProgress?.Invoke(index);

            await FFmpeg.Conversions.New()
                .AddStream(audioStream)
                .SetAudioBitrate(Constants.Bitrates[bitrateIndex] * 1000)
                .SetOutput(outputPath)
                .SetOverwriteOutput(true)
                .UseMultiThread(false)
                .Start();
        }
        finally
        {
            _semaphore.Release();
        }
    }

    private string GetOutputPath(string file)
    {
        if (string.IsNullOrEmpty(_outputPath)) return Path.ChangeExtension(file, ".mp3");

        return Path.ChangeExtension($"{_outputPath}\\{Path.GetFileName(file)}", ".mp3");
    }
}
