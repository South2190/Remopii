using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RC_of_Computer.Classes
{
    public static class CSVIO
    {
        /// <summary>
        /// CSVファイルを読み込み、リストを初期化した上で格納します
        /// ファイルが存在しない場合はリストの書き換えを行いません
        /// </summary>
        /// <param name="CSVFilePath">CSVファイルのパス</param>
        /// <param name="list">格納先のリスト</param>
        public static void LoadCSV(string CSVFilePath, ref List<string[]> list)
        {
            if (!File.Exists(CSVFilePath)) { return; }

            list = new();
            string line;
            using StreamReader sr = new(CSVFilePath);
            while ((line = sr.ReadLine()) != null)
            {
                // コメントアウトの行と空行を無視する
                if (line[0] == '#' || line == string.Empty) { continue; }
                string[] s = line.Split(',');
                list.Add(s);
            }
        }

        /// <summary>
        /// リストをCSVファイルに上書きします
        /// 指定されたCSVファイルの元の内容は消失します
        /// </summary>
        /// <param name="CSVFilePath">CSVファイルのパス</param>
        /// <param name="list">CSVに書き込みたいリスト</param>
        /// <param name="comment">(任意)CSVファイルの一行目に書き込みたいコメント</param>
        public static void WriteCSV(string CSVFilePath, in List<string[]> list, string comment = null)
        {
            using StreamWriter sw = new(CSVFilePath, false, Encoding.UTF8);
            if (comment != null) { sw.WriteLine('#' + comment); }
            foreach (string[] line in list)
            {
                string Raw = string.Empty;
                foreach (string item in line)
                {
                    Raw += item + ',';
                }
                // 行末のカンマを削除して書き込み
                sw.WriteLine(Raw.Remove(Raw.Length - 1));
            }
        }
    }
}
