using System;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

using RC_of_Computer.Classes;

namespace RC_of_Computer.FunctionSetup
{
    public partial class PHPAutoSetup : Form
    {
        private static readonly string PHPDownloadUrl = "https://windows.php.net/downloads/releases/archives/php-8.3.9-Win32-vs16-x64.zip";
        private static readonly string destinationFileName = "PHP.zip";
        private static readonly string destinationDirName = @"php\";
        private static readonly string defaultDocumentRootName = @"document\";

        private int PHPSetupStatus = 0;

        public PHPAutoSetup()
        {
            InitializeComponent();
            SetupDetail.Text = string.Empty;
        }

        private void StartSetup_Click(object sender, EventArgs e)
        {
            switch (PHPSetupStatus)
            {
                case 0:
                    FileDLAndExt();
                    break;
                case 1:
                    Close();
                    break;
            }
        }

        private async void FileDLAndExt()
        {
            PHPSetupStatus = 1;
            SetupProgress.Value = 0;
            Description.Text = "PHPのセットアップ中です...";
            SetupDetail.Text = "ダウンロードを開始中...";
            StartSetup.Text = "セットアップを終了";
            StartSetup.Enabled = false;

            string currentDirectory = Directory.GetCurrentDirectory();
            string tempFile = Path.Combine(currentDirectory, destinationFileName);

            Progress<float> progress = new();
            progress.ProgressChanged += Progress_ProgressChanged;

            CancellationTokenSource source = new();
            CancellationToken token = source.Token;

            HttpClient httpClient = new();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "C# App");

            using (FileStream file = new(tempFile, FileMode.Create, FileAccess.Write, FileShare.None))
                await httpClient.DownloadDataAsync(PHPDownloadUrl, file, progress, token);

            httpClient.Dispose();

            SetupProgress.Value = 0;
            SetupDetail.Text = "展開しています...";

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

            if (File.Exists(tempFile))
            {
                File.Delete(tempFile);
            }
            
            string documentRoot = Path.Combine(currentDirectory, defaultDocumentRootName);
            Directory.CreateDirectory(documentRoot);

            Properties.Settings.Default.WebServerSoftware = "PHP";
            Properties.Settings.Default.PHPExeFilePath = Path.Combine(extDir, "php.exe");
            Properties.Settings.Default.UsePATHValue = false;
            Properties.Settings.Default.DocumentRoot = documentRoot;
            Properties.Settings.Default.IPAddress = "0.0.0.0";
            Properties.Settings.Default.PortNumber = 8000;
            Properties.Settings.Default.Save();

            Description.Text = "PHPのセットアップが完了しました。";
            SetupDetail.Text = string.Empty;
            StartSetup.Enabled = true;
        }

        private void Progress_ProgressChanged(object sender, float progress)
        {
            // Do something with your progress
            SetupProgress.Value = (int)progress;
            SetupDetail.Text = "ダウンロード中... " + (int)progress + "%";
        }
    }
}
