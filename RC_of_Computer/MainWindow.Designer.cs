namespace RC_of_Computer
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ServerIO = new System.Windows.Forms.Button();
            this.ShowPHP = new System.Windows.Forms.Button();
            this.ShowKeyConfig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SetupGroup = new System.Windows.Forms.GroupBox();
            this.KeyConfigStatus = new System.Windows.Forms.PictureBox();
            this.PHPStatus = new System.Windows.Forms.PictureBox();
            this.VersionInfoLink = new System.Windows.Forms.LinkLabel();
            this.processMonitoring = new System.Windows.Forms.Timer(this.components);
            this.AppName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowQRWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.SetupGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyConfigStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHPStatus)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerIO
            // 
            this.ServerIO.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ServerIO.Location = new System.Drawing.Point(12, 170);
            this.ServerIO.Name = "ServerIO";
            this.ServerIO.Size = new System.Drawing.Size(290, 80);
            this.ServerIO.TabIndex = 60;
            this.ServerIO.Text = "スタート / ストップ";
            this.ServerIO.UseVisualStyleBackColor = true;
            this.ServerIO.Click += new System.EventHandler(this.ServerIO_Click);
            // 
            // ShowPHP
            // 
            this.ShowPHP.Font = new System.Drawing.Font("Meiryo UI", 15F);
            this.ShowPHP.Location = new System.Drawing.Point(10, 30);
            this.ShowPHP.Name = "ShowPHP";
            this.ShowPHP.Size = new System.Drawing.Size(230, 40);
            this.ShowPHP.TabIndex = 50;
            this.ShowPHP.Text = "PHPの設定";
            this.ShowPHP.UseVisualStyleBackColor = true;
            this.ShowPHP.Click += new System.EventHandler(this.ShowPHP_Click);
            // 
            // ShowKeyConfig
            // 
            this.ShowKeyConfig.Font = new System.Drawing.Font("Meiryo UI", 15F);
            this.ShowKeyConfig.Location = new System.Drawing.Point(10, 78);
            this.ShowKeyConfig.Name = "ShowKeyConfig";
            this.ShowKeyConfig.Size = new System.Drawing.Size(230, 40);
            this.ShowKeyConfig.TabIndex = 55;
            this.ShowKeyConfig.Text = "キーの割り当て";
            this.ShowKeyConfig.UseVisualStyleBackColor = true;
            this.ShowKeyConfig.Click += new System.EventHandler(this.ShowKeyConfig_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "② リモコンのスタート/ストップ";
            // 
            // SetupGroup
            // 
            this.SetupGroup.Controls.Add(this.KeyConfigStatus);
            this.SetupGroup.Controls.Add(this.PHPStatus);
            this.SetupGroup.Controls.Add(this.ShowPHP);
            this.SetupGroup.Controls.Add(this.ShowKeyConfig);
            this.SetupGroup.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.SetupGroup.Location = new System.Drawing.Point(12, 7);
            this.SetupGroup.Name = "SetupGroup";
            this.SetupGroup.Size = new System.Drawing.Size(290, 130);
            this.SetupGroup.TabIndex = 5;
            this.SetupGroup.TabStop = false;
            this.SetupGroup.Text = "① セットアップ";
            // 
            // KeyConfigStatus
            // 
            this.KeyConfigStatus.Location = new System.Drawing.Point(247, 82);
            this.KeyConfigStatus.Name = "KeyConfigStatus";
            this.KeyConfigStatus.Size = new System.Drawing.Size(32, 32);
            this.KeyConfigStatus.TabIndex = 57;
            this.KeyConfigStatus.TabStop = false;
            // 
            // PHPStatus
            // 
            this.PHPStatus.Location = new System.Drawing.Point(247, 34);
            this.PHPStatus.Name = "PHPStatus";
            this.PHPStatus.Size = new System.Drawing.Size(32, 32);
            this.PHPStatus.TabIndex = 56;
            this.PHPStatus.TabStop = false;
            // 
            // VersionInfoLink
            // 
            this.VersionInfoLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionInfoLink.AutoSize = true;
            this.VersionInfoLink.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VersionInfoLink.Location = new System.Drawing.Point(168, 262);
            this.VersionInfoLink.Name = "VersionInfoLink";
            this.VersionInfoLink.Size = new System.Drawing.Size(131, 15);
            this.VersionInfoLink.TabIndex = 61;
            this.VersionInfoLink.TabStop = true;
            this.VersionInfoLink.Text = "このアプリケーションについて";
            this.VersionInfoLink.Click += new System.EventHandler(this.ShowVersionInfo_Click);
            // 
            // processMonitoring
            // 
            this.processMonitoring.Interval = 1000;
            // 
            // AppName
            // 
            this.AppName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AppName.AutoSize = true;
            this.AppName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AppName.Location = new System.Drawing.Point(13, 262);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(82, 15);
            this.AppName.TabIndex = 62;
            this.AppName.Text = "Version 1.0.0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowQRWindow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 48);
            // 
            // ShowQRWindow
            // 
            this.ShowQRWindow.Name = "ShowQRWindow";
            this.ShowQRWindow.Size = new System.Drawing.Size(184, 22);
            this.ShowQRWindow.Text = "リモコンのURLを再表示";
            this.ShowQRWindow.Click += new System.EventHandler(this.ShowQRWindow_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.VersionInfoLink);
            this.Controls.Add(this.SetupGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerIO);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "プレゼン用リモコン(仮)";
            this.SetupGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyConfigStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHPStatus)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ServerIO;
        private System.Windows.Forms.Button ShowPHP;
        private System.Windows.Forms.Button ShowKeyConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox SetupGroup;
        private System.Windows.Forms.PictureBox KeyConfigStatus;
        private System.Windows.Forms.PictureBox PHPStatus;
        private System.Windows.Forms.LinkLabel VersionInfoLink;
        private System.Windows.Forms.Timer processMonitoring;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowQRWindow;
    }
}
