using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RC_of_Computer.FunctionSetup
{
    public partial class PHP : Form
    {
        private const string SHELL32DLL = @"C:\Windows\System32\Shell32.dll";

        [DllImport("shell32.dll", EntryPoint = "ExtractIconEx", CharSet = CharSet.Auto)]
        private static extern int ExtractIconEx([MarshalAs(UnmanagedType.LPTStr)] string file, int index, out IntPtr largeIconHandle, out IntPtr smallIconHandle, int icons);

        [DllImport("User32.dll")]
        private static extern bool DestroyIcon(IntPtr hIcon);

        public PHP()
        {
            InitializeComponent();

            Bitmap DirIcon = GetIconFromEXEDLL(SHELL32DLL, 3, false);
            PHPRef.Image = DirIcon;
            DocumentRootRef.Image = DirIcon;
            //RunPHPSetup.Image = SystemIcons.Shield.ToBitmap();
            RunPHPSetup.Image = new Icon(SystemIcons.Shield, new Size(23, 23)).ToBitmap();
        }

        /*
        private static void SetIconToButton(Button button, int iconIndex)
        {
            Icon icon = GetIconFromEXEDLL(@"C:\Windows\System32\Shell32.dll", iconIndex, false);
            button.Image = icon.ToBitmap();
            //button.TextImageRelation = TextImageRelation.ImageAboveText;
        }
        */

        private static Bitmap GetIconFromEXEDLL(string path, int iconIndex, bool iconSize)
        {
            try
            {
                Icon[] icons = new Icon[2];
                IntPtr largeIconHandle = IntPtr.Zero;
                IntPtr smallIconHandle = IntPtr.Zero;
                ExtractIconEx(path, iconIndex, out largeIconHandle, out smallIconHandle, 1);
                icons[0] = (Icon)Icon.FromHandle(largeIconHandle).Clone();
                icons[1] = (Icon)Icon.FromHandle(smallIconHandle).Clone();
                DestroyIcon(largeIconHandle);
                DestroyIcon(smallIconHandle);

                if (iconSize)
                {
                    return icons[0].ToBitmap();
                }
                else
                {
                    return icons[1].ToBitmap();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
