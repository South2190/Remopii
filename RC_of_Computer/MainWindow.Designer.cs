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
            this.setup_Box = new System.Windows.Forms.GroupBox();
            this.PHP_button = new System.Windows.Forms.Button();
            this.firewall_button = new System.Windows.Forms.Button();
            this.task_button = new System.Windows.Forms.Button();
            this.keyconfig_button = new System.Windows.Forms.Button();
            this.setup_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Server_button
            // 
            this.Server_button.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Server_button.Location = new System.Drawing.Point(255, 89);
            this.Server_button.Name = "Server_button";
            this.Server_button.Size = new System.Drawing.Size(297, 92);
            this.Server_button.TabIndex = 1;
            this.Server_button.Text = "サーバースタート";
            this.Server_button.UseVisualStyleBackColor = true;
            // 
            // setup_Box
            // 
            this.setup_Box.Controls.Add(this.task_button);
            this.setup_Box.Controls.Add(this.firewall_button);
            this.setup_Box.Controls.Add(this.PHP_button);
            this.setup_Box.Location = new System.Drawing.Point(255, 187);
            this.setup_Box.Name = "setup_Box";
            this.setup_Box.Size = new System.Drawing.Size(153, 131);
            this.setup_Box.TabIndex = 2;
            this.setup_Box.TabStop = false;
            this.setup_Box.Text = "セットアップ";
            this.setup_Box.Enter += new System.EventHandler(this.setup_Box_Enter);
            // 
            // PHP_button
            // 
            this.PHP_button.Location = new System.Drawing.Point(6, 18);
            this.PHP_button.Name = "PHP_button";
            this.PHP_button.Size = new System.Drawing.Size(97, 31);
            this.PHP_button.TabIndex = 0;
            this.PHP_button.Text = "PHP";
            this.PHP_button.UseVisualStyleBackColor = true;
            this.PHP_button.Click += new System.EventHandler(this.PHP_button_Click);
            // 
            // firewall_button
            // 
            this.firewall_button.Location = new System.Drawing.Point(6, 55);
            this.firewall_button.Name = "firewall_button";
            this.firewall_button.Size = new System.Drawing.Size(97, 31);
            this.firewall_button.TabIndex = 0;
            this.firewall_button.Text = "ファイアウォール";
            this.firewall_button.UseVisualStyleBackColor = true;
            // 
            // task_button
            // 
            this.task_button.Location = new System.Drawing.Point(6, 92);
            this.task_button.Name = "task_button";
            this.task_button.Size = new System.Drawing.Size(97, 31);
            this.task_button.TabIndex = 0;
            this.task_button.Text = "タスクスケジューラ";
            this.task_button.UseVisualStyleBackColor = true;
            // 
            // keyconfig_button
            // 
            this.keyconfig_button.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.keyconfig_button.Location = new System.Drawing.Point(414, 192);
            this.keyconfig_button.Name = "keyconfig_button";
            this.keyconfig_button.Size = new System.Drawing.Size(138, 44);
            this.keyconfig_button.TabIndex = 3;
            this.keyconfig_button.Text = "キーコンフィグ";
            this.keyconfig_button.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.keyconfig_button);
            this.Controls.Add(this.setup_Box);
            this.Controls.Add(this.Server_button);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.setup_Box.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Server_button;
        private System.Windows.Forms.GroupBox setup_Box;
        private System.Windows.Forms.Button task_button;
        private System.Windows.Forms.Button firewall_button;
        private System.Windows.Forms.Button PHP_button;
        private System.Windows.Forms.Button keyconfig_button;
    }
}

