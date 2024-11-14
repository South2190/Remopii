using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace RC_of_Computer.Classes
{
    internal class GetIcon
    {
        [DllImport("shell32.dll", EntryPoint = "ExtractIconEx", CharSet = CharSet.Auto)]
        private static extern int ExtractIconEx([MarshalAs(UnmanagedType.LPTStr)] string file, int index, out IntPtr largeIconHandle, out IntPtr smallIconHandle, int icons);

        [DllImport("User32.dll")]
        private static extern bool DestroyIcon(IntPtr hIcon);

        public static Bitmap GetBitmapFromEXEDLL(string path, int iconIndex, bool largeIcon)
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

                if (largeIcon)
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
