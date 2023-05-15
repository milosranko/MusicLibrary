using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace MusicLibrary.Forms
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceProvider = new ServiceCollection()
                .AddMemoryCache()
                .BuildServiceProvider();

            PrepareFFMpegFiles();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void PrepareFFMpegFiles()
        {
            var path = $"{Environment.CurrentDirectory}\\ffmpeg\\ffmpeg.zip";

            if (!File.Exists(path)) return;

            using (var archive = ZipFile.OpenRead(path))
            {
                foreach (var entry in archive.Entries)
                {
                    var destinationPath = Path.GetFullPath(Path.Combine($"{Environment.CurrentDirectory}\\ffmpeg", entry.FullName));
                    entry.ExtractToFile(destinationPath, true);
                }
            }

            File.Delete(path);
        }
    }
}
