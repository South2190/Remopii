using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using RC_of_Computer.Classes;

namespace RC_of_Computer.FunctionSetup
{
    public partial class PHPAutoSetup : Form
    {
        private static readonly string PHPDownloadUrl = "https://windows.php.net/downloads/releases/archives/php-8.3.9-Win32-vs16-x64.zip";
        //private static readonly string PHPDownloadUrl = "https://httpstat.us/502";
        private static readonly string destinationFileName = "PHP.zip";

        private static readonly HttpClient httpClient = new();

        public PHPAutoSetup()
        {
            InitializeComponent();
        }

        private void StartSetup_Click(object sender, EventArgs e)
        {
            //SetupProgress.Value = 0;
            //Description.Text = "PHPのセットアップ中です";
            //SetupDetail.Text = "ダウンロードしています...";

            //Progress<float> progress = new();
            //progress.ProgressChanged += Progress_ProgressChanged;

            //httpClient.DefaultRequestHeaders.Add("User-Agent", "C# App");

            string currentDirectory = Directory.GetCurrentDirectory();
            //string tempFile = Path.Combine(currentDirectory, destinationFileName);

            //using (FileStream file = new(tempFile, FileMode.Create, FileAccess.Write, FileShare.None))
            //    await httpClient.DownloadDataAsync(PHPDownloadUrl, file, progress);

            //httpClient.Dispose();

            SetupDetail.Text = "展開しています...";
            SetupProgress.Value = 0;

            string destinationDirName = @"php\";
            Directory.CreateDirectory(destinationDirName);
            string extDir = Path.Combine(currentDirectory, destinationDirName);

            using (var zip = ZipFile.OpenRead(destinationFileName))
            {
                foreach (ZipArchiveEntry entry in zip.Entries)
                {
                    // 以下の行を修正
                    string destPath = Path.GetFullPath(Path.Combine(extDir, entry.FullName));
                    // 以下の4行を追加
                    if (!destPath.StartsWith(currentDirectory))
                    {
                        //throw new Exception("Malicious entry has detected.");
                        MessageBox.Show("ファイル整合性エラーが発生しました。セットアップを中止します。\n対象ファイル: " + destPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (Regex.IsMatch(destPath, @"\\$"))
                    {
                        Directory.CreateDirectory(destPath);
                    }
                    else
                    {
                        entry.ExtractToFile(destPath, true);    // ファイルを上書きする
                    }
                }
            }

            //if (File.Exists(tempFile))
            //{
            //    File.Delete(tempFile);
            //}

            Description.Text = "PHPのセットアップが完了しました。";
            SetupDetail.Text = string.Empty;
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
