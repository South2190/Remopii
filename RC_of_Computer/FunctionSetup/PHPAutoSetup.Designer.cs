namespace RC_of_Computer.FunctionSetup
{
    partial class PHPAutoSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PHPAutoSetup));
            this.SetupProgress = new System.Windows.Forms.ProgressBar();
            this.StartSetup = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.SetupDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetupProgress
            // 
            this.SetupProgress.Location = new System.Drawing.Point(15, 65);
            this.SetupProgress.Name = "SetupProgress";
            this.SetupProgress.Size = new System.Drawing.Size(400, 20);
            this.SetupProgress.TabIndex = 0;
            // 
            // StartSetup
            // 
            this.StartSetup.Location = new System.Drawing.Point(265, 91);
            this.StartSetup.Name = "StartSetup";
            this.StartSetup.Size = new System.Drawing.Size(150, 25);
            this.StartSetup.TabIndex = 1;
            this.StartSetup.Text = "セットアップを開始";
            this.StartSetup.UseVisualStyleBackColor = true;
            this.StartSetup.Click += new System.EventHandler(this.StartSetup_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(20, 15);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(301, 12);
            this.Description.TabIndex = 2;
            this.Description.Text = "\"セットアップを開始\"を押すとPHPのセットアップが開始されます。";
            // 
            // SetupDetail
            // 
            this.SetupDetail.AutoSize = true;
            this.SetupDetail.Location = new System.Drawing.Point(20, 45);
            this.SetupDetail.Name = "SetupDetail";
            this.SetupDetail.Size = new System.Drawing.Size(64, 12);
            this.SetupDetail.TabIndex = 3;
            this.SetupDetail.Text = "SetupDetail";
            // 
            // PHPAutoSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(429, 126);
            this.Controls.Add(this.SetupDetail);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.StartSetup);
            this.Controls.Add(this.SetupProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PHPAutoSetup";
            this.Text = "PHPの自動セットアップ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PHPAutoSetup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar SetupProgress;
        private System.Windows.Forms.Button StartSetup;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label SetupDetail;
    }
}