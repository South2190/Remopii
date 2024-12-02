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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOk = new System.Windows.Forms.Button();
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
            this.pictureBox1.Location = new System.Drawing.Point(1, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(477, 225);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(93, 25);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title.Location = new System.Drawing.Point(309, 4);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(192, 35);
            this.title.TabIndex = 2;
            this.title.Text = "リモコンプログラム";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Version.Location = new System.Drawing.Point(313, 67);
            this.Version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(71, 17);
            this.Version.TabIndex = 3;
            this.Version.Text = "Version ：";
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Developer.Location = new System.Drawing.Point(320, 101);
            this.Developer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(64, 17);
            this.Developer.TabIndex = 4;
            this.Developer.Text = "開発者 ：";
            // 
            // VersionInformation
            // 
            this.VersionInformation.AutoSize = true;
            this.VersionInformation.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VersionInformation.Location = new System.Drawing.Point(392, 67);
            this.VersionInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VersionInformation.Name = "VersionInformation";
            this.VersionInformation.Size = new System.Drawing.Size(46, 17);
            this.VersionInformation.TabIndex = 5;
            this.VersionInformation.Text = " 1.0.0";
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Names.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Names.Location = new System.Drawing.Point(392, 101);
            this.Names.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(77, 102);
            this.Names.TabIndex = 6;
            this.Names.Text = "石崎 海翔\r\n大津留 泰治\r\n河上 翼\r\n鶴見 和也\r\n中谷 樹音\r\n南 慧";
            // 
            // VersionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(583, 261);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.VersionInformation);
            this.Controls.Add(this.Developer);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.title);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VersionInfo";
            this.Text = "バージョン情報";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Developer;
        private System.Windows.Forms.Label VersionInformation;
        private System.Windows.Forms.Label Names;
    }
}