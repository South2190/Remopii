using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace RC_of_Computer
{
    public partial class ShowQRCode : Form
    {
        public ShowQRCode()
        {
            InitializeComponent();

            // URLの生成
            List<string> ipAddresses = new();
            string hostName = Dns.GetHostName();
            IPHostEntry host = Dns.GetHostEntry(hostName);
            foreach (IPAddress address in host.AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork) { ipAddresses.Add(address.ToString()); }
            }
            if (ipAddresses.Count >= 2)
            {
                MessageBox.Show("有効なIPアドレスが複数検出されました。IPアドレスが正しく表示されていない可能性があります。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string GenURL = $"http://{ipAddresses[0]}";
            if (Properties.Settings.Default.PortNumber != 80) { GenURL += $":{Properties.Settings.Default.PortNumber}"; }
            URLTextBox.Text = GenURL;
            QRPictureBox.Image = GenerateQRcode(GenURL);
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
    }
    
}
