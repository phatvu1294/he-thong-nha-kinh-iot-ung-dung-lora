namespace GHDashboard
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.tlpSplash = new System.Windows.Forms.TableLayoutPanel();
            this.tlpStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pgbLoading = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.tlpSplash.SuspendLayout();
            this.tlpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSplash
            // 
            this.tlpSplash.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tlpSplash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tlpSplash.BackgroundImage")));
            this.tlpSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tlpSplash.ColumnCount = 1;
            this.tlpSplash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSplash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSplash.Controls.Add(this.tlpStatus, 0, 1);
            this.tlpSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSplash.Location = new System.Drawing.Point(0, 0);
            this.tlpSplash.Name = "tlpSplash";
            this.tlpSplash.RowCount = 2;
            this.tlpSplash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSplash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpSplash.Size = new System.Drawing.Size(400, 300);
            this.tlpSplash.TabIndex = 0;
            // 
            // tlpStatus
            // 
            this.tlpStatus.ColumnCount = 2;
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpStatus.Controls.Add(this.lblCopyright, 0, 1);
            this.tlpStatus.Controls.Add(this.lblTitle, 0, 0);
            this.tlpStatus.Controls.Add(this.pgbLoading, 1, 1);
            this.tlpStatus.Controls.Add(this.lblLoading, 1, 0);
            this.tlpStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStatus.Location = new System.Drawing.Point(3, 243);
            this.tlpStatus.Name = "tlpStatus";
            this.tlpStatus.RowCount = 2;
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatus.Size = new System.Drawing.Size(394, 54);
            this.tlpStatus.TabIndex = 0;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCopyright.Location = new System.Drawing.Point(3, 27);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(230, 27);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Bản quyền © 2018 bởi Vũ Phát";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 27);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "GH Dashboard 1.0";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pgbLoading
            // 
            this.pgbLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbLoading.Location = new System.Drawing.Point(239, 30);
            this.pgbLoading.MarqueeAnimationSpeed = 10;
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.Size = new System.Drawing.Size(152, 21);
            this.pgbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgbLoading.TabIndex = 0;
            // 
            // lblLoading
            // 
            this.lblLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLoading.Location = new System.Drawing.Point(239, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(152, 27);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Đang kết nối tới MQTT...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.ControlBox = false;
            this.Controls.Add(this.tlpSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tlpSplash.ResumeLayout(false);
            this.tlpStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSplash;
        private System.Windows.Forms.TableLayoutPanel tlpStatus;
        private System.Windows.Forms.ProgressBar pgbLoading;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblTitle;
    }
}