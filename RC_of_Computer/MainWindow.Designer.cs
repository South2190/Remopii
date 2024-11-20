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
            this.Server_button = new System.Windows.Forms.Button();
            this.PHP_button = new System.Windows.Forms.Button();
            this.keyconfig_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
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
            // Server_button
            // 
            this.Server_button.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Server_button.Location = new System.Drawing.Point(8, 198);
            this.Server_button.Name = "Server_button";
            this.Server_button.Size = new System.Drawing.Size(297, 92);
            this.Server_button.TabIndex = 60;
            this.Server_button.Text = "サーバースタート";
            this.Server_button.UseVisualStyleBackColor = true;
            this.Server_button.Click += new System.EventHandler(this.Server_button_Click);
            // 
            // PHP_button
            // 
            this.PHP_button.Font = new System.Drawing.Font("Meiryo UI", 15F);
            this.PHP_button.Location = new System.Drawing.Point(6, 28);
            this.PHP_button.Name = "PHP_button";
            this.PHP_button.Size = new System.Drawing.Size(223, 44);
            this.PHP_button.TabIndex = 50;
            this.PHP_button.Text = "PHPのセットアップ...";
            this.PHP_button.UseVisualStyleBackColor = true;
            this.PHP_button.Click += new System.EventHandler(this.PHP_button_Click);
            // 
            // keyconfig_button
            // 
            this.keyconfig_button.Font = new System.Drawing.Font("Meiryo UI", 15F);
            this.keyconfig_button.Location = new System.Drawing.Point(6, 78);
            this.keyconfig_button.Name = "keyconfig_button";
            this.keyconfig_button.Size = new System.Drawing.Size(283, 44);
            this.keyconfig_button.TabIndex = 55;
            this.keyconfig_button.Text = "キーコンフィグ...";
            this.keyconfig_button.UseVisualStyleBackColor = true;
            this.keyconfig_button.Click += new System.EventHandler(this.keyconfig_button_Click);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PHP_button);
            this.groupBox1.Controls.Add(this.keyconfig_button);
            this.groupBox1.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(10, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "① セットアップ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(314, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Server_button);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Server_button;
        private System.Windows.Forms.Button PHP_button;
        private System.Windows.Forms.Button keyconfig_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

