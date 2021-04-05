namespace GHDashboard
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbxControl = new System.Windows.Forms.GroupBox();
            this.tlpControl = new System.Windows.Forms.TableLayoutPanel();
            this.chkOnoff4 = new System.Windows.Forms.CheckBox();
            this.chkOnoff3 = new System.Windows.Forms.CheckBox();
            this.lblOnoff4Title = new System.Windows.Forms.Label();
            this.lblOnoff1Title = new System.Windows.Forms.Label();
            this.lblOnoff2Title = new System.Windows.Forms.Label();
            this.lblOnoff3Title = new System.Windows.Forms.Label();
            this.chkOnoff1 = new System.Windows.Forms.CheckBox();
            this.chkOnoff2 = new System.Windows.Forms.CheckBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tplMonitoring = new System.Windows.Forms.TableLayoutPanel();
            this.lblLightTitle = new System.Windows.Forms.Label();
            this.lblTempTitle = new System.Windows.Forms.Label();
            this.lblCO2Title = new System.Windows.Forms.Label();
            this.lblCO2 = new System.Windows.Forms.Label();
            this.lblLight = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.gaeTemp = new System.Windows.Forms.AGauge();
            this.gaeLight = new System.Windows.Forms.AGauge();
            this.gaeCO2 = new System.Windows.Forms.AGauge();
            this.gbxTemp = new System.Windows.Forms.GroupBox();
            this.chtTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxLight = new System.Windows.Forms.GroupBox();
            this.tlpLight = new System.Windows.Forms.TableLayoutPanel();
            this.lblLightBeforeTitle = new System.Windows.Forms.Label();
            this.lblLightBefore = new System.Windows.Forms.Label();
            this.lblLightAfterTitle = new System.Windows.Forms.Label();
            this.lblLightAfter = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MainMenu(this.components);
            this.mniLog = new System.Windows.Forms.MenuItem();
            this.mniHelp = new System.Windows.Forms.MenuItem();
            this.mniAbout = new System.Windows.Forms.MenuItem();
            this.gbxControl.SuspendLayout();
            this.tlpControl.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tplMonitoring.SuspendLayout();
            this.gbxTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTemp)).BeginInit();
            this.gbxLight.SuspendLayout();
            this.tlpLight.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxControl
            // 
            this.gbxControl.Controls.Add(this.tlpControl);
            this.gbxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxControl.Location = new System.Drawing.Point(3, 533);
            this.gbxControl.Name = "gbxControl";
            this.gbxControl.Size = new System.Drawing.Size(702, 89);
            this.gbxControl.TabIndex = 1;
            this.gbxControl.TabStop = false;
            this.gbxControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // tlpControl
            // 
            this.tlpControl.ColumnCount = 5;
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControl.Controls.Add(this.chkOnoff4, 4, 1);
            this.tlpControl.Controls.Add(this.chkOnoff3, 4, 0);
            this.tlpControl.Controls.Add(this.lblOnoff4Title, 3, 1);
            this.tlpControl.Controls.Add(this.lblOnoff1Title, 0, 0);
            this.tlpControl.Controls.Add(this.lblOnoff2Title, 0, 1);
            this.tlpControl.Controls.Add(this.lblOnoff3Title, 3, 0);
            this.tlpControl.Controls.Add(this.chkOnoff1, 1, 0);
            this.tlpControl.Controls.Add(this.chkOnoff2, 1, 1);
            this.tlpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControl.Location = new System.Drawing.Point(3, 16);
            this.tlpControl.Name = "tlpControl";
            this.tlpControl.RowCount = 2;
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControl.Size = new System.Drawing.Size(696, 70);
            this.tlpControl.TabIndex = 2;
            this.tlpControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // chkOnoff4
            // 
            this.chkOnoff4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOnoff4.AutoSize = true;
            this.chkOnoff4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkOnoff4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnoff4.Location = new System.Drawing.Point(501, 38);
            this.chkOnoff4.Name = "chkOnoff4";
            this.chkOnoff4.Size = new System.Drawing.Size(192, 29);
            this.chkOnoff4.TabIndex = 27;
            this.chkOnoff4.Text = "Bật";
            this.chkOnoff4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOnoff4.UseVisualStyleBackColor = true;
            this.chkOnoff4.Click += new System.EventHandler(this.chkOnoff4_Click);
            // 
            // chkOnoff3
            // 
            this.chkOnoff3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOnoff3.AutoSize = true;
            this.chkOnoff3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkOnoff3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnoff3.Location = new System.Drawing.Point(501, 3);
            this.chkOnoff3.Name = "chkOnoff3";
            this.chkOnoff3.Size = new System.Drawing.Size(192, 29);
            this.chkOnoff3.TabIndex = 26;
            this.chkOnoff3.Text = "Bật";
            this.chkOnoff3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOnoff3.UseVisualStyleBackColor = true;
            this.chkOnoff3.Click += new System.EventHandler(this.chkOnoff3_Click);
            // 
            // lblOnoff4Title
            // 
            this.lblOnoff4Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOnoff4Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnoff4Title.Location = new System.Drawing.Point(401, 35);
            this.lblOnoff4Title.Name = "lblOnoff4Title";
            this.lblOnoff4Title.Size = new System.Drawing.Size(94, 35);
            this.lblOnoff4Title.TabIndex = 23;
            this.lblOnoff4Title.Text = "Thiết bị 4";
            this.lblOnoff4Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOnoff1Title
            // 
            this.lblOnoff1Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOnoff1Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnoff1Title.Location = new System.Drawing.Point(3, 0);
            this.lblOnoff1Title.Name = "lblOnoff1Title";
            this.lblOnoff1Title.Size = new System.Drawing.Size(94, 35);
            this.lblOnoff1Title.TabIndex = 3;
            this.lblOnoff1Title.Text = "Thiết bị 1";
            this.lblOnoff1Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOnoff1Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblOnoff2Title
            // 
            this.lblOnoff2Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOnoff2Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnoff2Title.Location = new System.Drawing.Point(3, 35);
            this.lblOnoff2Title.Name = "lblOnoff2Title";
            this.lblOnoff2Title.Size = new System.Drawing.Size(94, 35);
            this.lblOnoff2Title.TabIndex = 4;
            this.lblOnoff2Title.Text = "Thiết bị 2";
            this.lblOnoff2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOnoff2Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblOnoff3Title
            // 
            this.lblOnoff3Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOnoff3Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnoff3Title.Location = new System.Drawing.Point(401, 0);
            this.lblOnoff3Title.Name = "lblOnoff3Title";
            this.lblOnoff3Title.Size = new System.Drawing.Size(94, 35);
            this.lblOnoff3Title.TabIndex = 5;
            this.lblOnoff3Title.Text = "Thiết bị 3";
            this.lblOnoff3Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOnoff3Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // chkOnoff1
            // 
            this.chkOnoff1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOnoff1.AutoSize = true;
            this.chkOnoff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkOnoff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnoff1.Location = new System.Drawing.Point(103, 3);
            this.chkOnoff1.Name = "chkOnoff1";
            this.chkOnoff1.Size = new System.Drawing.Size(192, 29);
            this.chkOnoff1.TabIndex = 21;
            this.chkOnoff1.Text = "Bật";
            this.chkOnoff1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOnoff1.UseVisualStyleBackColor = true;
            this.chkOnoff1.Click += new System.EventHandler(this.chkOnoff1_Click);
            // 
            // chkOnoff2
            // 
            this.chkOnoff2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOnoff2.AutoSize = true;
            this.chkOnoff2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkOnoff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnoff2.Location = new System.Drawing.Point(103, 38);
            this.chkOnoff2.Name = "chkOnoff2";
            this.chkOnoff2.Size = new System.Drawing.Size(192, 29);
            this.chkOnoff2.TabIndex = 22;
            this.chkOnoff2.Text = "Bật";
            this.chkOnoff2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOnoff2.UseVisualStyleBackColor = true;
            this.chkOnoff2.Click += new System.EventHandler(this.chkOnoff2_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gbxControl, 0, 3);
            this.tlpMain.Controls.Add(this.tplMonitoring, 0, 0);
            this.tlpMain.Controls.Add(this.gbxTemp, 0, 2);
            this.tlpMain.Controls.Add(this.gbxLight, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(3, 3);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMain.Size = new System.Drawing.Size(708, 625);
            this.tlpMain.TabIndex = 2;
            this.tlpMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // tplMonitoring
            // 
            this.tplMonitoring.ColumnCount = 7;
            this.tplMonitoring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tplMonitoring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tplMonitoring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tplMonitoring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tplMonitoring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tplMonitoring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tplMonitoring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tplMonitoring.Controls.Add(this.lblLightTitle, 5, 0);
            this.tplMonitoring.Controls.Add(this.lblTempTitle, 3, 0);
            this.tplMonitoring.Controls.Add(this.lblCO2Title, 1, 0);
            this.tplMonitoring.Controls.Add(this.lblCO2, 1, 2);
            this.tplMonitoring.Controls.Add(this.lblLight, 5, 2);
            this.tplMonitoring.Controls.Add(this.lblTemp, 3, 2);
            this.tplMonitoring.Controls.Add(this.gaeTemp, 3, 1);
            this.tplMonitoring.Controls.Add(this.gaeLight, 5, 1);
            this.tplMonitoring.Controls.Add(this.gaeCO2, 1, 1);
            this.tplMonitoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplMonitoring.Location = new System.Drawing.Point(3, 3);
            this.tplMonitoring.Name = "tplMonitoring";
            this.tplMonitoring.RowCount = 3;
            this.tplMonitoring.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tplMonitoring.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplMonitoring.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplMonitoring.Size = new System.Drawing.Size(702, 244);
            this.tplMonitoring.TabIndex = 2;
            this.tplMonitoring.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblLightTitle
            // 
            this.lblLightTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLightTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLightTitle.Location = new System.Drawing.Point(482, 0);
            this.lblLightTitle.Name = "lblLightTitle";
            this.lblLightTitle.Size = new System.Drawing.Size(204, 30);
            this.lblLightTitle.TabIndex = 15;
            this.lblLightTitle.Text = "Độ xuyên sáng";
            this.lblLightTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLightTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblTempTitle
            // 
            this.lblTempTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTempTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempTitle.Location = new System.Drawing.Point(259, 0);
            this.lblTempTitle.Name = "lblTempTitle";
            this.lblTempTitle.Size = new System.Drawing.Size(204, 30);
            this.lblTempTitle.TabIndex = 14;
            this.lblTempTitle.Text = "Nhiệt độ";
            this.lblTempTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTempTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblCO2Title
            // 
            this.lblCO2Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCO2Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCO2Title.Location = new System.Drawing.Point(16, 0);
            this.lblCO2Title.Name = "lblCO2Title";
            this.lblCO2Title.Size = new System.Drawing.Size(224, 30);
            this.lblCO2Title.TabIndex = 13;
            this.lblCO2Title.Text = "Nồng độ CO2";
            this.lblCO2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCO2Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblCO2
            // 
            this.lblCO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCO2.Location = new System.Drawing.Point(16, 224);
            this.lblCO2.Name = "lblCO2";
            this.lblCO2.Size = new System.Drawing.Size(224, 20);
            this.lblCO2.TabIndex = 12;
            this.lblCO2.Text = "0ppm";
            this.lblCO2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLight
            // 
            this.lblLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLight.Location = new System.Drawing.Point(482, 224);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(204, 20);
            this.lblLight.TabIndex = 10;
            this.lblLight.Text = "0%";
            this.lblLight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblTemp
            // 
            this.lblTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(259, 224);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(204, 20);
            this.lblTemp.TabIndex = 9;
            this.lblTemp.Text = "0°C";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // gaeTemp
            // 
            this.gaeTemp.BaseArcColor = System.Drawing.Color.Gray;
            this.gaeTemp.BaseArcRadius = 80;
            this.gaeTemp.BaseArcStart = 135;
            this.gaeTemp.BaseArcSweep = 270;
            this.gaeTemp.BaseArcWidth = 2;
            this.gaeTemp.Center = new System.Drawing.Point(102, 100);
            this.gaeTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaeTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaeTemp.Location = new System.Drawing.Point(259, 33);
            this.gaeTemp.MaxValue = 50F;
            this.gaeTemp.MinValue = 0F;
            this.gaeTemp.Name = "gaeTemp";
            this.gaeTemp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.gaeTemp.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gaeTemp.NeedleRadius = 80;
            this.gaeTemp.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.gaeTemp.NeedleWidth = 2;
            this.gaeTemp.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaeTemp.ScaleLinesInterInnerRadius = 73;
            this.gaeTemp.ScaleLinesInterOuterRadius = 80;
            this.gaeTemp.ScaleLinesInterWidth = 1;
            this.gaeTemp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaeTemp.ScaleLinesMajorInnerRadius = 70;
            this.gaeTemp.ScaleLinesMajorOuterRadius = 80;
            this.gaeTemp.ScaleLinesMajorStepValue = 10F;
            this.gaeTemp.ScaleLinesMajorWidth = 2;
            this.gaeTemp.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gaeTemp.ScaleLinesMinorInnerRadius = 75;
            this.gaeTemp.ScaleLinesMinorOuterRadius = 80;
            this.gaeTemp.ScaleLinesMinorTicks = 9;
            this.gaeTemp.ScaleLinesMinorWidth = 1;
            this.gaeTemp.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaeTemp.ScaleNumbersFormat = null;
            this.gaeTemp.ScaleNumbersRadius = 95;
            this.gaeTemp.ScaleNumbersRotation = 0;
            this.gaeTemp.ScaleNumbersStartScaleLine = 0;
            this.gaeTemp.ScaleNumbersStepScaleLines = 1;
            this.gaeTemp.Size = new System.Drawing.Size(204, 188);
            this.gaeTemp.TabIndex = 0;
            this.gaeTemp.Text = "gaeTemp";
            this.gaeTemp.Value = 0F;
            this.gaeTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // gaeLight
            // 
            this.gaeLight.BaseArcColor = System.Drawing.Color.Gray;
            this.gaeLight.BaseArcRadius = 80;
            this.gaeLight.BaseArcStart = 135;
            this.gaeLight.BaseArcSweep = 270;
            this.gaeLight.BaseArcWidth = 2;
            this.gaeLight.Center = new System.Drawing.Point(102, 100);
            this.gaeLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaeLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaeLight.Location = new System.Drawing.Point(482, 33);
            this.gaeLight.MaxValue = 100F;
            this.gaeLight.MinValue = 0F;
            this.gaeLight.Name = "gaeLight";
            this.gaeLight.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.gaeLight.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gaeLight.NeedleRadius = 80;
            this.gaeLight.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.gaeLight.NeedleWidth = 2;
            this.gaeLight.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaeLight.ScaleLinesInterInnerRadius = 73;
            this.gaeLight.ScaleLinesInterOuterRadius = 80;
            this.gaeLight.ScaleLinesInterWidth = 1;
            this.gaeLight.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaeLight.ScaleLinesMajorInnerRadius = 70;
            this.gaeLight.ScaleLinesMajorOuterRadius = 80;
            this.gaeLight.ScaleLinesMajorStepValue = 20F;
            this.gaeLight.ScaleLinesMajorWidth = 2;
            this.gaeLight.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gaeLight.ScaleLinesMinorInnerRadius = 75;
            this.gaeLight.ScaleLinesMinorOuterRadius = 80;
            this.gaeLight.ScaleLinesMinorTicks = 9;
            this.gaeLight.ScaleLinesMinorWidth = 1;
            this.gaeLight.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaeLight.ScaleNumbersFormat = null;
            this.gaeLight.ScaleNumbersRadius = 95;
            this.gaeLight.ScaleNumbersRotation = 0;
            this.gaeLight.ScaleNumbersStartScaleLine = 0;
            this.gaeLight.ScaleNumbersStepScaleLines = 1;
            this.gaeLight.Size = new System.Drawing.Size(204, 188);
            this.gaeLight.TabIndex = 1;
            this.gaeLight.Text = "gaeLight";
            this.gaeLight.Value = 0F;
            this.gaeLight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // gaeCO2
            // 
            this.gaeCO2.BaseArcColor = System.Drawing.Color.Gray;
            this.gaeCO2.BaseArcRadius = 80;
            this.gaeCO2.BaseArcStart = 135;
            this.gaeCO2.BaseArcSweep = 270;
            this.gaeCO2.BaseArcWidth = 2;
            this.gaeCO2.Center = new System.Drawing.Point(110, 100);
            this.gaeCO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaeCO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaeCO2.Location = new System.Drawing.Point(16, 33);
            this.gaeCO2.MaxValue = 5000F;
            this.gaeCO2.MinValue = 0F;
            this.gaeCO2.Name = "gaeCO2";
            this.gaeCO2.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.gaeCO2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gaeCO2.NeedleRadius = 80;
            this.gaeCO2.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.gaeCO2.NeedleWidth = 2;
            this.gaeCO2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaeCO2.ScaleLinesInterInnerRadius = 73;
            this.gaeCO2.ScaleLinesInterOuterRadius = 80;
            this.gaeCO2.ScaleLinesInterWidth = 1;
            this.gaeCO2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaeCO2.ScaleLinesMajorInnerRadius = 70;
            this.gaeCO2.ScaleLinesMajorOuterRadius = 80;
            this.gaeCO2.ScaleLinesMajorStepValue = 1000F;
            this.gaeCO2.ScaleLinesMajorWidth = 2;
            this.gaeCO2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gaeCO2.ScaleLinesMinorInnerRadius = 75;
            this.gaeCO2.ScaleLinesMinorOuterRadius = 80;
            this.gaeCO2.ScaleLinesMinorTicks = 9;
            this.gaeCO2.ScaleLinesMinorWidth = 1;
            this.gaeCO2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaeCO2.ScaleNumbersFormat = null;
            this.gaeCO2.ScaleNumbersRadius = 95;
            this.gaeCO2.ScaleNumbersRotation = 0;
            this.gaeCO2.ScaleNumbersStartScaleLine = 0;
            this.gaeCO2.ScaleNumbersStepScaleLines = 1;
            this.gaeCO2.Size = new System.Drawing.Size(224, 188);
            this.gaeCO2.TabIndex = 11;
            this.gaeCO2.Text = "gaeCO2";
            this.gaeCO2.Value = 0F;
            this.gaeCO2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // gbxTemp
            // 
            this.gbxTemp.Controls.Add(this.chtTemp);
            this.gbxTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxTemp.Location = new System.Drawing.Point(3, 315);
            this.gbxTemp.Name = "gbxTemp";
            this.gbxTemp.Size = new System.Drawing.Size(702, 212);
            this.gbxTemp.TabIndex = 3;
            this.gbxTemp.TabStop = false;
            this.gbxTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // chtTemp
            // 
            this.chtTemp.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "chaTemp";
            this.chtTemp.ChartAreas.Add(chartArea1);
            this.chtTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "chlTemp";
            this.chtTemp.Legends.Add(legend1);
            this.chtTemp.Location = new System.Drawing.Point(3, 16);
            this.chtTemp.Name = "chtTemp";
            series1.BorderWidth = 3;
            series1.ChartArea = "chaTemp";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "chlTemp";
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "chsTemp";
            series1.YValuesPerPoint = 6;
            this.chtTemp.Series.Add(series1);
            this.chtTemp.Size = new System.Drawing.Size(696, 193);
            this.chtTemp.TabIndex = 4;
            this.chtTemp.Text = "chtTemp";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "chtTemp";
            title1.Text = "Biểu đồ nhiệt độ tại các điểm";
            this.chtTemp.Titles.Add(title1);
            this.chtTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // gbxLight
            // 
            this.gbxLight.Controls.Add(this.tlpLight);
            this.gbxLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxLight.Location = new System.Drawing.Point(3, 253);
            this.gbxLight.Name = "gbxLight";
            this.gbxLight.Size = new System.Drawing.Size(702, 56);
            this.gbxLight.TabIndex = 4;
            this.gbxLight.TabStop = false;
            this.gbxLight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // tlpLight
            // 
            this.tlpLight.ColumnCount = 6;
            this.tlpLight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpLight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpLight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpLight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpLight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpLight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpLight.Controls.Add(this.lblLightBeforeTitle, 1, 0);
            this.tlpLight.Controls.Add(this.lblLightBefore, 2, 0);
            this.tlpLight.Controls.Add(this.lblLightAfterTitle, 4, 0);
            this.tlpLight.Controls.Add(this.lblLightAfter, 5, 0);
            this.tlpLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLight.Location = new System.Drawing.Point(3, 16);
            this.tlpLight.Name = "tlpLight";
            this.tlpLight.RowCount = 1;
            this.tlpLight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLight.Size = new System.Drawing.Size(696, 37);
            this.tlpLight.TabIndex = 0;
            this.tlpLight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblLightBeforeTitle
            // 
            this.lblLightBeforeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLightBeforeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLightBeforeTitle.Location = new System.Drawing.Point(53, 0);
            this.lblLightBeforeTitle.Name = "lblLightBeforeTitle";
            this.lblLightBeforeTitle.Size = new System.Drawing.Size(184, 37);
            this.lblLightBeforeTitle.TabIndex = 0;
            this.lblLightBeforeTitle.Text = "Cường độ sáng chưa qua lưới:";
            this.lblLightBeforeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLightBeforeTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblLightBefore
            // 
            this.lblLightBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLightBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLightBefore.Location = new System.Drawing.Point(243, 0);
            this.lblLightBefore.Name = "lblLightBefore";
            this.lblLightBefore.Size = new System.Drawing.Size(101, 37);
            this.lblLightBefore.TabIndex = 1;
            this.lblLightBefore.Text = "0lx";
            this.lblLightBefore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLightBefore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblLightAfterTitle
            // 
            this.lblLightAfterTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLightAfterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLightAfterTitle.Location = new System.Drawing.Point(400, 0);
            this.lblLightAfterTitle.Name = "lblLightAfterTitle";
            this.lblLightAfterTitle.Size = new System.Drawing.Size(172, 37);
            this.lblLightAfterTitle.TabIndex = 2;
            this.lblLightAfterTitle.Text = "Cường độ sáng khi qua lưới:";
            this.lblLightAfterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLightAfterTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblLightAfter
            // 
            this.lblLightAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLightAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLightAfter.Location = new System.Drawing.Point(578, 0);
            this.lblLightAfter.Name = "lblLightAfter";
            this.lblLightAfter.Size = new System.Drawing.Size(115, 37);
            this.lblLightAfter.TabIndex = 3;
            this.lblLightAfter.Text = "0lx";
            this.lblLightAfter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLightAfter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mniLog,
            this.mniHelp});
            // 
            // mniLog
            // 
            this.mniLog.Index = 0;
            this.mniLog.Text = "Nhật ký";
            this.mniLog.Click += new System.EventHandler(this.mnuLog_Click);
            // 
            // mniHelp
            // 
            this.mniHelp.Index = 1;
            this.mniHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mniAbout});
            this.mniHelp.Text = "Trợ giúp";
            // 
            // mniAbout
            // 
            this.mniAbout.Index = 0;
            this.mniAbout.Text = "Thông tin";
            this.mniAbout.Click += new System.EventHandler(this.mniAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(714, 631);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mnuMain;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GH Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.gbxControl.ResumeLayout(false);
            this.tlpControl.ResumeLayout(false);
            this.tlpControl.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tplMonitoring.ResumeLayout(false);
            this.gbxTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtTemp)).EndInit();
            this.gbxLight.ResumeLayout(false);
            this.tlpLight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxControl;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpControl;
        private System.Windows.Forms.TableLayoutPanel tplMonitoring;
        private System.Windows.Forms.AGauge gaeTemp;
        private System.Windows.Forms.AGauge gaeLight;
        private System.Windows.Forms.Label lblLight;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblOnoff1Title;
        private System.Windows.Forms.Label lblOnoff2Title;
        private System.Windows.Forms.Label lblOnoff3Title;
        private System.Windows.Forms.CheckBox chkOnoff1;
        private System.Windows.Forms.CheckBox chkOnoff2;
        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.MenuItem mniLog;
        private System.Windows.Forms.MenuItem mniHelp;
        private System.Windows.Forms.MenuItem mniAbout;
        private System.Windows.Forms.Label lblOnoff4Title;
        private System.Windows.Forms.CheckBox chkOnoff3;
        private System.Windows.Forms.CheckBox chkOnoff4;
        private System.Windows.Forms.AGauge gaeCO2;
        private System.Windows.Forms.Label lblCO2;
        private System.Windows.Forms.GroupBox gbxTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTemp;
        private System.Windows.Forms.Label lblCO2Title;
        private System.Windows.Forms.Label lblLightTitle;
        private System.Windows.Forms.Label lblTempTitle;
        private System.Windows.Forms.GroupBox gbxLight;
        private System.Windows.Forms.TableLayoutPanel tlpLight;
        private System.Windows.Forms.Label lblLightBeforeTitle;
        private System.Windows.Forms.Label lblLightBefore;
        private System.Windows.Forms.Label lblLightAfterTitle;
        private System.Windows.Forms.Label lblLightAfter;
    }
}

