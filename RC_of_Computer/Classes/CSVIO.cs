using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RC_of_Computer.Classes
{
    public static class CSVIO
    {
        /// <summary>
        /// CSVファイルを読み込み、リストに格納します
        /// リスト各行の一番最後の要素に"\0"を格納します
        /// </summary>
        /// <param name="CSVFilePath">CSVファイルのパス</param>
        /// <param name="CSVList">格納するリスト</param>
        /// <returns>正常に読み込めた場合はリストの行数、CSVファイルが存在しない場合は(-1)</returns>
        public static int LoadCSV(string CSVFilePath, out List<string[]> CSVList)
        {
            CSVList = new();
            if (!File.Exists(CSVFilePath)) { return -1; }

            StreamReader sr = new(CSVFilePath);
            int i = 0;
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                // コメントアウトの行と空行を無視する
                if (line[0] == '#' || line == "") { continue; }

                string[] work = line.Split(',');
                Array.Resize(ref work, work.Length + 1);
                work[work.Length - 1] = "\0";

                CSVList.Add(work);
                i++;
            }
            sr.Close();
            return i;
        }
        /// <summary>
        /// リストをCSVファイルに上書きします
        /// 指定されたCSVファイルの元の内容は消失します
        /// </summary>
        /// <param name="CSVFilePath">CSVファイルのパス</param>
        /// <param name="list">CSVに書き込みたいリスト</param>
        /// <param name="comment">(任意)CSVファイルの一行目に書き込みたいコメント</param>
        public static void WriteListCSV(string CSVFilePath, in List<string[]> list, string? comment = null)
        {
            StreamWriter sw = new(CSVFilePath, false, Encoding.UTF8);
            if (comment != null) { sw.WriteLine('#' + comment); }
            foreach (string[] line in list)
            {
                string Raw = "";
                int i;
                for (i = 0; line[i + 1] != "\0"; i++)
                {
                    Raw += line[i] + ',';
                }
                Raw += line[i];
                sw.WriteLine(Raw);
            }
            sw.Close();
        }
    }
}
