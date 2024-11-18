using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RC_of_Computer
{
    public partial class keyconfigWindow : Form
    {
        public keyconfigWindow()
        {
            InitializeComponent();
        }

        private void keyChange_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Debug.WriteLine(button.Name);
        }
    }
}
