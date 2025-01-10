using System;
using System.Drawing;
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
        private static readonly string destinationDirName = "php";
        private static readonly string defaultDocumentRootName = "document";

        private int PHPSetupStatus = 0;

        public PHPAutoSetup(int Theme)
        {
            InitializeComponent();
            SetupDetail.Text = string.Empty;
            ChangeTheme(Theme);
        }

        /// <summary>
        /// ウインドウのテーマを設定します
        /// </summary>
        /// <param name="themeNumber">設定したいテーマの番号</param>
        private void ChangeTheme(int themeNumber)
        {
            switch (themeNumber)
            {
                // ダーク
                case 0:
                    BackColor = Color.FromArgb(32, 32, 32);
                    ForeColor = Color.FromArgb(255, 255, 255);
                    StartSetup.BackColor = Color.FromArgb(56, 56, 56);
                    break;
                // デフォルト
                case 1:
                default:
                    return;
            }
        }

        private void StartSetup_Click(object sender, EventArgs e)
        {
            switch (PHPSetupStatus)
            {
                case 0:
                    FileDLAndExt();
                    //if (PHPSetupStatus != 2) { Close(); }
                    break;
                case 1:
                case 2:
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
            StartSetup.Text = "キャンセル";

            string localAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RC_of_Computer");
            string TempFilePath = Path.Combine(localAppDataPath, destinationFileName);

            Progress<float> progress = new();
            progress.ProgressChanged += Progress_ProgressChanged;

            CancellationTokenSource source = new();
            CancellationToken token = source.Token;

            HttpClient httpClient = new();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "C# App");

            try
            {
                using FileStream file = new(TempFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
                await httpClient.DownloadDataAsync(PHPDownloadUrl, file, progress, token);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("インストール先ディレクトリへのアクセス権限がありません。セットアップを中止します。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            httpClient.Dispose();

            SetupProgress.Value = 0;
            SetupDetail.Text = "展開しています...";

            string extDir = Path.Combine(localAppDataPath, destinationDirName);
            Directory.CreateDirectory(extDir);

            using (var zip = ZipFile.OpenRead(TempFilePath))
            {
                foreach (ZipArchiveEntry entry in zip.Entries)
                {
                    string destPath = Path.GetFullPath(Path.Combine(extDir, entry.FullName));
                    // Zip Slip対策、悪意のあるZipファイルを展開しようとしたとき処理を中断する
                    if (!destPath.StartsWith(extDir))
                    {
                        MessageBox.Show("ファイル整合性エラーが発生しました。セットアップを中止します。\n対象ファイル: " + destPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // ファイルの展開処理
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

            if (File.Exists(TempFilePath))
            {
                File.Delete(TempFilePath);
            }
            
            string documentRoot = Path.Combine(localAppDataPath, defaultDocumentRootName);
            Directory.CreateDirectory(documentRoot);

            Properties.Settings.Default.WebServerSoftware = "PHP";
            Properties.Settings.Default.PHPExeFilePath = Path.Combine(extDir, "php.exe");
            Properties.Settings.Default.UsePATHValue = false;
            Properties.Settings.Default.DocumentRoot = documentRoot;
            Properties.Settings.Default.IPAddress = "0.0.0.0";
            Properties.Settings.Default.PortNumber = 8000;
            Properties.Settings.Default.Save();

            PHPSetupStatus = 2;
            Description.Text = "PHPのセットアップが完了しました。";
            SetupDetail.Text = string.Empty;
            StartSetup.Text = "セットアップを終了";
        }

        private void Progress_ProgressChanged(object sender, float progress)
        {
            // Do something with your progress
            SetupProgress.Value = (int)progress;
            SetupDetail.Text = "ダウンロード中... " + (int)progress + "%";
        }

        private void PHPAutoSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (PHPSetupStatus)
            {
                case 0:
                case 1:
                    DialogResult = DialogResult.Cancel;
                    break;
                case 2:
                    DialogResult = DialogResult.OK;
                    break;
            }
        }
    }
}
