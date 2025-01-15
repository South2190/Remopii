using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace Remopii
{
    public partial class ShowQRCode : Form
    {
        private List<NetworkInterface> networkInterfaces;
        private List<string> ipAddresses;
        private List<Bitmap> GenQRCodes;

        public ShowQRCode(int Theme)
        {
            InitializeComponent();
            if (!GetNetworkIF()) { Close(); }
            networkIFComboBox.SelectedIndex = 0;

            ChangeTheme(Theme);
        }

        /// <summary>
        /// ウインドウのテーマを設定します
        /// </summary>
        /// <param name="themeNumber">設定したいテーマの番号</param>
        private void ChangeTheme(int themeNumber)
        {
            switch (themeNumber)
            {
                // ダーク
                case 0:
                    BackColor = Color.FromArgb(32, 32, 32);
                    ForeColor = Color.FromArgb(255, 255, 255);
                    reloadNetwarkIF.BackColor = Color.FromArgb(56, 56, 56);
                    OKButton.BackColor = Color.FromArgb(56, 56, 56);
                    networkIFComboBox.BackColor = Color.FromArgb(32, 32, 32);
                    networkIFComboBox.ForeColor = Color.FromArgb(255, 255, 255);
                    URLTextBox.BackColor = Color.FromArgb(32, 32, 32);
                    URLTextBox.ForeColor = Color.FromArgb(255, 255, 255);
                    break;
                // デフォルト
                case 1:
                default:
                    return;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// QRコードを生成します
        /// </summary>
        /// <param name="URL">URL</param>
        /// <returns>Bitmap形式のQRコード</returns>
        private static Bitmap GenerateQRcode(string URL)
        {
            BarcodeWriter writer = new()
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = 200,
                    Width = 200,
                    Margin = 1
                }
            };

            return writer.Write(URL);
        }

        /// <summary>
        /// 現在稼働中のネットワークI/Fを取得します
        /// </summary>
        private bool GetNetworkIF()
        {
            networkIFComboBox.Items.Clear();
            networkInterfaces = new();
            ipAddresses = new();
            GenQRCodes = new();
            foreach (var ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up && ni.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    networkInterfaces.Add(ni);
                    networkIFComboBox.Items.Add(ni.Name);

                    // URLの生成
                    string GenURL = "http://";
                    IPInterfaceProperties ipips = ni.GetIPProperties();
                    if (ipips != null)
                    {
                        foreach (UnicastIPAddressInformation i in ipips.UnicastAddresses)
                        {
                            if (i.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                GenURL += i.Address;
                            }
                        }
                    }
                    if (Properties.Settings.Default.PortNumber != 80) { GenURL += $":{Properties.Settings.Default.PortNumber}"; }

                    ipAddresses.Add(GenURL);
                    GenQRCodes.Add(GenerateQRcode(GenURL));
                }
            }
            if (networkInterfaces.Count <= 0)
            {
                MessageBox.Show("有効なネットワークが検出できませんでした。\nリモコンとして使用する端末と同じネットワークに接続されているかを確認してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (networkInterfaces.Count >= 2)
            {
                MessageBox.Show("有効なネットワークが複数検出されました。\n\"接続先の選択\"にてリモコンとして使用する端末と同じネットワークに接続されているかを確認してください。", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }

        private void networkIFComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            QRPictureBox.Image = GenQRCodes[networkIFComboBox.SelectedIndex];
            URLTextBox.Text = ipAddresses[networkIFComboBox.SelectedIndex];
            networkIFDescription.Text = networkInterfaces[networkIFComboBox.SelectedIndex].Description;
        }

        private void reloadNetwarkIF_Click(object sender, EventArgs e)
        {
            GetNetworkIF();
        }
    }
}
