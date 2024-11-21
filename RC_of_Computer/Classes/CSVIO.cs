using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_of_Computer.Classes
{
    internal class CSVIO
    {
        /// <summary>
        /// リストをCSVファイルに上書きします
        /// 指定されたCSVファイルの元の内容は消失します
        /// </summary>
        /// <param name="CSVFilePath">CSVファイルのパス</param>
        /// <param name="list">CSVに書き込みたいリスト</param>
        /// <param name="comment">(任意)CSVファイルの一行目に書き込みたいコメント</param>
        public static void WriteListCSV(string CSVFilePath, List<string[]> list, string? comment = null)
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
