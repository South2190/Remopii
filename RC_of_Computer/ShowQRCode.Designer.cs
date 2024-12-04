namespace RC_of_Computer
{
    partial class ShowQRCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowQRCode));
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.QRPictureBox = new System.Windows.Forms.PictureBox();
            this.networkIFComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.networkIFDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QRPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "QRコードを読み取るか、ブラウザのアドレスバーに次のURLを入力してアクセスしてください";
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OKButton.Location = new System.Drawing.Point(563, 236);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(88, 25);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(233, 86);
            this.URLTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.ReadOnly = true;
            this.URLTextBox.Size = new System.Drawing.Size(223, 23);
            this.URLTextBox.TabIndex = 4;
            this.URLTextBox.Text = "http://x.x.x.x:8000";
            // 
            // QRPictureBox
            // 
            this.QRPictureBox.Location = new System.Drawing.Point(13, 56);
            this.QRPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.QRPictureBox.Name = "QRPictureBox";
            this.QRPictureBox.Size = new System.Drawing.Size(200, 200);
            this.QRPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRPictureBox.TabIndex = 0;
            this.QRPictureBox.TabStop = false;
            // 
            // networkIFComboBox
            // 
            this.networkIFComboBox.FormattingEnabled = true;
            this.networkIFComboBox.Location = new System.Drawing.Point(95, 6);
            this.networkIFComboBox.Name = "networkIFComboBox";
            this.networkIFComboBox.Size = new System.Drawing.Size(318, 23);
            this.networkIFComboBox.TabIndex = 5;
            this.networkIFComboBox.SelectedIndexChanged += new System.EventHandler(this.networkIFComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "接続先の選択";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "説明：";
            // 
            // networkIFDescription
            // 
            this.networkIFDescription.AutoSize = true;
            this.networkIFDescription.Location = new System.Drawing.Point(48, 34);
            this.networkIFDescription.Name = "networkIFDescription";
            this.networkIFDescription.Size = new System.Drawing.Size(41, 15);
            this.networkIFDescription.TabIndex = 8;
            this.networkIFDescription.Text = "label4";
            // 
            // ShowQRCode
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.OKButton;
            this.ClientSize = new System.Drawing.Size(664, 269);
            this.Controls.Add(this.networkIFDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.networkIFComboBox);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QRPictureBox);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowQRCode";
            this.Text = "ShowQRCode";
            ((System.ComponentModel.ISupportInitialize)(this.QRPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.ComboBox networkIFComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label networkIFDescription;
    }
}