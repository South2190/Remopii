using System.Drawing;
using System.Windows.Forms;

using RC_of_Computer.Classes;

namespace RC_of_Computer.FunctionSetup
{
    public partial class PHP : Form
    {
        public PHP()
        {
            InitializeComponent();

            Bitmap DirIcon = GetIcon.GetBitmapFromEXEDLL(Program.SHELL32DLL, 3, false);
            PHPRef.Image = DirIcon;
            DocumentRootRef.Image = DirIcon;
            RunPHPSetup.Image = GetIcon.GetBitmapFromEXEDLL(Program.IMAGERESDLL, 73, false);
        }

        private void RunPHPSetup_Click(object sender, System.EventArgs e)
        {
            PHPAutoSetup setupWindow = new()
            {
                Owner = this
            };
            _ = setupWindow.ShowDialog();
        }
    }
}
