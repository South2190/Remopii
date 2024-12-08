using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace RC_of_Computer
{
    public partial class ShowQRCode : Form
    {
        private List<NetworkInterface> networkInterfaces;
        private List<string> ipAddresses;
        private List<Bitmap> GenQRCodes;

        public ShowQRCode()
        {
            InitializeComponent();
            GetNetworkIF();
            networkIFComboBox.SelectedIndex = 0;
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
        private void GetNetworkIF()
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
        }

        private void networkIFComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            QRPictureBox.Image = GenQRCodes[networkIFComboBox.SelectedIndex];
            URLTextBox.Text = ipAddresses[networkIFComboBox.SelectedIndex];
            networkIFDescription.Text = networkInterfaces[networkIFComboBox.SelectedIndex].Description;
        }
    }
}
