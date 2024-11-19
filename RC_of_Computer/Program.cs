﻿using System;
using System.IO;
using System.Windows.Forms;

namespace RC_of_Computer
{
    internal static class Program
    {
        public const string SHELL32DLL = @"C:\Windows\System32\Shell32.dll";
        public const string IMAGERESDLL = @"C:\Windows\System32\imageres.dll";

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // カレントディレクトリをexeファイルの場所に変更
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            Application.Run(new MainWindow());
        }
    }
}
