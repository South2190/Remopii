using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RC_of_Computer
{
    public partial class KeyConfigWindow : Form
    {
        private Button buttonCount = null;
        private int duration = 10;

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
                keyScan.Start();
                buttonCount.Text = "変更...10";
                ChangeKeyText(buttonCount.Name, "+^({ESC})");
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
            duration = 10;
            buttonCount.Text = "変更";
            buttonCount = null;
        }

        /// <summary>
        /// ボタンの名前に応じて最適なテキストボックスにテキストを代入します
        /// </summary>
        /// <param name="ButtonName">変更ボタンの(Name)</param>
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
    }
}
