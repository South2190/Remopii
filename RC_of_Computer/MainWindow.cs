using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using RC_of_Computer.Classes;
using RC_of_Computer.FunctionSetup;

namespace RC_of_Computer
{
    public partial class MainWindow : Form
    {
        private readonly Bitmap IconOk;
        private readonly Bitmap IconWarning;
        private readonly Bitmap IconError;

        private string phpPath;

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public MainWindow()
        {
            InitializeComponent();

            AppVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            processMonitoring_Tick();
            // php.exeが動いているかを毎秒確認し、ボタンを切り替える
            processMonitoring.Tick += (s, e) => processMonitoring_Tick();
            processMonitoring.Start();

            // Windows10、Windows11のどちらかを判定し、OSに合ったインデックス番号を格納する
            const string IMAGERESDLL = @"C:\Windows\System32\imageres.dll";

            int indexOk = 0;
            int indexWarning = 0;
            int indexError = 0;

            ManagementClass mc = new("Win32_OperatingSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject managementObject in moc)
            {
                if (managementObject["Version"].ToString().Substring(0, 2) == "10")
                {
                    // Windows11
                    if (int.Parse(managementObject["BuildNumber"].ToString()) >= 22000)
                    {
                        indexOk = 233;
                        indexWarning = 231;
                        indexError = 230;
                    }
                    // Windows10
                    else
                    {
                        indexOk = 232;
                        indexWarning = 230;
                        indexError = 229;
                    }
                }
                // その他のOS
                else
                {
                    MessageBox.Show("このOSはサポートされていないため、アプリケーションが正しく動作しない可能性があります。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // それぞれの変数にアイコンを格納
            IconOk = GetIcon.GetBitmapFromEXEDLL(IMAGERESDLL, indexOk, true);
            IconWarning = GetIcon.GetBitmapFromEXEDLL(IMAGERESDLL, indexWarning, true);
            IconError = GetIcon.GetBitmapFromEXEDLL(IMAGERESDLL, indexError, true);

            CheckStatus();
        }

        /// <summary>
        /// php.exeの動作状況に応じてスタート/ストップボタンの表示を切り替えます
        /// </summary>
        private void processMonitoring_Tick()
        {
            Process[] p = Process.GetProcessesByName("php");
            // php.exeが動いていない場合
            if (p.Length <= 0)
            {
                ServerIO.Text = "スタート";
                ShowQRWindow.Enabled = false;
            }
            // php.exeが動いている場合
            else
            {
                ServerIO.Text = "ストップ";
                ShowQRWindow.Enabled = true;
            }
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

        private void ShowVersionInfo_Click(object sender, EventArgs e)
        {
            VersionInfo versionInfo = new()
            {
                Owner = this
            };
            versionInfo.ShowDialog();
        }

        private void ServerIO_Click(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("php");
            // php.exeが動いていない場合起動
            if (p.Length <= 0)
            {
                ProcessStartInfo pInfo = new(phpPath)
                {
                    Arguments = $"-S {Properties.Settings.Default.IPAddress}:{Properties.Settings.Default.PortNumber} -t {Properties.Settings.Default.DocumentRoot}",
                    WindowStyle = ProcessWindowStyle.Minimized
                };
                Process.Start(pInfo);
                ShowQRCode showQRCode = new()
                {
                    Owner = this
                };
                showQRCode.ShowDialog();
            }
            // php.exeが動いている場合終了
            else
            {
                foreach (Process pKill in p)
                {
                    // php.exeをアクティブにし、Ctrl+Cを送信
                    SetForegroundWindow(pKill.MainWindowHandle);
                    SendKeys.SendWait("^(C)");
                }
            }
        }

        /// <summary>
        /// ステータスを確認する関数を呼び出し、結果に応じてボタンの横にアイコンを表示します
        /// ステータスに応じてスタート・ストップボタンのEnabledを制御します
        /// </summary>
        private void CheckStatus()
        {
            int PHPStatusResult = CheckPHPStatus();
            int KeyConfigStatusResult = CheckKeyConfigStatus();
            PHPStatus.Image = PHPStatusResult switch
            {
                0 => IconOk,
                1 => IconWarning,
                -1 => IconError,
                _ => IconError
            };
            KeyConfigStatus.Image = KeyConfigStatusResult switch
            {
                0 => IconOk,
                -1 => IconError,
                _ => IconError
            };
            //ステータスが両方ともOKでない場合はボタンを無効化
            ServerIO.Enabled = PHPStatusResult == 0 && KeyConfigStatusResult == 0;
        }

        /// <summary>
        /// PHPのインストール状況とドキュメントルートのファイルを確認します
        /// </summary>
        /// <returns>ドキュメントルートは正しく設定されているが、PHPを使用しない設定の場合(1)、すべて正しく設定されている場合(0)、それ以外(-1)</returns>
        private int CheckPHPStatus()
        {
            int statusNum = 0;

            // PHPを使用する設定の場合はPHPの実行ファイルを確認する
            if (Properties.Settings.Default.WebServerSoftware == "PHP")
            {
                phpPath = Properties.Settings.Default.UsePATHValue ? "php" : Properties.Settings.Default.PHPExeFilePath;
                ProcessStartInfo processStartInfo = new(phpPath)
                {
                    Arguments = "--version",
                    UseShellExecute = false,
                    CreateNoWindow = true
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
            string indexPath = Path.Combine(Properties.Settings.Default.DocumentRoot, Program.phpFileName);
            if (!File.Exists(indexPath)) { return -1; }
            
            return statusNum;
        }

        /// <summary>
        /// キーコンフィグが正しく設定されているかを確認します
        /// </summary>
        /// <returns>正しく設定されている場合(0)、それ以外(-1)</returns>
        private int CheckKeyConfigStatus()
        {
            ShowKeyConfig.Enabled = Directory.Exists(Properties.Settings.Default.DocumentRoot);
            string csvPath = Path.Combine(Properties.Settings.Default.DocumentRoot, Program.csvFileName);
            if (!File.Exists(csvPath)) { return -1; }

            return 0;
        }

        private void ShowQRWindow_Click(object sender, EventArgs e)
        {
            ShowQRCode showQRCode = new()
            {
                Owner = this
            };
            showQRCode.ShowDialog();
        }
    }
}
