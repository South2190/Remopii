using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace RC_of_Computer
{
    public partial class VersionInfo : Form
    {
        public VersionInfo(int Theme)
        {
            InitializeComponent();
            VersionInformation.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            ChangeTheme(Theme);
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
                    buttonOk.BackColor = Color.FromArgb(56, 56, 56);
                    Github.LinkColor = Color.FromArgb(126, 170, 255);
                    break;
                // デフォルト
                case 1:
                default:
                    return;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //リンク先に移動したことにする
            Github.LinkVisited = true;
            //ブラウザで開く
            System.Diagnostics.Process.Start("https://github.com/South2190/RemoteControlofComputer");
        }
    }
}