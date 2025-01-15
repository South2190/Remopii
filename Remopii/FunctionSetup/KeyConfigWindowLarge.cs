using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Remopii.Classes;

namespace Remopii
{
    public partial class KeyConfigWindowLarge : Form
    {
        private Button buttonCount = null;
        private int duration = 0;

        private List<string> keys;
        private int keycount = 0;
        private string key;

        private static readonly string csvFileFullPath = Path.Combine(Properties.Settings.Default.DocumentRoot, Program.csvFileName);

        public KeyConfigWindowLarge(int Theme)
        {
            InitializeComponent();
            LoadSettingsFromCSV(csvFileFullPath);
            ChangeTheme(Theme);
        }

        /// <summary>
        /// ウインドウのテーマを設定します
        /// </summary>
        /// <param name="themeNumber">設定したいテーマの番号</param>
        private void ChangeTheme(int themeNumber)
        {
            Color foreCol;
            Color backCol;
            Color winCol;
            Color btnCol;

            switch (themeNumber)
            {
                // ダーク
                case 0:
                    foreCol = Color.FromArgb(255, 255, 255);
                    backCol = Color.FromArgb(0, 0, 0);
                    winCol = Color.FromArgb(56, 56, 56);
                    btnCol = Color.FromArgb(56, 56, 56);
                    buttonOk.BackColor = Color.FromArgb(56, 56, 56);
                    buttonCancel.BackColor = Color.FromArgb(56, 56, 56);
                    buttonApply.BackColor = Color.FromArgb(56, 56, 56);
                    break;
                // デフォルト
                case 1:
                default:
                    return;
            }

            ForeColor = foreCol;
            BackColor = backCol;

            // panel内のグループボックス全取得
            foreach (Control groupbox in panelRemocon.Controls)
            {
                groupbox.ForeColor = foreCol;

                // グループボックス内のテキストボックス全取得
                foreach (TextBox control in groupbox.Controls.OfType<TextBox>())
                {
                    if (Regex.IsMatch(control.Name, @"^(?:main|sub)Key"))
                    {
                        control.BackColor = backCol;
                        control.ForeColor = foreCol;
                    }
                    else
                    {
                        control.BackColor = winCol;
                        control.ForeColor = foreCol;
                    }
                }
                // グループボックス内のボタン全取得
                foreach (Button control in groupbox.Controls.OfType<Button>())
                {
                    control.BackColor = btnCol;
                }
            }
        }

