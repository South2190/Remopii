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
        public MainWindow()
        {
            InitializeComponent();

            const string IMAGERESDLL = @"C:\Windows\System32\imageres.dll";
            Bitmap test = GetIcon.GetBitmapFromEXEDLL(IMAGERESDLL, 229, true);
            PHPStatus.Image = test;
            KeyConfigStatus.Image = test;
            Debug.WriteLine(test.PhysicalDimension.ToString());
            ManagementClass mc = new("Win32_OperatingSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject m in moc)
            {
                Debug.WriteLine($"Name:{m["Name"]}");
                Debug.WriteLine($"Version:{m["Version"]}");
                Debug.WriteLine($"BuildNumber:{m["BuildNumber"]}");
                //MessageBox.Show($"Name:{m["Name"]}\nVersion:{m["Version"]}\nBuildNumber:{m["BuildNumber"]}", "WMIからのバージョン情報取得テスト");
            }
        }

        private void ShowPHP_Click(object sender, EventArgs e)
        {
            PHP php = new()
            {
                Owner = this
            };
            php.ShowDialog();
        }

        private void ShowKeyConfig_Click(object sender, EventArgs e)
        {
            KeyConfigWindow keyConfigWindow = new()
            {
                Owner = this
            };
            keyConfigWindow.ShowDialog();
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
                    Arguments = "--version"
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
        private static int GetKeyConfigStatus()
        {
            string csvPath = Path.Combine(Properties.Settings.Default.DocumentRoot, "ButtonProperty.csv");
            if (!File.Exists(csvPath)) { return -1; }

            return 0;
        }
    }
}
