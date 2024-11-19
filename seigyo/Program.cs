using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seigyo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("引数が指定されていません");
                Environment.ExitCode = 1;   //終了コードなど
                Application.Exit();         //FormClosing, FormClosed なども発生する
            }
            else
            {
                SendKeys.SendWait(args[0]);
                Application.Exit();
            }
        }
    }
}
