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
            this.SettingsItem1 = new System.Windows.Forms.Label();
            this.RunPHPSetup = new System.Windows.Forms.Button();
            this.UsePATHValue = new System.Windows.Forms.CheckBox();
            this.AdvancedSettings = new System.Windows.Forms.GroupBox();
            this.SettingsItem3 = new System.Windows.Forms.Label();
            this.PHPRef = new System.Windows.Forms.Button();
            this.PHPPath = new System.Windows.Forms.TextBox();
            this.PHPStatus = new System.Windows.Forms.Label();
            this.DocumentRootPath = new System.Windows.Forms.TextBox();
            this.DocumentRootRef = new System.Windows.Forms.Button();
            this.SettingsItem2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AdvancedSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsItem1
            // 
            this.SettingsItem1.AutoSize = true;
            this.SettingsItem1.Location = new System.Drawing.Point(10, 24);
            this.SettingsItem1.Name = "SettingsItem1";
            this.SettingsItem1.Size = new System.Drawing.Size(116, 12);
            this.SettingsItem1.TabIndex = 0;
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
            // 
            // UsePATHValue
            // 
            this.UsePATHValue.AutoSize = true;
            this.UsePATHValue.Location = new System.Drawing.Point(200, 75);
            this.UsePATHValue.Name = "UsePATHValue";
            this.UsePATHValue.Size = new System.Drawing.Size(146, 16);
            this.UsePATHValue.TabIndex = 2;
            this.UsePATHValue.Text = "環境変数の値を使用する";
            this.UsePATHValue.UseVisualStyleBackColor = true;
            // 
            // AdvancedSettings
            // 
            this.AdvancedSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvancedSettings.Controls.Add(this.comboBox1);
            this.AdvancedSettings.Controls.Add(this.SettingsItem2);
            this.AdvancedSettings.Controls.Add(this.DocumentRootRef);
            this.AdvancedSettings.Controls.Add(this.DocumentRootPath);
            this.AdvancedSettings.Controls.Add(this.SettingsItem3);
            this.AdvancedSettings.Controls.Add(this.PHPRef);
            this.AdvancedSettings.Controls.Add(this.PHPPath);
            this.AdvancedSettings.Controls.Add(this.SettingsItem1);
            this.AdvancedSettings.Controls.Add(this.UsePATHValue);
            this.AdvancedSettings.Location = new System.Drawing.Point(12, 65);
            this.AdvancedSettings.Name = "AdvancedSettings";
            this.AdvancedSettings.Size = new System.Drawing.Size(580, 135);
            this.AdvancedSettings.TabIndex = 3;
            this.AdvancedSettings.TabStop = false;
            this.AdvancedSettings.Text = "詳細設定 (PHPの自動セットアップを使用する場合は変更しないでください)";
            // 
            // SettingsItem3
            // 
            this.SettingsItem3.AutoSize = true;
            this.SettingsItem3.Location = new System.Drawing.Point(10, 104);
            this.SettingsItem3.Name = "SettingsItem3";
            this.SettingsItem3.Size = new System.Drawing.Size(85, 12);
            this.SettingsItem3.TabIndex = 5;
            this.SettingsItem3.Text = "ドキュメントルート";
            // 
            // PHPRef
            // 
            this.PHPRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PHPRef.Location = new System.Drawing.Point(545, 50);
            this.PHPRef.Name = "PHPRef";
            this.PHPRef.Size = new System.Drawing.Size(22, 22);
            this.PHPRef.TabIndex = 4;
            this.PHPRef.UseVisualStyleBackColor = true;
            // 
            // PHPPath
            // 
            this.PHPPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PHPPath.Location = new System.Drawing.Point(200, 51);
            this.PHPPath.Name = "PHPPath";
            this.PHPPath.Size = new System.Drawing.Size(340, 19);
            this.PHPPath.TabIndex = 3;
            // 
            // PHPStatus
            // 
            this.PHPStatus.AutoSize = true;
            this.PHPStatus.Location = new System.Drawing.Point(12, 10);
            this.PHPStatus.Name = "PHPStatus";
            this.PHPStatus.Size = new System.Drawing.Size(165, 12);
            this.PHPStatus.TabIndex = 4;
            this.PHPStatus.Text = "PHPセットアップ済 / 未セットアップ";
            // 
            // DocumentRootPath
            // 
            this.DocumentRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentRootPath.Location = new System.Drawing.Point(200, 101);
            this.DocumentRootPath.Name = "DocumentRootPath";
            this.DocumentRootPath.Size = new System.Drawing.Size(340, 19);
            this.DocumentRootPath.TabIndex = 6;
            // 
            // DocumentRootRef
            // 
            this.DocumentRootRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentRootRef.Location = new System.Drawing.Point(545, 100);
            this.DocumentRootRef.Name = "DocumentRootRef";
            this.DocumentRootRef.Size = new System.Drawing.Size(22, 22);
            this.DocumentRootRef.TabIndex = 7;
            this.DocumentRootRef.UseVisualStyleBackColor = true;
            // 
            // SettingsItem2
            // 
            this.SettingsItem2.AutoSize = true;
            this.SettingsItem2.Location = new System.Drawing.Point(10, 54);
            this.SettingsItem2.Name = "SettingsItem2";
            this.SettingsItem2.Size = new System.Drawing.Size(114, 12);
            this.SettingsItem2.TabIndex = 8;
            this.SettingsItem2.Text = "PHP実行ファイルのパス";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PHPのビルトインウェブサーバーを使用する",
            "Nginx、Apacheなどを使用する"});
            this.comboBox1.Location = new System.Drawing.Point(200, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(367, 20);
            this.comboBox1.TabIndex = 9;
            // 
            // PHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.PHPStatus);
            this.Controls.Add(this.AdvancedSettings);
            this.Controls.Add(this.RunPHPSetup);
            this.Name = "PHP";
            this.Text = "PHP設定";
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
        private System.Windows.Forms.Label PHPStatus;
        private System.Windows.Forms.TextBox PHPPath;
        private System.Windows.Forms.Button PHPRef;
        private System.Windows.Forms.Label SettingsItem3;
        private System.Windows.Forms.Button DocumentRootRef;
        private System.Windows.Forms.TextBox DocumentRootPath;
        private System.Windows.Forms.Label SettingsItem2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}