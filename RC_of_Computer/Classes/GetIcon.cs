using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace RC_of_Computer.Classes
{
    public static class GetIcon
    {
        //public static readonly string SHELL32DLL = @"C:\Windows\System32\Shell32.dll";
        //public static readonly string IMAGERESDLL = @"C:\Windows\System32\imageres.dll";

        [DllImport("shell32.dll", EntryPoint = "ExtractIconEx", CharSet = CharSet.Auto)]
        private static extern int ExtractIconEx([MarshalAs(UnmanagedType.LPTStr)] string file, int index, out IntPtr largeIconHandle, out IntPtr smallIconHandle, int icons);

        [DllImport("user32.dll")]
        private static extern bool DestroyIcon(IntPtr hIcon);

        /// <summary>
        /// dllファイルからアイコンを抽出します
        /// </summary>
        /// <param name="path">DLLファイルのパス</param>
        /// <param name="iconIndex">抽出したいアイコンのインデックス番号</param>
        /// <param name="largeIcon">大きいサイズのアイコンを使用するか</param>
        /// <returns>Bitmap形式のアイコン 取得に失敗した場合は(null)</returns>
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
