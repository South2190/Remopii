using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using RC_of_Computer.Classes;
using System.Text;

namespace RC_of_Computer
{
    public partial class KeyConfigWindow : Form
    {
        private Button buttonCount = null;
        private int duration = 0;

        private List<string> keys;
        private int keycount = 0;
        private string key;
        private string xmlFiles;

        private List<string[]> buttonCSV = new()
        {
            new string[3] { "", "", "" },
            new string[3] { "", "", "" },
            new string[3] { "", "False", "" },
            new string[3] { "", "False", "" },
            new string[3] { "", "False", "" },
            new string[3] { "", "False", "" },
            new string[3] { "", "False", "" },
            new string[3] { "", "False", "" },
            new string[3] { "", "False", "" },
            new string[3] { "", "False", "" },
            new string[3] { "", "False", "" }
        };

        private static readonly string csvFileFullPath = Path.Combine(Properties.Settings.Default.DocumentRoot, Program.csvFileName);

        public KeyConfigWindow()
        {
            InitializeComponent();
            LoadSettingsFromCSV(csvFileFullPath);
            this.ContextMenuStrip = this.contextMenuStrip1;
        }

        /// <summary>
        /// すべての"変更"ボタンから呼び出されるイベント
        /// </summary>
        private void KeyChange_Click(object sender, EventArgs e)
        {
            bool timerStartFlag = buttonCount != (Button)sender;
            keycount = 0;
            key = null;
            keys = new();

            if (null != buttonCount)
            {
                TimerStop();
            }
            if (timerStartFlag)
            {
                buttonCount = (Button)sender;
                duration = 10;
                keyScan.Start();
                buttonCount.Text = "変更...10";
                ChangeKeyText(buttonCount.Name, string.Empty);
            }
        }

        /// <summary>
        /// タイマーのカウントを進行させ、0になったらストップします
        /// </summary>
        private void keyScan_Tick(object sender, EventArgs e)
        {
            duration--;
            buttonCount.Text = $"変更...{duration}";
            if (duration <= 0)
            {
                TimerStop();
            }
        }

        /// <summary>
        /// タイマーをストップし、ボタンを元の状態に戻します
        /// </summary>
        private void TimerStop()
        {
            keyScan.Stop();
            duration = 0;
            buttonCount.Text = "変更";
            buttonCount = null;
        }

        /// <summary>
        /// 最適なテキストボックスにテキストを代入します
        /// </summary>
        /// <param name="ButtonName">"変更"ボタンの名前</param>
        /// <param name="Text">代入したいテキスト</param>
        private void ChangeKeyText(string ButtonName, string Text)
        {
            switch (ButtonName)
            {
                case "mainKeyChange1":
                    mainKey1.Text = Text;
                    break;
                case "mainKeyChange2":
                    mainKey2.Text = Text;
                    break;
                case "subKeyChange1":
                    subKey1.Text = Text;
                    break;
                case "subKeyChange2":
                    subKey2.Text = Text;
                    break;
                case "subKeyChange3":
                    subKey3.Text = Text;
                    break;
                case "subKeyChange4":
                    subKey4.Text = Text;
                    break;
                case "subKeyChange5":
                    subKey5.Text = Text;
                    break;
                case "subKeyChange6":
                    subKey6.Text = Text;
                    break;
                case "subKeyChange7":
                    subKey7.Text = Text;
                    break;
                case "subKeyChange8":
                    subKey8.Text = Text;
                    break;
                case "subKeyChange9":
                    subKey9.Text = Text;
                    break;
            }
        }

        /// <summary>
        /// キーの入力を検出します
        /// </summary>
        private void KeyChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (buttonCount != null)
            {
                string keycode = ConvertToSendkeys(e.KeyCode);
                if (keys.Contains(keycode + "("))
                {
                    ChangeKeyText(buttonCount.Name, "同じやつ");
                    TimerStop();
                }
                else
                {
                    keys.Add(keycode);
                    if (keys[keycount] == "+" || keys[keycount] == "^" || keys[keycount] == "%")
                    {
                        keys[keycount] += "(";
                        key += keys[keycount];
                        keycount += 1;
                        ChangeKeyText(buttonCount.Name, key);

                    }
                    else
                    {
                        if (keycount > 0)
                        {
                            key += keys[keycount];
                            for (int i = 1; i <= keycount; i++)
                            {
                                key += ")";
                            }
                            ChangeKeyText(buttonCount.Name, key);
                            TimerStop();
                        }
                        else
                        {
                            ChangeKeyText(buttonCount.Name, keys[0]);
                            TimerStop();
                        }
                    }
                }
                //Debug.WriteLine(e.KeyCode);
                //e.Control, e.Shift, e.Alt
                e.Handled = true;
            }
        }

