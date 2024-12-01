using System;
using System.IO;
using System.Windows.Forms;

namespace RC_of_Computer
{
    internal static class Program
    {
        public static readonly string phpFileName = "index.php";
        public static readonly string csvFileName = "button.csv";

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // プロパティのバージョン更新
            if (!Properties.Settings.Default.IsUpgraded)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.IsUpgraded = true;
                Properties.Settings.Default.Save();
            }

            // カレントディレクトリをexeファイルの場所に変更
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            Application.Run(new MainWindow());
        }
    }
}
