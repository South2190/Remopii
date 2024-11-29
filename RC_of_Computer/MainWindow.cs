using RC_of_Computer.Classes;
using RC_of_Computer.FunctionSetup;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;
using System;

namespace RC_of_Computer
{
    public partial class MainWindow : Form
    {
        private const string IMAGERESDLL = @"C:\Windows\System32\imageres.dll";

        private readonly int ICON_OK;
        private readonly int ICON_WARNING;
        private readonly int ICON_ERROR;

        public MainWindow()
        {
            InitializeComponent();

            // Windows10、Windows11のどちらかを判定し、OSに合うインデックス番号を参照する
            ManagementClass mc = new("Win32_OperatingSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject managementObject in moc)
            {
                if (managementObject["Version"].ToString().Substring(0, 2) == "10")
                {
                    if (int.Parse(managementObject["BuildNumber"].ToString()) >= 22000)
                    {
                        ICON_OK = 233;
                        ICON_WARNING = 231;
                        ICON_ERROR = 230;
                    }
                    else
                    {
                        ICON_OK = 232;
                        ICON_WARNING = 230;
                        ICON_ERROR = 229;
                    }
                }
                else
                {
                    MessageBox.Show("このOSはサポートされていないため、アプリケーションが正しく動作しない可能性があります。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            CheckStatus();
        }

        private void ShowPHP_Click(object sender, EventArgs e)
        {
            PHP php = new()
            {
                Owner = this
            };
            php.ShowDialog();
            CheckStatus();
        }

        private void ShowKeyConfig_Click(object sender, EventArgs e)
        {
            KeyConfigWindow keyConfigWindow = new()
            {
                Owner = this
            };
            keyConfigWindow.ShowDialog();
            CheckStatus();
        }

        private void ServerIO_Click(object sender, EventArgs e)
        {
            ShowQRCode showQRCode = new()
            {
                Owner = this
            };
            showQRCode.ShowDialog();
        }

        /// <summary>
        /// ステータスを確認する関数を呼び出し、結果に応じてボタンの横にアイコンを表示します
        /// </summary>
        private void CheckStatus()
        {
            int PHPStatusIcon = CheckPHPStatus() switch
            {
                0 => ICON_OK,
                1 => ICON_WARNING,
                -1 => ICON_ERROR,
                _ => ICON_ERROR
            };
            int KeyConfigStatusIcon = CheckKeyConfigStatus() switch
            {
                0 => ICON_OK,
                -1 => ICON_ERROR,
                _ => ICON_ERROR
            };
            PHPStatus.Image = GetIcon.GetBitmapFromEXEDLL(IMAGERESDLL, PHPStatusIcon, true);
            KeyConfigStatus.Image = GetIcon.GetBitmapFromEXEDLL(IMAGERESDLL, KeyConfigStatusIcon, true);
        }

        /// <summary>
        /// PHPのインストール状況とドキュメントルートのファイルを確認します
        /// </summary>
        /// <returns>ドキュメントルートは正しく設定されているが、PHPを使用しない設定の場合(1)、すべて正しく設定されている場合(0)、それ以外(-1)</returns>
        private static int CheckPHPStatus()
        {
            int statusNum = 0;

            // PHPを使用する設定の場合はPHPの実行ファイルを確認する
            if (Properties.Settings.Default.WebServerSoftware == "PHP")
            {
                if (!File.Exists(Properties.Settings.Default.PHPExeFilePath)) { return -1; }
                ProcessStartInfo processStartInfo = new(Properties.Settings.Default.PHPExeFilePath)
                {
                    Arguments = "--version",
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                try
                {
                    using Process process = Process.Start(processStartInfo);
                    process.WaitForExit(1000);
                    if (process.ExitCode != 0) { return -1; }
                }
                catch
                {
                    return -1;
                }
            }
            else
            {
                statusNum = 1;
            }

            // ドキュメントルートのファイルチェック
            string indexPath = Path.Combine(Properties.Settings.Default.DocumentRoot, "index.php");
            if (!File.Exists(indexPath)) { return -1; }
            
            return statusNum;
        }

        /// <summary>
        /// キーコンフィグが正しく設定されているかを確認します
        /// </summary>
        /// <returns>正しく設定されている場合(0)、それ以外(-1)</returns>
        private static int CheckKeyConfigStatus()
        {
            string csvPath = Path.Combine(Properties.Settings.Default.DocumentRoot, "ButtonProperty.csv");
            if (!File.Exists(csvPath)) { return -1; }

            return 0;
        }

        private void ShowVersionInfo_Click(object sender, EventArgs e)
        {
            VersionInfo versionInfo = new()
            {
                Owner = this
            };
            versionInfo.ShowDialog();
            CheckStatus();
        }
    }
}