        /// <summary>
        /// 特殊なキーの入力を無効化します
        /// </summary>
        private void KeyChange_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (buttonCount != null)
            {
                e.IsInputKey = true;
            }
        }

        /// <summary>
        /// Keys型をSendKeys形式に変換します
        /// </summary>
        /// <param name="key">変換前のKeys型</param>
        /// <returns>変換結果</returns>
        private string ConvertToSendkeys(Keys key)
        {
            switch (key)
            {
                case Keys.ShiftKey:
                    return "+";
                case Keys.ControlKey:
                    return "^";
                case Keys.Menu:
                    return "%";
                case Keys.F1:
                    return "{F1}";
                case Keys.F2:
                    return "{F2}";
                case Keys.F3:
                    return "{F3}";
                case Keys.F4:
                    return "{F4}";
                case Keys.F5:
                    return "{F5}";
                case Keys.F6:
                    return "{F6}";
                case Keys.F7:
                    return "{F7}";
                case Keys.F8:
                    return "{F8}";
                case Keys.F9:
                    return "{F9}";
                case Keys.F10:
                    return "{F10}";
                case Keys.F11:
                    return "{F11}";
                case Keys.F12:
                    return "{F12}";
                case Keys.F13:
                    return "{F13}";
                case Keys.F14:
                    return "{F14}";
                case Keys.F15:
                    return "{F15}";
                case Keys.F16:
                    return "{F16}";
                case Keys.D0:
                case Keys.NumPad0:
                    return "0";
                case Keys.D1:
                case Keys.NumPad1:
                    return "1";
                case Keys.D2:
                case Keys.NumPad2:
                    return "2";
                case Keys.D3:
                case Keys.NumPad3:
                    return "3";
                case Keys.D4:
                case Keys.NumPad4:
                    return "4";
                case Keys.D5:
                case Keys.NumPad5:
                    return "5";
                case Keys.D6:
                case Keys.NumPad6:
                    return "6";
                case Keys.D7:
                case Keys.NumPad7:
                    return "7";
                case Keys.D8:
                case Keys.NumPad8:
                    return "8";
                case Keys.D9:
                case Keys.NumPad9:
                    return "9";
                case Keys.Up:
                    return "{UP}";
                case Keys.Down:
                    return "{DOWN}";
                case Keys.Left:
                    return "{LEFT}";
                case Keys.Right:
                    return "{RIGHT}";
                case Keys.Back:
                    return "{BACKSPACE}";
                case Keys.Cancel:
                    return "{BREAK}";
                case Keys.CapsLock:
                    return "{CAPSLOCK}";
                case Keys.Delete:
                    return "{DELETE}";
                case Keys.End:
                    return "{END}";
                case Keys.Enter:
                    return "{ENTER}";
                case Keys.Escape:
                    return "{ESC}";
                case Keys.Help:
                    return "{HELP}";
                case Keys.Home:
                    return "{HOME}";
                case Keys.Insert:
                    return "{INSERT}";
                case Keys.NumLock:
                    return "{NUMLOCK}";
                case Keys.PageDown:
                    return "{PGDN}";
                case Keys.PageUp:
                    return "{PGUP}";
                case Keys.PrintScreen:
                    // 検出不可
                    return "{PRTSC}";
                case Keys.Scroll:
                    return "{SCROLLLOCK}";
                case Keys.Tab:
                    return "{TAB}";
                default:
                    return key.ToString();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            SaveSettingsToCSV();
            Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            SaveSettingsToCSV();
        }

        private void SaveSettingsToCSV()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string localAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RC_of_Computer");
            string seigyoExeFilePath = Path.Combine(currentDirectory, "seigyo.exe");
            int x = 0;
            Encoding enc = Encoding.GetEncoding("shift_jis");

            List<ProcessStartInfo> pInfo = new();
            List<string> xmlFilesPath = new();
            List<string> buttonnamelist = new();

            string path = Path.Combine(localAppDataPath,"xml");
            Directory.CreateDirectory(path);

            // panel内のグループボックス全取得
            foreach (Control groupbox in panelRemocon.Controls)
            {
                // グループボックス内のチェックボックス全取得
                foreach (CheckBox control in groupbox.Controls.OfType<CheckBox>())
                {
                    buttonCSV[int.Parse(control.Name.Substring(9)) + 1][1] = control.Checked.ToString();
                }
                // グループボックス内のテキストボックス全取得
                foreach (TextBox control in groupbox.Controls.OfType<TextBox>())
                {
                    if (Regex.IsMatch(control.Name, @"^mainValue"))
                    {
                        buttonCSV[int.Parse(control.Name.Substring(9)) - 1][0] = control.Text;
                    }
                    else if (Regex.IsMatch(control.Name, @"^subValue"))
                    {
                        buttonCSV[int.Parse(control.Name.Substring(8)) + 1][0] = control.Text;
                    }
                    else if (Regex.IsMatch(control.Name, @"^mainKey"))
                    {
                        buttonCSV[int.Parse(control.Name.Substring(7)) - 1][2] = control.Text;
                        if (control.Text != string.Empty)
                        {
                            string buttonname = "MainButton" + control.Name.Substring(7);
                            xmlFiles = $"<?xml version=\"1.0\" encoding=\"UTF-16\"?>\r\n<Task version=\"1.2\" xmlns=\"http://schemas.microsoft.com/windows/2004/02/mit/task\">\r\n  <RegistrationInfo>\r\n    <URI>\\RC_of_Computer\\{buttonname}</URI>\r\n  </RegistrationInfo>\r\n  <Triggers>\r\n    <TimeTrigger>\r\n      <StartBoundary>1999-01-01T10:00:00</StartBoundary>\r\n      <Enabled>true</Enabled>\r\n    </TimeTrigger>\r\n  </Triggers>\r\n  <Principals>\r\n    <Principal>\r\n      <LogonType>InteractiveToken</LogonType>\r\n      <RunLevel>LeastPrivilege</RunLevel>\r\n    </Principal>\r\n  </Principals>\r\n  <Settings>\r\n    <MultipleInstancesPolicy>IgnoreNew</MultipleInstancesPolicy>\r\n    <DisallowStartIfOnBatteries>false</DisallowStartIfOnBatteries>\r\n    <StopIfGoingOnBatteries>false</StopIfGoingOnBatteries>\r\n    <AllowHardTerminate>true</AllowHardTerminate>\r\n    <StartWhenAvailable>false</StartWhenAvailable>\r\n    <RunOnlyIfNetworkAvailable>false</RunOnlyIfNetworkAvailable>\r\n    <IdleSettings>\r\n      <StopOnIdleEnd>true</StopOnIdleEnd>\r\n      <RestartOnIdle>false</RestartOnIdle>\r\n    </IdleSettings>\r\n    <AllowStartOnDemand>true</AllowStartOnDemand>\r\n    <Enabled>true</Enabled>\r\n    <Hidden>false</Hidden>\r\n    <RunOnlyIfIdle>false</RunOnlyIfIdle>\r\n    <WakeToRun>false</WakeToRun>\r\n    <ExecutionTimeLimit>PT72H</ExecutionTimeLimit>\r\n    <Priority>7</Priority>\r\n  </Settings>\r\n  <Actions>\r\n    <Exec>\r\n      <Command>{seigyoExeFilePath}</Command>\r\n      <Arguments>-k {control.Text}</Arguments>\r\n    </Exec>\r\n  </Actions>\r\n</Task>";
                            File.WriteAllText($"{path}\\TaskScheduler{buttonname}.xml", xmlFiles, enc);
                            xmlFilesPath.Add($"{path}\\TaskScheduler{buttonname}");
                            buttonnamelist.Add(buttonname);
                        }
                    }
                    else if (Regex.IsMatch(control.Name, @"^subKey"))
                    {
                        buttonCSV[int.Parse(control.Name.Substring(6)) + 1][2] = control.Text;
                        if (control.Text != string.Empty)
                        {
                            string buttonname = "SubButton" + control.Name.Substring(6);
                            xmlFiles = $"<?xml version=\"1.0\" encoding=\"UTF-16\"?>\r\n<Task version=\"1.2\" xmlns=\"http://schemas.microsoft.com/windows/2004/02/mit/task\">\r\n  <RegistrationInfo>\r\n    <URI>\\RC_of_Computer\\{buttonname}</URI>\r\n  </RegistrationInfo>\r\n  <Triggers>\r\n    <TimeTrigger>\r\n      <StartBoundary>1999-01-01T10:00:00</StartBoundary>\r\n      <Enabled>true</Enabled>\r\n    </TimeTrigger>\r\n  </Triggers>\r\n  <Principals>\r\n    <Principal>\r\n      <LogonType>InteractiveToken</LogonType>\r\n      <RunLevel>LeastPrivilege</RunLevel>\r\n    </Principal>\r\n  </Principals>\r\n  <Settings>\r\n    <MultipleInstancesPolicy>IgnoreNew</MultipleInstancesPolicy>\r\n    <DisallowStartIfOnBatteries>false</DisallowStartIfOnBatteries>\r\n    <StopIfGoingOnBatteries>false</StopIfGoingOnBatteries>\r\n    <AllowHardTerminate>true</AllowHardTerminate>\r\n    <StartWhenAvailable>false</StartWhenAvailable>\r\n    <RunOnlyIfNetworkAvailable>false</RunOnlyIfNetworkAvailable>\r\n    <IdleSettings>\r\n      <StopOnIdleEnd>true</StopOnIdleEnd>\r\n      <RestartOnIdle>false</RestartOnIdle>\r\n    </IdleSettings>\r\n    <AllowStartOnDemand>true</AllowStartOnDemand>\r\n    <Enabled>true</Enabled>\r\n    <Hidden>false</Hidden>\r\n    <RunOnlyIfIdle>false</RunOnlyIfIdle>\r\n    <WakeToRun>false</WakeToRun>\r\n    <ExecutionTimeLimit>PT72H</ExecutionTimeLimit>\r\n    <Priority>7</Priority>\r\n  </Settings>\r\n  <Actions>\r\n    <Exec>\r\n      <Command>{seigyoExeFilePath}</Command>\r\n      <Arguments>-k {control.Text}</Arguments>\r\n    </Exec>\r\n  </Actions>\r\n</Task>";
                            File.WriteAllText($"{path}\\TaskScheduler{buttonname}.xml", xmlFiles, enc);
                            xmlFilesPath.Add($"{path}\\TaskScheduler{buttonname}");
                            buttonnamelist.Add(buttonname);
                        }
                    }
                }
            }
            CSVIO.WriteCSV(csvFileFullPath, buttonCSV);
            foreach (string i in xmlFilesPath)
            {
                pInfo.Add(new ProcessStartInfo("schtasks")
                {
                    Arguments = $"/create /XML {i}.xml /TN RC_of_Computer\\{buttonnamelist[x]} /F",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
                x ++;
            }
            bool exitCode = true;
            foreach (ProcessStartInfo pInfoItem in pInfo)
            {
                using Process p = Process.Start(pInfoItem);
                p.WaitForExit(1000);
                if (p.ExitCode != 0) { exitCode = false; }
            }
            if (!exitCode)
            {
                MessageBox.Show("タスクスケジューラへの登録に失敗しました", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSettingsFromCSV(string path)
        {
            CSVIO.LoadCSV(path, ref buttonCSV);

            // panel内のグループボックス全取得
            foreach (Control groupbox in panelRemocon.Controls)
            {
                // グループボックス内のチェックボックス全取得
                foreach (CheckBox control in groupbox.Controls.OfType<CheckBox>())
                {
                    control.Checked = Convert.ToBoolean(buttonCSV[int.Parse(control.Name.Substring(9)) + 1][1]);
                }
                // グループボックス内のテキストボックス全取得
                foreach (TextBox control in groupbox.Controls.OfType<TextBox>())
                {
                    if (Regex.IsMatch(control.Name, @"^mainValue"))
                    {
                        control.Text = buttonCSV[int.Parse(control.Name.Substring(9)) - 1][0];
                    }
                    else if (Regex.IsMatch(control.Name, @"^subValue"))
                    {
                        control.Text = buttonCSV[int.Parse(control.Name.Substring(8)) + 1][0];
                    }
                    else if (Regex.IsMatch(control.Name, @"^mainKey"))
                    {
                        control.Text = buttonCSV[int.Parse(control.Name.Substring(7)) - 1][2];
                    }
                    else if (Regex.IsMatch(control.Name, @"^subKey"))
                    {
                        control.Text = buttonCSV[int.Parse(control.Name.Substring(6)) + 1][2];
                    }
                }
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new()
            {
                Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string importFileFullPath = openFileDialog.FileName;
                LoadSettingsFromCSV(importFileFullPath);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {

        }
    }
}
