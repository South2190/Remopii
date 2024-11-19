using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RC_of_Computer
{
    public partial class KeyConfigWindow : Form
    {
        public KeyConfigWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// すべての"変更"ボタンから呼び出されるイベント
        /// </summary>
        private void KeyChange_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Debug.WriteLine(button.Name);
            ChangeKeyText(button.Name, "a");
        }

        /// <summary>
        /// すべての"Hidden"チェックボックスのチェック状態が変わった際に呼び出されるイベント
        /// </summary>
        private void Hidden_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Debug.WriteLine(checkBox.Name + ": " + checkBox.Checked);
        }

        private void ChangeKeyText(string ButtonName, string Text)
        {
            switch (ButtonName)
            {
                case "mainKeyChange1":
                    mainKey1.Text = Text;
                    break;
                case "mainKeyChange2":
                    mainKey2.Text= Text;
                    break;
                case "subKeyChange1":
                    subKey1.Text= Text;
                    break;
                case "subKeyChange2":
                    subKey2.Text= Text;
                    break;
                case "subKeyChange3":
                    subKey3.Text= Text;
                    break;
                case "subKeyChange4":
                    subKey4.Text= Text;
                    break;
                case "subKeyChange5":
                    subKey5.Text= Text;
                    break;
                case "subKeyChange6":
                    subKey6.Text= Text;
                    break;
                case "subKeyChange7":
                    subKey7.Text= Text;
                    break;
                case "subKeyChange8":
                    subKey8.Text= Text;
                    break;
                case "subKeyChange9":
                    subKey9.Text= Text;
                    break;
            }
        }
    }
}
