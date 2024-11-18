using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

using RC_of_Computer.Classes;

namespace RC_of_Computer.FunctionSetup
{
    public partial class PHPAutoSetup : Form
    {
        //private static readonly string PHPDownloadUrl = "https://windows.php.net/downloads/releases/archives/php-8.3.9-Win32-vs16-x64.zip";
        private static readonly string PHPDownloadUrl = "https://httpstat.us/502";
        private static readonly string destinationFolder = @"C:\Users\SHELL\Documents\GitHubリポジトリ\testdir";
        private static readonly string destinationFileName = "PHP.zip";

        private static readonly HttpClient httpClient = new();
        private static readonly string filePath = Path.Combine(destinationFolder, destinationFileName);

        public PHPAutoSetup()
        {
            InitializeComponent();
        }

        private async void StartSetup_Click(object sender, EventArgs e)
        {
            Description.Text = "PHPのセットアップ中です";
            SetupDetail.Text = "ダウンロード中...";

            Progress<float> progress = new();
            progress.ProgressChanged += Progress_ProgressChanged;

            httpClient.DefaultRequestHeaders.Add("User-Agent", "C# App");

            string path = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(path);

            using (FileStream file = new(Path.Combine(path, "PHP.tmp"), FileMode.Create, FileAccess.Write, FileShare.None))
                await httpClient.DownloadDataAsync(PHPDownloadUrl, file, progress);

            httpClient.Dispose();

            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
        }

        private void Progress_ProgressChanged(object sender, float progress)
        {
            // Do something with your progress
            //Debug.WriteLine(progress);
            SetupProgress.Value = (int)progress;
            SetupDetail.Text = "ダウンロード中... " + (int)progress + "%";
        }

        /*
        private static void FolderContext(Action<string> f)
        {
            string path = string.Empty;
            try
            {
                // 一時フォルダに作業用のサブフォルダを作成
                path = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                Directory.CreateDirectory(path);

                f(path);
            }
            finally
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                }
            }
        }
        */
    }
}
