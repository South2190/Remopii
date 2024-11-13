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
            this.task_button = new System.Windows.Forms.Button();
            this.PHP_button = new System.Windows.Forms.Button();
            this.keyconfig_button = new System.Windows.Forms.Button();
            this.setup_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Server_button
            // 
            this.Server_button.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Server_button.Location = new System.Drawing.Point(13, 28);
            this.Server_button.Margin = new System.Windows.Forms.Padding(4);
            this.Server_button.Name = "Server_button";
            this.Server_button.Size = new System.Drawing.Size(371, 115);
            this.Server_button.TabIndex = 1;
            this.Server_button.Text = "サーバースタート";
            this.Server_button.UseVisualStyleBackColor = true;
            this.Server_button.Click += new System.EventHandler(this.Server_button_Click);
            // 
            // setup_Box
            // 
            this.setup_Box.Controls.Add(this.task_button);
            this.setup_Box.Controls.Add(this.PHP_button);
            this.setup_Box.Location = new System.Drawing.Point(13, 151);
            this.setup_Box.Margin = new System.Windows.Forms.Padding(4);
            this.setup_Box.Name = "setup_Box";
            this.setup_Box.Padding = new System.Windows.Forms.Padding(4);
            this.setup_Box.Size = new System.Drawing.Size(191, 121);
            this.setup_Box.TabIndex = 2;
            this.setup_Box.TabStop = false;
            this.setup_Box.Text = "セットアップ";
            this.setup_Box.Enter += new System.EventHandler(this.setup_Box_Enter);
            // 
            // task_button
            // 
            this.task_button.Location = new System.Drawing.Point(8, 69);
            this.task_button.Margin = new System.Windows.Forms.Padding(4);
            this.task_button.Name = "task_button";
            this.task_button.Size = new System.Drawing.Size(121, 39);
            this.task_button.TabIndex = 0;
            this.task_button.Text = "タスクスケジューラ";
            this.task_button.UseVisualStyleBackColor = true;
            // 
            // PHP_button
            // 
            this.PHP_button.Location = new System.Drawing.Point(8, 22);
            this.PHP_button.Margin = new System.Windows.Forms.Padding(4);
            this.PHP_button.Name = "PHP_button";
            this.PHP_button.Size = new System.Drawing.Size(121, 39);
            this.PHP_button.TabIndex = 0;
            this.PHP_button.Text = "PHP";
            this.PHP_button.UseVisualStyleBackColor = true;
            this.PHP_button.Click += new System.EventHandler(this.PHP_button_Click);
            // 
            // keyconfig_button
            // 
            this.keyconfig_button.Font = new System.Drawing.Font("Meiryo UI", 15F);
            this.keyconfig_button.Location = new System.Drawing.Point(212, 157);
            this.keyconfig_button.Margin = new System.Windows.Forms.Padding(4);
            this.keyconfig_button.Name = "keyconfig_button";
            this.keyconfig_button.Size = new System.Drawing.Size(172, 55);
            this.keyconfig_button.TabIndex = 3;
            this.keyconfig_button.Text = "キーコンフィグ";
            this.keyconfig_button.UseVisualStyleBackColor = true;
            this.keyconfig_button.Click += new System.EventHandler(this.keyconfig_button_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(393, 281);
            this.Controls.Add(this.keyconfig_button);
            this.Controls.Add(this.setup_Box);
            this.Controls.Add(this.Server_button);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.setup_Box.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Server_button;
        private System.Windows.Forms.GroupBox setup_Box;
        private System.Windows.Forms.Button task_button;
        private System.Windows.Forms.Button PHP_button;
        private System.Windows.Forms.Button keyconfig_button;
    }
}

