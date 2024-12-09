using System;
using System.Reflection;
using System.Windows.Forms;

namespace RC_of_Computer
{
    public partial class VersionInfo : Form
    {
        public VersionInfo()
        {
            InitializeComponent();
            VersionInformation.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
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