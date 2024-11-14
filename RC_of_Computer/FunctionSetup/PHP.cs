using System.Drawing;
using System.Windows.Forms;

namespace RC_of_Computer.FunctionSetup
{
    public partial class PHP : Form
    {
        public PHP()
        {
            InitializeComponent();

            Bitmap DirIcon = Classes.GetIcon.GetBitmapFromEXEDLL(Program.SHELL32DLL, 3, false);
            PHPRef.Image = DirIcon;
            DocumentRootRef.Image = DirIcon;
            RunPHPSetup.Image = Classes.GetIcon.GetBitmapFromEXEDLL(Program.IMAGERESDLL, 73, false);
        }
    }
}