        private void hiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (TextBox control in ((CheckBox)sender).Parent.Controls.OfType<TextBox>())
            {
                control.Enabled = ((CheckBox)sender).Checked;
            }
            foreach (Button control in ((CheckBox)sender).Parent.Controls.OfType<Button>())
            {
                control.Enabled = ((CheckBox)sender).Checked;
            }
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
                buttonCount.Text = "10";
                ChangeKeyText(buttonCount.Name, string.Empty);
            }
        }

        /// <summary>
        /// タイマーのカウントを進行させ、0になったらストップします
        /// </summary>
        private void keyScan_Tick(object sender, EventArgs e)
        {
            if (--duration <= 0)
            {
                TimerStop();
                return;
            }
            buttonCount.Text = duration.ToString();
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
            SaveSettingsToCSV(csvFileFullPath, true);
            Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            SaveSettingsToCSV(csvFileFullPath, true);
        }

        /// <summary>
        /// フォームの内容を読み込んでCSVファイルに保存します
        /// 同時にタスクスケジューラの登録を行います
        /// </summary>
        /// <param name="path">保存先のCSVファイルのパス</param>
        /// <param name="submitSchtasks">タスクスケジューラへの登録を行うか</param>
        private void SaveSettingsToCSV(string path, bool submitSchtasks = false)
        {
            List<string[]> buttonList = new();
            for (int i = 0; i < 11; i++) { buttonList.Add(new string[] { string.Empty, string.Empty, string.Empty, string.Empty }); }

            // panel内のグループボックス全取得
            foreach (Control groupbox in panelRemocon.Controls)
            {
                // グループボックス内のチェックボックス全取得
                foreach (CheckBox control in groupbox.Controls.OfType<CheckBox>())
                {
                    buttonList[int.Parse(control.Name.Substring(9)) + 1][1] = control.Checked.ToString();
                }
                // グループボックス内のテキストボックス全取得
                foreach (TextBox control in groupbox.Controls.OfType<TextBox>())
                {
                    if (Regex.IsMatch(control.Name, @"^mainValue"))
                    {
                        buttonList[int.Parse(control.Name.Substring(9)) - 1][0] = control.Text;
                    }
                    else if (Regex.IsMatch(control.Name, @"^subValue"))
                    {
                        buttonList[int.Parse(control.Name.Substring(8)) + 1][0] = control.Text;
                    }
                    else if (Regex.IsMatch(control.Name, @"^mainKey"))
                    {
                        buttonList[int.Parse(control.Name.Substring(7)) - 1][2] = control.Text;
                    }
                    else if (Regex.IsMatch(control.Name, @"^subKey"))
                    {
                        buttonList[int.Parse(control.Name.Substring(6)) + 1][2] = control.Text;
                    }
                    else if (Regex.IsMatch(control.Name, @"^mainProcess"))
                    {
                        buttonList[int.Parse(control.Name.Substring(11)) - 1][3] = control.Text;
                    }
                    else if (Regex.IsMatch(control.Name, @"^subProcess"))
                    {
                        buttonList[int.Parse(control.Name.Substring(10)) + 1][3] = control.Text;
                    }
                }
            }
            CSVIO.WriteCSV(path, buttonList);
            // タスクスケジューラへの登録
            if (submitSchtasks)
            {
                string localAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Remopii");
                string seigyoExeFilePath = Path.Combine(Directory.GetCurrentDirectory(), "seigyo.exe");

                string xmlPath = Path.Combine(localAppDataPath, "TaskSchedulerXml");
                Directory.CreateDirectory(xmlPath);

                for (int i = 0; i < 11; i++)
                {
                    // 入力するキーの指定がされていないボタンと無効にされているボタンは無視
                    if (buttonList[i][1] == "False") { continue; }
                    string processArg = buttonList[i][3] == string.Empty ? string.Empty : $"-p {buttonList[i][3]} ";
                    string keyArg = buttonList[i][2] == string.Empty ? string.Empty : $"-k \"{buttonList[i][2]}\"";

                    string buttonName = i < 2 ? $"MainButton{i + 1}" : $"SubButton{i - 1}";
                    string xmlFile = $"<?xml version=\"1.0\" encoding=\"UTF-16\"?>\r\n<Task version=\"1.2\" xmlns=\"http://schemas.microsoft.com/windows/2004/02/mit/task\">\r\n  <RegistrationInfo>\r\n    <URI>\\Remopii\\{buttonName}</URI>\r\n  </RegistrationInfo>\r\n  <Triggers>\r\n    <TimeTrigger>\r\n      <StartBoundary>1999-01-01T10:00:00</StartBoundary>\r\n      <Enabled>true</Enabled>\r\n    </TimeTrigger>\r\n  </Triggers>\r\n  <Principals>\r\n    <Principal>\r\n      <LogonType>InteractiveToken</LogonType>\r\n      <RunLevel>LeastPrivilege</RunLevel>\r\n    </Principal>\r\n  </Principals>\r\n  <Settings>\r\n    <MultipleInstancesPolicy>IgnoreNew</MultipleInstancesPolicy>\r\n    <DisallowStartIfOnBatteries>false</DisallowStartIfOnBatteries>\r\n    <StopIfGoingOnBatteries>false</StopIfGoingOnBatteries>\r\n    <AllowHardTerminate>true</AllowHardTerminate>\r\n    <StartWhenAvailable>false</StartWhenAvailable>\r\n    <RunOnlyIfNetworkAvailable>false</RunOnlyIfNetworkAvailable>\r\n    <IdleSettings>\r\n      <StopOnIdleEnd>true</StopOnIdleEnd>\r\n      <RestartOnIdle>false</RestartOnIdle>\r\n    </IdleSettings>\r\n    <AllowStartOnDemand>true</AllowStartOnDemand>\r\n    <Enabled>true</Enabled>\r\n    <Hidden>false</Hidden>\r\n    <RunOnlyIfIdle>false</RunOnlyIfIdle>\r\n    <WakeToRun>false</WakeToRun>\r\n    <ExecutionTimeLimit>PT72H</ExecutionTimeLimit>\r\n    <Priority>7</Priority>\r\n  </Settings>\r\n  <Actions>\r\n    <Exec>\r\n      <Command>{seigyoExeFilePath}</Command>\r\n      <Arguments>{processArg}{keyArg}</Arguments>\r\n    </Exec>\r\n  </Actions>\r\n</Task>";
                    File.WriteAllText($"{xmlPath}\\TaskScheduler{buttonName}.xml", xmlFile, Encoding.GetEncoding("shift_jis"));

                    ProcessStartInfo processStartInfo = new("schtasks")
                    {
                        Arguments = $"/create /XML {xmlPath}\\TaskScheduler{buttonName}.xml /TN Remopii\\{buttonName} /F",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    using Process p = Process.Start(processStartInfo);
                    p.WaitForExit(1000);

                    if (p.ExitCode != 0)
                    {
                        MessageBox.Show("タスクスケジューラへの登録に失敗しました", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// CSVファイルから設定を読み込んでフォームに反映します
        /// </summary>
        /// <param name="path">CSVファイルのパス</param>
        private void LoadSettingsFromCSV(string path)
        {
            List<string[]> buttonList = new()
            {
                new string[] { "←", string.Empty, "{LEFT}", "POWERPNT" },
                new string[] { "→", string.Empty, "{RIGHT}", "POWERPNT" },
                new string[] { "スライド(最初から)", "True", "{F5}", "POWERPNT" },
                new string[] { "スライド(現在から)", "True", "+({F5})", "POWERPNT" },
                new string[] { "スライドの終了", "True", "{ESC}", "POWERPNT" },
                new string[] { "黒い画面", "False", "B", "POWERPNT" },
                new string[] { "白い画面", "False", "W", "POWERPNT" }
            };
            for (int i = 0; i < 4; i++) { buttonList.Add(new string[] { string.Empty, "False", string.Empty, string.Empty }); }

            CSVIO.LoadCSV(path, ref buttonList);

            // panel内のグループボックス全取得
            foreach (Control groupbox in panelRemocon.Controls)
            {
                // グループボックス内のチェックボックス全取得
                foreach (CheckBox control in groupbox.Controls.OfType<CheckBox>())
                {
                    control.Checked = Convert.ToBoolean(buttonList[int.Parse(control.Name.Substring(9)) + 1][1]);
                }
                // グループボックス内のテキストボックス全取得
                foreach (TextBox control in groupbox.Controls.OfType<TextBox>())
                {
                    if (Regex.IsMatch(control.Name, @"^mainValue"))
                    {
                        control.Text = buttonList[int.Parse(control.Name.Substring(9)) - 1][0];
                    }
                    else if (Regex.IsMatch(control.Name, @"^subValue"))
                    {
                        control.Text = buttonList[int.Parse(control.Name.Substring(8)) + 1][0];
                    }
                    else if (Regex.IsMatch(control.Name, @"^mainKey"))
                    {
                        control.Text = buttonList[int.Parse(control.Name.Substring(7)) - 1][2];
                    }
                    else if (Regex.IsMatch(control.Name, @"^subKey"))
                    {
                        control.Text = buttonList[int.Parse(control.Name.Substring(6)) + 1][2];
                    }
                    else if (Regex.IsMatch(control.Name, @"^mainProcess"))
                    {
                        control.Text = buttonList[int.Parse(control.Name.Substring(11)) - 1][3];
                    }
                    else if (Regex.IsMatch(control.Name, @"^subProcess"))
                    {
                        control.Text = buttonList[int.Parse(control.Name.Substring(10)) + 1][3];
                    }
                }
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            if (openCsvFileDialog.ShowDialog() == DialogResult.OK)
            {
                string importFileFullPath = openCsvFileDialog.FileName;
                LoadSettingsFromCSV(importFileFullPath);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            if (saveCsvFileDialog.ShowDialog() == DialogResult.OK)
            {
                string exportFileFullPath = saveCsvFileDialog.FileName;
                SaveSettingsToCSV(exportFileFullPath);
            }
        }
    }
}
