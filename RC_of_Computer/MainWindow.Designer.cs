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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ServerIO = new System.Windows.Forms.Button();
            this.ShowPHP = new System.Windows.Forms.Button();
            this.ShowKeyConfig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SetupGroup = new System.Windows.Forms.GroupBox();
            this.KeyConfigStatus = new System.Windows.Forms.PictureBox();
            this.PHPStatus = new System.Windows.Forms.PictureBox();
            this.SetupGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyConfigStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHPStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ServerIO
            // 
            this.ServerIO.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ServerIO.Location = new System.Drawing.Point(8, 198);
            this.ServerIO.Name = "ServerIO";
            this.ServerIO.Size = new System.Drawing.Size(297, 92);
            this.ServerIO.TabIndex = 60;
            this.ServerIO.Text = "サーバースタート";
            this.ServerIO.UseVisualStyleBackColor = true;
            this.ServerIO.Click += new System.EventHandler(this.ServerIO_Click);
            // 
            // ShowPHP
            // 
            this.ShowPHP.Font = new System.Drawing.Font("Meiryo UI", 15F);
            this.ShowPHP.Location = new System.Drawing.Point(10, 28);
            this.ShowPHP.Name = "ShowPHP";
            this.ShowPHP.Size = new System.Drawing.Size(230, 44);
            this.ShowPHP.TabIndex = 50;
            this.ShowPHP.Text = "PHPのセットアップ...";
            this.ShowPHP.UseVisualStyleBackColor = true;
            this.ShowPHP.Click += new System.EventHandler(this.ShowPHP_Click);
            // 
            // ShowKeyConfig
            // 
            this.ShowKeyConfig.Font = new System.Drawing.Font("Meiryo UI", 15F);
            this.ShowKeyConfig.Location = new System.Drawing.Point(10, 78);
            this.ShowKeyConfig.Name = "ShowKeyConfig";
            this.ShowKeyConfig.Size = new System.Drawing.Size(230, 44);
            this.ShowKeyConfig.TabIndex = 55;
            this.ShowKeyConfig.Text = "キーコンフィグ...";
            this.ShowKeyConfig.UseVisualStyleBackColor = true;
            this.ShowKeyConfig.Click += new System.EventHandler(this.ShowKeyConfig_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "② スタート/ストップ";
            // 
            // SetupGroup
            // 
            this.SetupGroup.Controls.Add(this.KeyConfigStatus);
            this.SetupGroup.Controls.Add(this.PHPStatus);
            this.SetupGroup.Controls.Add(this.ShowPHP);
            this.SetupGroup.Controls.Add(this.ShowKeyConfig);
            this.SetupGroup.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.SetupGroup.Location = new System.Drawing.Point(10, 27);
            this.SetupGroup.Name = "SetupGroup";
            this.SetupGroup.Size = new System.Drawing.Size(297, 132);
            this.SetupGroup.TabIndex = 5;
            this.SetupGroup.TabStop = false;
            this.SetupGroup.Text = "① セットアップ";
            // 
            // KeyConfigStatus
            // 
            this.KeyConfigStatus.Location = new System.Drawing.Point(250, 84);
            this.KeyConfigStatus.Name = "KeyConfigStatus";
            this.KeyConfigStatus.Size = new System.Drawing.Size(32, 32);
            this.KeyConfigStatus.TabIndex = 57;
            this.KeyConfigStatus.TabStop = false;
            // 
            // PHPStatus
            // 
            this.PHPStatus.Location = new System.Drawing.Point(250, 34);
            this.PHPStatus.Name = "PHPStatus";
            this.PHPStatus.Size = new System.Drawing.Size(32, 32);
            this.PHPStatus.TabIndex = 56;
            this.PHPStatus.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(314, 301);
            this.Controls.Add(this.SetupGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerIO);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.SetupGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyConfigStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHPStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button ServerIO;
        private System.Windows.Forms.Button ShowPHP;
        private System.Windows.Forms.Button ShowKeyConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox SetupGroup;
        private System.Windows.Forms.PictureBox KeyConfigStatus;
        private System.Windows.Forms.PictureBox PHPStatus;
    }
}

