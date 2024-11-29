using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
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
            string hostname = Dns.GetHostName();
            IPAddress[] adrList = Dns.GetHostAddresses(hostname);
            string GenURL = (Properties.Settings.Default.PortNumber == 80) ? $"http://{adrList[1].ToString()}" : $"http://{adrList[1].ToString()}:{Properties.Settings.Default.PortNumber.ToString()}";

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
