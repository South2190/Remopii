using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using RC_of_Computer.Classes;

namespace RC_of_Computer.FunctionSetup
{
    public partial class PHP : Form
    {
        public PHP()
        {
            InitializeComponent();

            const string SHELL32DLL = @"C:\Windows\System32\Shell32.dll";
            //const string IMAGERESDLL = @"C:\Windows\System32\imageres.dll";

            Bitmap DirIcon = GetIcon.GetBitmapFromEXEDLL(SHELL32DLL, 3, false);
            PHPExeFileRef.Image = DirIcon;
            DocumentRootRef.Image = DirIcon;
            //RunPHPSetup.Image = GetIcon.GetBitmapFromEXEDLL(IMAGERESDLL, 73, false);

            LoadSettings();
        }

        private void RunPHPSetup_Click(object sender, EventArgs e)
        {
            PHPAutoSetup setupWindow = new()
            {
                Owner = this
            };
            if (setupWindow.ShowDialog() == DialogResult.OK)
            {
                ExtPHPFile(true);
                Close();
            }
        }

        /// <summary>
        /// exeファイルを開くためのダイアログを表示します
        /// exeファイルのパスが"PHPExeFilePath"テキストボックスに格納されます
        /// </summary>
        private void PHPExeFileRef_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new()
            {
                Filter = "Exe files (*.exe)|*.exe|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PHPExeFilePath.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// ドキュメントルートのフォルダを開くためのダイアログを表示します
        /// ドキュメントルートのパスが"DocumentRootPath"テキストボックスに格納されます
        /// </summary>
        private void DocumentRootRef_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderBrowserDialog = new();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DocumentRootPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// 詳細設定の既定値をフォームに入力します
        /// </summary>
        private void DefaultValue_Click(object sender, EventArgs e)
        {
            WebServerSoftware.SelectedIndex = 0;
            //PHPExeFilePath.Text = "";
            UsePATHValue.Checked = false;
            //DocumentRootPath.Text = "";
            IPAddress.Text = "0.0.0.0";
            PortNumber.Text = "8000";
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (SaveSettings())
            {
                ExtPHPFile();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (SaveSettings())
            {
                ExtPHPFile();
                Close();
            }
        }

        /// <summary>
        /// 必要なPHPファイルをドキュメントルートに展開します
        /// </summary>
        /// <param name="Answer">(true)の場合確認ダイアログを表示せずファイルを展開します</param>
        private static void ExtPHPFile(bool Answer = false)
        {
            if (!Directory.Exists(Properties.Settings.Default.DocumentRoot)) { return; }
            string path = Path.Combine(Properties.Settings.Default.DocumentRoot, Program.phpFileName);
            if (File.Exists(path)) { return; }
            if (Answer == false)
            {
                DialogResult result = MessageBox.Show("設定したドキュメントルートに必要なファイルを展開しますか?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("RC_of_Computer.Resources.index.php");
            StreamReader streamReader = new(stream);
            string pf = streamReader.ReadToEnd();
            try
            {
                using StreamWriter writer = new(path);
                writer.WriteLine(pf); 
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("必要なファイルの展開に失敗しました。\n展開先ディレクトリへのアクセス権限がありません。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 設定を読み込んでフォームに反映します
        /// </summary>
        private void LoadSettings()
        {
            WebServerSoftware.SelectedIndex = Properties.Settings.Default.WebServerSoftware switch
            {
                "PHP" => 0,
                "Others" => 1,
                _ => -1
            };
            PHPExeFilePath.Text = Properties.Settings.Default.PHPExeFilePath;
            UsePATHValue.Checked = Properties.Settings.Default.UsePATHValue;
            DocumentRootPath.Text = Properties.Settings.Default.DocumentRoot;
            IPAddress.Text = Properties.Settings.Default.IPAddress;
            PortNumber.Text = Properties.Settings.Default.PortNumber.ToString();
        }

        /// <summary>
        /// フォームの内容を設定に保存します
        /// </summary>
        /// <returns>正しく保存できた場合(true)、保存できなかった場合(false)を返します</returns>
        private bool SaveSettings()
        {
            if (!int.TryParse(PortNumber.Text, out int portNumber))
            {
                MessageBox.Show("ポート番号の値を正しく入力したか確認してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Properties.Settings.Default.WebServerSoftware = WebServerSoftware.SelectedIndex switch
            {
                0 => "PHP",
                1 => "Others",
                _ => "Others"
            };
            Properties.Settings.Default.PHPExeFilePath = PHPExeFilePath.Text;
            Properties.Settings.Default.UsePATHValue = UsePATHValue.Checked;
            Properties.Settings.Default.DocumentRoot = DocumentRootPath.Text;
            Properties.Settings.Default.IPAddress = IPAddress.Text;
            Properties.Settings.Default.PortNumber = portNumber;

            Properties.Settings.Default.Save();
            return true;
        }
    }
}