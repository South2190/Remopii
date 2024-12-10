using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace seigyo
{
    internal class Program
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.WriteLine("引数が正しく指定されていません");
                Environment.ExitCode = -1;   //終了コード
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    switch (args[i])
                    {
                        case "-p":
                        case "--Process":
                            try
                            {
                                Process[] p = Process.GetProcessesByName(args[++i]);
                                foreach (Process ps in p)
                                {
                                    SetForegroundWindow(ps.MainWindowHandle);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("エラーが発生しました");
                                Environment.ExitCode = -2;   //終了コード
                            }
                            break;
                        case "-k":
                        case "--KeyPress":
                            try
                            {
                                SendKeys.SendWait(args[++i]);
                            }
                            catch
                            {
                                Console.WriteLine("エラーが発生しました");
                                Environment.ExitCode = -2;   //終了コード
                            }
                            break;
                        default:
                            Console.WriteLine("引数が正しく指定されていません");
                            Environment.ExitCode = -1;   //終了コード
                            break;
                    }
                }
            }
            Application.Exit();
        }
    }
}
