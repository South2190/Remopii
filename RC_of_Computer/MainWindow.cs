using RC_of_Computer.Classes;
using RC_of_Computer.FunctionSetup;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Net;
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
        }

        private void ShowPHP_Click(object sender, System.EventArgs e)
        {
            PHP php = new()
            {
                Owner = this
            };
            php.ShowDialog();
        }

        private void ShowKeyConfig_Click(object sender, System.EventArgs e)
        {
            KeyConfigWindow keyConfigWindow = new()
            {
                Owner = this
            };
            keyConfigWindow.ShowDialog();
        }

        private void ServerIO_Click(object sender, System.EventArgs e)
        {
            ShowQRCode showQRCode = new()
            {
                Owner = this
            };
            showQRCode.ShowDialog();
            /*string hostname = Dns.GetHostName();
            IPAddress[] adrList = Dns.GetHostAddresses(hostname);
            string url = (Properties.Settings.Default.PortNumber == 80) ? $"http://{adrList[1].ToString()}" : $"http://{adrList[1].ToString()}:{Properties.Settings.Default.PortNumber.ToString()}";
            MessageBox.Show(url);*/
        }

        /// <summary>
        /// PHPのインストール状況とドキュメントルートのファイルを確認します
        /// </summary>
        /// <returns>ドキュメントルートは正しく設定されているが、PHPを使用しない設定の場合(1)、すべて正しく設定されている場合(0)、それ以外(-1)</returns>
        private static int CheckPHPStatus()
        {
            int statusNum = 0;

            // PHPのインストール状況の確認
            if (Properties.Settings.Default.WebServerSoftware != "PHP") { statusNum = 1; }
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
