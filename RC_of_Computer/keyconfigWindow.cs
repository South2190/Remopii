using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace RC_of_Computer
{
    public partial class KeyConfigWindow : Form
    {
        private Button buttonCount = null;
        private int duration = 0;

        public KeyConfigWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// すべての"変更"ボタンから呼び出されるイベント
        /// </summary>
        private void KeyChange_Click(object sender, EventArgs e)
        {
            bool timerStartFlag = buttonCount != (Button)sender;

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
                ChangeKeyText(buttonCount.Name, "");
            }
        }
        /// <summary>
        /// すべての"Hidden"チェックボックスのチェック状態が変わった際に呼び出されるイベント
        /// </summary>
        private void Hidden_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Debug.WriteLine(checkBox.Name + ": " + checkBox.Checked);
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
                Debug.WriteLine(e.KeyCode);
                ChangeKeyText(buttonCount.Name, ConvertToSendkeys(e.KeyCode));
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
    }
}
