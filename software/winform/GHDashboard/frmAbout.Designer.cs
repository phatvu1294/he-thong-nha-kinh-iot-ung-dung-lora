namespace GHDashboard
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.tlpAbout = new System.Windows.Forms.TableLayoutPanel();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pnlSeparate = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.tlpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.tlpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAbout
            // 
            this.tlpAbout.ColumnCount = 4;
            this.tlpAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpAbout.Controls.Add(this.picAbout, 1, 1);
            this.tlpAbout.Controls.Add(this.tlpInfo, 2, 1);
            this.tlpAbout.Controls.Add(this.btnOK, 3, 3);
            this.tlpAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAbout.Location = new System.Drawing.Point(0, 0);
            this.tlpAbout.Name = "tlpAbout";
            this.tlpAbout.RowCount = 4;
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAbout.Size = new System.Drawing.Size(288, 164);
            this.tlpAbout.TabIndex = 0;
            this.tlpAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // picAbout
            // 
            this.picAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAbout.Image = global::GHDashboard.Properties.Resources.icon;
            this.picAbout.Location = new System.Drawing.Point(12, 12);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(32, 32);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAbout.TabIndex = 0;
            this.picAbout.TabStop = false;
            this.picAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 1;
            this.tlpAbout.SetColumnSpan(this.tlpInfo, 2);
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Controls.Add(this.lblDetail, 0, 3);
            this.tlpInfo.Controls.Add(this.lblAbout, 0, 0);
            this.tlpInfo.Controls.Add(this.pnlSeparate, 0, 1);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(50, 12);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 4;
            this.tlpAbout.SetRowSpan(this.tlpInfo, 2);
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Size = new System.Drawing.Size(235, 117);
            this.tlpInfo.TabIndex = 1;
            this.tlpInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetail.Location = new System.Drawing.Point(3, 60);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(229, 57);
            this.lblDetail.TabIndex = 2;
            this.lblDetail.Text = "GH Dashboard là phần mềm được thiết kế dành riêng cho mô hình hệ thống nhà lưới I" +
    "OT và đang được phát triển bởi Vũ Phát.";
            this.lblDetail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAbout.Location = new System.Drawing.Point(3, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(229, 48);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "GH Dashboard\r\nPhiên bản 1.0\r\nBản quyền © 2018 bởi Vũ Phát";
            this.lblAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // pnlSeparate
            // 
            this.pnlSeparate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeparate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeparate.Location = new System.Drawing.Point(3, 51);
            this.pnlSeparate.Name = "pnlSeparate";
            this.pnlSeparate.Size = new System.Drawing.Size(229, 1);
            this.pnlSeparate.TabIndex = 1;
            this.pnlSeparate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Location = new System.Drawing.Point(191, 135);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 26);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 164);
            this.Controls.Add(this.tlpAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin GH Dashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.tlpAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAbout;
        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Panel pnlSeparate;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Button btnOK;
    }
}