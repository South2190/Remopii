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
        }

        /// <summary>
        /// すべての"Hidden"チェックボックスのチェック状態が変わった際に呼び出されるイベント
        /// </summary>
        private void Hidden_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Debug.WriteLine(checkBox.Name + ": " + checkBox.Checked);
        }
    }
}
