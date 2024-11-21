using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using RC_of_Computer.Classes;

namespace RC_of_Computer.FunctionSetup
{
    public partial class PHP : Form
    {
        public PHP()
        {
            InitializeComponent();

            Bitmap DirIcon = GetIcon.GetBitmapFromEXEDLL(Program.SHELL32DLL, 3, false);
            PHPExeFileRef.Image = DirIcon;
            DocumentRootRef.Image = DirIcon;
            RunPHPSetup.Image = GetIcon.GetBitmapFromEXEDLL(Program.IMAGERESDLL, 73, false);

            LoadSettings();
        }

        private void RunPHPSetup_Click(object sender, System.EventArgs e)
        {
            PHPAutoSetup setupWindow = new()
            {
                Owner = this
            };
            _ = setupWindow.ShowDialog();
            
            LoadSettings();
        }

        /// <summary>
        /// exeファイルを開くためのダイアログを表示します
        /// exeファイルのパスが"PHPExeFilePath"テキストボックスに格納されます
        /// </summary>
        private void PHPExeFileRef_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
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
        private void DocumentRootRef_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DocumentRootPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ApplyButton_Click(object sender, System.EventArgs e)
        {
            SaveSettings();
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            if (SaveSettings())
            {
                Close();
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
            if (!int.TryParse(PortNumber.Text, out var portNumber))
            {
                MessageBox.Show("値を正しく入力したか確認してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
