using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Remopii.FunctionSetup
{
    public partial class ProcessSearch : Form
    {
        public string SelectProcessName { get; set; }

        private readonly List<string> pNames = new();

        public ProcessSearch(int Theme)
        {
            InitializeComponent();

            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowTitle.Length >= 1)
                {
                    pNames.Add(p.ProcessName);
                    string i = $"{p.MainWindowTitle} ({p.ProcessName}.exe)";
                    appListComboBox.Items.Add(i);
                }
            }
            appListComboBox.SelectedIndex = 0;

            ChangeTheme(Theme);
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// ウインドウのテーマを設定します
        /// </summary>
        /// <param name="themeNumber">設定したいテーマの番号</param>
        private void ChangeTheme(int themeNumber)
        {
            switch (themeNumber)
            {
                // ダーク
                case 0:
                    BackColor = Color.FromArgb(32, 32, 32);
                    ForeColor = Color.FromArgb(255, 255, 255);
                    appListComboBox.BackColor = Color.FromArgb(56, 56, 56);
                    appListComboBox.ForeColor = Color.FromArgb(255, 255, 255);
                    okButton.BackColor = Color.FromArgb(56, 56, 56);
                    break;
                // デフォルト
                case 1:
                default:
                    return;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SelectProcessName = pNames[appListComboBox.SelectedIndex];
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
