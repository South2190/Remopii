namespace RC_of_Computer.FunctionSetup
{
    partial class PHP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PHP));
            this.SettingsItem1 = new System.Windows.Forms.Label();
            this.RunPHPSetup = new System.Windows.Forms.Button();
            this.UsePATHValue = new System.Windows.Forms.CheckBox();
            this.AdvancedSettings = new System.Windows.Forms.GroupBox();
            this.defaultValue = new System.Windows.Forms.Button();
            this.SettingsItem5 = new System.Windows.Forms.Label();
            this.SettingsItem4 = new System.Windows.Forms.Label();
            this.WebServerSoftware = new System.Windows.Forms.ComboBox();
            this.SettingsItem2 = new System.Windows.Forms.Label();
            this.DocumentRootRef = new System.Windows.Forms.Button();
            this.DocumentRootPath = new System.Windows.Forms.TextBox();
            this.SettingsItem3 = new System.Windows.Forms.Label();
            this.PHPExeFileRef = new System.Windows.Forms.Button();
            this.PortNumber = new System.Windows.Forms.TextBox();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.PHPExeFilePath = new System.Windows.Forms.TextBox();
            this.RunPHPSetupDescription = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.AdvancedSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsItem1
            // 
            this.SettingsItem1.AutoSize = true;
            this.SettingsItem1.Location = new System.Drawing.Point(10, 24);
            this.SettingsItem1.Name = "SettingsItem1";
            this.SettingsItem1.Size = new System.Drawing.Size(122, 15);
            this.SettingsItem1.TabIndex = 2;
            this.SettingsItem1.Text = "Webサーバーソフトウェア";
            // 
            // RunPHPSetup
            // 
            this.RunPHPSetup.Location = new System.Drawing.Point(15, 30);
            this.RunPHPSetup.Name = "RunPHPSetup";
            this.RunPHPSetup.Size = new System.Drawing.Size(170, 25);
            this.RunPHPSetup.TabIndex = 1;
            this.RunPHPSetup.Text = "PHPの自動セットアップ";
            this.RunPHPSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RunPHPSetup.UseVisualStyleBackColor = true;
            this.RunPHPSetup.Click += new System.EventHandler(this.RunPHPSetup_Click);
            // 
            // UsePATHValue
            // 
            this.UsePATHValue.AutoSize = true;
            this.UsePATHValue.Location = new System.Drawing.Point(200, 76);
            this.UsePATHValue.Name = "UsePATHValue";
            this.UsePATHValue.Size = new System.Drawing.Size(148, 19);
            this.UsePATHValue.TabIndex = 25;
            this.UsePATHValue.Text = "環境変数の値を使用する";
            this.UsePATHValue.UseVisualStyleBackColor = true;
            // 
            // AdvancedSettings
            // 
            this.AdvancedSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvancedSettings.Controls.Add(this.defaultValue);
            this.AdvancedSettings.Controls.Add(this.SettingsItem5);
            this.AdvancedSettings.Controls.Add(this.SettingsItem4);
            this.AdvancedSettings.Controls.Add(this.WebServerSoftware);
            this.AdvancedSettings.Controls.Add(this.SettingsItem2);
            this.AdvancedSettings.Controls.Add(this.DocumentRootRef);
            this.AdvancedSettings.Controls.Add(this.DocumentRootPath);
            this.AdvancedSettings.Controls.Add(this.SettingsItem3);
            this.AdvancedSettings.Controls.Add(this.PHPExeFileRef);
            this.AdvancedSettings.Controls.Add(this.PortNumber);
            this.AdvancedSettings.Controls.Add(this.IPAddress);
            this.AdvancedSettings.Controls.Add(this.PHPExeFilePath);
            this.AdvancedSettings.Controls.Add(this.SettingsItem1);
            this.AdvancedSettings.Controls.Add(this.UsePATHValue);
            this.AdvancedSettings.Location = new System.Drawing.Point(12, 65);
            this.AdvancedSettings.Name = "AdvancedSettings";
            this.AdvancedSettings.Size = new System.Drawing.Size(580, 230);
            this.AdvancedSettings.TabIndex = 2;
            this.AdvancedSettings.TabStop = false;
            this.AdvancedSettings.Text = "詳細設定 (PHPの自動セットアップを使用する場合は変更しないでください)";
            // 
            // defaultValue
            // 
            this.defaultValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultValue.Location = new System.Drawing.Point(490, 195);
            this.defaultValue.Name = "defaultValue";
            this.defaultValue.Size = new System.Drawing.Size(80, 25);
            this.defaultValue.TabIndex = 50;
            this.defaultValue.Text = "既定値";
            this.defaultValue.UseVisualStyleBackColor = true;
            this.defaultValue.Click += new System.EventHandler(this.DefaultValue_Click);
            // 
            // SettingsItem5
            // 
            this.SettingsItem5.AutoSize = true;
            this.SettingsItem5.Location = new System.Drawing.Point(10, 164);
            this.SettingsItem5.Name = "SettingsItem5";
            this.SettingsItem5.Size = new System.Drawing.Size(59, 15);
            this.SettingsItem5.TabIndex = 0;
            this.SettingsItem5.Text = "ポート番号";
            // 
            // SettingsItem4
            // 
            this.SettingsItem4.AutoSize = true;
            this.SettingsItem4.Location = new System.Drawing.Point(10, 134);
            this.SettingsItem4.Name = "SettingsItem4";
            this.SettingsItem4.Size = new System.Drawing.Size(90, 15);
            this.SettingsItem4.TabIndex = 0;
            this.SettingsItem4.Text = "接続元IPアドレス";
            // 
            // WebServerSoftware
            // 
            this.WebServerSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebServerSoftware.FormattingEnabled = true;
            this.WebServerSoftware.Items.AddRange(new object[] {
            "PHPのビルトインウェブサーバーを使用する",
            "Nginx、Apacheなどを使用する"});
            this.WebServerSoftware.Location = new System.Drawing.Point(200, 21);
            this.WebServerSoftware.Name = "WebServerSoftware";
            this.WebServerSoftware.Size = new System.Drawing.Size(367, 23);
            this.WebServerSoftware.TabIndex = 10;
            // 
            // SettingsItem2
            // 
            this.SettingsItem2.AutoSize = true;
            this.SettingsItem2.Location = new System.Drawing.Point(10, 54);
            this.SettingsItem2.Name = "SettingsItem2";
            this.SettingsItem2.Size = new System.Drawing.Size(117, 15);
            this.SettingsItem2.TabIndex = 0;
            this.SettingsItem2.Text = "PHP実行ファイルのパス";
            // 
            // DocumentRootRef
            // 
            this.DocumentRootRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentRootRef.Location = new System.Drawing.Point(542, 100);
            this.DocumentRootRef.Name = "DocumentRootRef";
            this.DocumentRootRef.Size = new System.Drawing.Size(25, 25);
            this.DocumentRootRef.TabIndex = 35;
            this.DocumentRootRef.UseVisualStyleBackColor = true;
            this.DocumentRootRef.Click += new System.EventHandler(this.DocumentRootRef_Click);
            // 
            // DocumentRootPath
            // 
            this.DocumentRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentRootPath.Location = new System.Drawing.Point(200, 101);
            this.DocumentRootPath.Name = "DocumentRootPath";
            this.DocumentRootPath.Size = new System.Drawing.Size(335, 23);
            this.DocumentRootPath.TabIndex = 30;
            // 
            // SettingsItem3
            // 
            this.SettingsItem3.AutoSize = true;
            this.SettingsItem3.Location = new System.Drawing.Point(10, 104);
            this.SettingsItem3.Name = "SettingsItem3";
            this.SettingsItem3.Size = new System.Drawing.Size(86, 15);
            this.SettingsItem3.TabIndex = 0;
            this.SettingsItem3.Text = "ドキュメントルート";
            // 
            // PHPExeFileRef
            // 
            this.PHPExeFileRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PHPExeFileRef.Location = new System.Drawing.Point(542, 50);
            this.PHPExeFileRef.Name = "PHPExeFileRef";
            this.PHPExeFileRef.Size = new System.Drawing.Size(25, 25);
            this.PHPExeFileRef.TabIndex = 20;
            this.PHPExeFileRef.UseVisualStyleBackColor = true;
            this.PHPExeFileRef.Click += new System.EventHandler(this.PHPExeFileRef_Click);
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(200, 161);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(150, 23);
            this.PortNumber.TabIndex = 45;
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(200, 131);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(150, 23);
            this.IPAddress.TabIndex = 40;
            // 
            // PHPExeFilePath
            // 
            this.PHPExeFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PHPExeFilePath.Location = new System.Drawing.Point(200, 51);
            this.PHPExeFilePath.Name = "PHPExeFilePath";
            this.PHPExeFilePath.Size = new System.Drawing.Size(335, 23);
            this.PHPExeFilePath.TabIndex = 15;
            // 
            // RunPHPSetupDescription
            // 
            this.RunPHPSetupDescription.AutoSize = true;
            this.RunPHPSetupDescription.Location = new System.Drawing.Point(12, 10);
            this.RunPHPSetupDescription.Name = "RunPHPSetupDescription";
            this.RunPHPSetupDescription.Size = new System.Drawing.Size(211, 15);
            this.RunPHPSetupDescription.TabIndex = 4;
            this.RunPHPSetupDescription.Text = "必要なPHPの設定を全て自動で行います。";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(340, 302);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(80, 25);
            this.buttonOk.TabIndex = 55;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(425, 302);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 25);
            this.buttonCancel.TabIndex = 60;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(510, 302);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(80, 25);
            this.buttonApply.TabIndex = 65;
            this.buttonApply.Text = "適用";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // PHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(604, 337);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.RunPHPSetupDescription);
            this.Controls.Add(this.AdvancedSettings);
            this.Controls.Add(this.RunPHPSetup);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 376);
            this.Name = "PHP";
            this.Text = "PHPの設定";
            this.AdvancedSettings.ResumeLayout(false);
            this.AdvancedSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsItem1;
        private System.Windows.Forms.Button RunPHPSetup;
        private System.Windows.Forms.CheckBox UsePATHValue;
        private System.Windows.Forms.GroupBox AdvancedSettings;
        private System.Windows.Forms.Label RunPHPSetupDescription;
        private System.Windows.Forms.TextBox PHPExeFilePath;
        private System.Windows.Forms.Button PHPExeFileRef;
        private System.Windows.Forms.Label SettingsItem3;
        private System.Windows.Forms.Button DocumentRootRef;
        private System.Windows.Forms.TextBox DocumentRootPath;
        private System.Windows.Forms.Label SettingsItem2;
        private System.Windows.Forms.ComboBox WebServerSoftware;
        private System.Windows.Forms.Label SettingsItem5;
        private System.Windows.Forms.Label SettingsItem4;
        private System.Windows.Forms.TextBox PortNumber;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button defaultValue;
    }
}