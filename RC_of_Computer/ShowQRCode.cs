using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
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

            string hostname = Dns.GetHostName();
            IPAddress[] adrList = Dns.GetHostAddresses(hostname);
            string GenURL = (Properties.Settings.Default.PortNumber == 80) ? $"http://{adrList[1].ToString()}" : $"http://{adrList[1].ToString()}:{Properties.Settings.Default.PortNumber.ToString()}";
            Bitmap GenQRCode = GenerateQRcode(GenURL);
            URLTextBox.Text = GenURL;
            QRPictureBox.Image = GenQRCode;
        }

        private Bitmap GenerateQRcode(string URL)
        {
            var writer = new BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = 200,
                    Width = 200,
                    Margin = 1
                }
            };

            return writer.Write(URL);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
