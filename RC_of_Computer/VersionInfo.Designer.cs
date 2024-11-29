namespace RC_of_Computer
{
    partial class VersionInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Developer = new System.Windows.Forms.Label();
            this.VersionInformation = new System.Windows.Forms.Label();
            this.Names = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RC_of_Computer.Properties.Resources.LargeIcon;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 258);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(417, 231);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(80, 30);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.title.Location = new System.Drawing.Point(265, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(189, 27);
            this.title.TabIndex = 2;
            this.title.Text = "リモコンプログラム";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.Version.Location = new System.Drawing.Point(267, 72);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(62, 14);
            this.Version.TabIndex = 3;
            this.Version.Text = "Version ：";
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.Developer.Location = new System.Drawing.Point(268, 122);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(60, 14);
            this.Developer.TabIndex = 4;
            this.Developer.Text = "開発者 ：";
            // 
            // VersionInformation
            // 
            this.VersionInformation.AutoSize = true;
            this.VersionInformation.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.VersionInformation.Location = new System.Drawing.Point(335, 72);
            this.VersionInformation.Name = "VersionInformation";
            this.VersionInformation.Size = new System.Drawing.Size(38, 14);
            this.VersionInformation.TabIndex = 5;
            this.VersionInformation.Text = " 1.0.0";
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.Names.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Names.Location = new System.Drawing.Point(336, 122);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(81, 84);
            this.Names.TabIndex = 6;
            this.Names.Text = "鶴見 和也\r\n石崎 海翔\r\n南 慧\r\n中谷 樹音\r\n河上 翼\r\n大津留 泰治";
            // 
            // VersionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 264);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.VersionInformation);
            this.Controls.Add(this.Developer);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.title);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VersionInfo";
            this.Text = "VersionInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Developer;
        private System.Windows.Forms.Label VersionInformation;
        private System.Windows.Forms.Label Names;
    }
}