namespace SampleModel
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbX = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDn = new System.Windows.Forms.Button();
            this.chMainPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbY = new System.Windows.Forms.Label();
            this.lbYCaption = new System.Windows.Forms.Label();
            this.tmModel = new System.Windows.Forms.Timer(this.components);
            this.btnX1 = new System.Windows.Forms.Button();
            this.btnX10 = new System.Windows.Forms.Button();
            this.btnDn2 = new System.Windows.Forms.Button();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSPDn = new System.Windows.Forms.Button();
            this.btnSPUp = new System.Windows.Forms.Button();
            this.tbSetpoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKDn = new System.Windows.Forms.Button();
            this.btnKUp = new System.Windows.Forms.Button();
            this.tbK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTiDn = new System.Windows.Forms.Button();
            this.btnTiUp = new System.Windows.Forms.Button();
            this.tbTi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTdDn = new System.Windows.Forms.Button();
            this.btnTdUp = new System.Windows.Forms.Button();
            this.tbTd = new System.Windows.Forms.TextBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(949, 636);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(868, 636);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(277, 49);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(63, 22);
            this.tbX.TabIndex = 2;
            this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(347, 50);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(27, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = ">";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDn
            // 
            this.btnDn.Location = new System.Drawing.Point(244, 49);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(27, 23);
            this.btnDn.TabIndex = 4;
            this.btnDn.Text = "<";
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // chMainPlot
            // 
            this.chMainPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "chMainArea";
            this.chMainPlot.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chMainPlot.Legends.Add(legend6);
            this.chMainPlot.Location = new System.Drawing.Point(12, 258);
            this.chMainPlot.Name = "chMainPlot";
            series21.ChartArea = "chMainArea";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.LegendText = "Y";
            series21.Name = "seriesY";
            series22.ChartArea = "chMainArea";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Legend = "Legend1";
            series22.LegendText = "X1";
            series22.Name = "seriesX";
            series23.ChartArea = "chMainArea";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.LegendText = "X2";
            series23.Name = "seriesX2";
            series24.ChartArea = "chMainArea";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.LegendText = "U";
            series24.Name = "SeriesU";
            this.chMainPlot.Series.Add(series21);
            this.chMainPlot.Series.Add(series22);
            this.chMainPlot.Series.Add(series23);
            this.chMainPlot.Series.Add(series24);
            this.chMainPlot.Size = new System.Drawing.Size(1012, 372);
            this.chMainPlot.TabIndex = 5;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(944, 57);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(24, 16);
            this.lbY.TabIndex = 7;
            this.lbY.Text = "0.0";
            // 
            // lbYCaption
            // 
            this.lbYCaption.AutoSize = true;
            this.lbYCaption.Location = new System.Drawing.Point(919, 57);
            this.lbYCaption.Name = "lbYCaption";
            this.lbYCaption.Size = new System.Drawing.Size(19, 16);
            this.lbYCaption.TabIndex = 8;
            this.lbYCaption.Text = "Y:";
            this.lbYCaption.Click += new System.EventHandler(this.lbYCaption_Click);
            // 
            // tmModel
            // 
            this.tmModel.Interval = 1000;
            this.tmModel.Tick += new System.EventHandler(this.tmModel_Tick);
            // 
            // btnX1
            // 
            this.btnX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnX1.Location = new System.Drawing.Point(12, 636);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(75, 23);
            this.btnX1.TabIndex = 9;
            this.btnX1.Text = "x1";
            this.btnX1.UseVisualStyleBackColor = true;
            this.btnX1.Click += new System.EventHandler(this.btnX1_Click);
            // 
            // btnX10
            // 
            this.btnX10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnX10.Location = new System.Drawing.Point(93, 636);
            this.btnX10.Name = "btnX10";
            this.btnX10.Size = new System.Drawing.Size(75, 23);
            this.btnX10.TabIndex = 10;
            this.btnX10.Text = "x10";
            this.btnX10.UseVisualStyleBackColor = true;
            this.btnX10.Click += new System.EventHandler(this.btnX10_Click);
            // 
            // btnDn2
            // 
            this.btnDn2.Location = new System.Drawing.Point(244, 118);
            this.btnDn2.Name = "btnDn2";
            this.btnDn2.Size = new System.Drawing.Size(27, 23);
            this.btnDn2.TabIndex = 14;
            this.btnDn2.Text = "<";
            this.btnDn2.UseVisualStyleBackColor = true;
            this.btnDn2.Click += new System.EventHandler(this.btnDn2_Click);
            // 
            // btnUp2
            // 
            this.btnUp2.Location = new System.Drawing.Point(347, 117);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(27, 23);
            this.btnUp2.TabIndex = 13;
            this.btnUp2.Text = ">";
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(277, 118);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(63, 22);
            this.tbX2.TabIndex = 12;
            this.tbX2.TextChanged += new System.EventHandler(this.tbX2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Xin1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Xin2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "SetPoint";
            // 
            // btnSPDn
            // 
            this.btnSPDn.Location = new System.Drawing.Point(19, 35);
            this.btnSPDn.Name = "btnSPDn";
            this.btnSPDn.Size = new System.Drawing.Size(27, 23);
            this.btnSPDn.TabIndex = 19;
            this.btnSPDn.Text = "<";
            this.btnSPDn.UseVisualStyleBackColor = true;
            this.btnSPDn.Click += new System.EventHandler(this.btnSPDn_Click);
            // 
            // btnSPUp
            // 
            this.btnSPUp.Location = new System.Drawing.Point(122, 36);
            this.btnSPUp.Name = "btnSPUp";
            this.btnSPUp.Size = new System.Drawing.Size(27, 23);
            this.btnSPUp.TabIndex = 18;
            this.btnSPUp.Text = ">";
            this.btnSPUp.UseVisualStyleBackColor = true;
            this.btnSPUp.Click += new System.EventHandler(this.btnSPUp_Click);
            // 
            // tbSetpoint
            // 
            this.tbSetpoint.Location = new System.Drawing.Point(52, 35);
            this.tbSetpoint.Name = "tbSetpoint";
            this.tbSetpoint.Size = new System.Drawing.Size(63, 22);
            this.tbSetpoint.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "K";
            // 
            // btnKDn
            // 
            this.btnKDn.Location = new System.Drawing.Point(19, 95);
            this.btnKDn.Name = "btnKDn";
            this.btnKDn.Size = new System.Drawing.Size(27, 23);
            this.btnKDn.TabIndex = 23;
            this.btnKDn.Text = "<";
            this.btnKDn.UseVisualStyleBackColor = true;
            this.btnKDn.Click += new System.EventHandler(this.btnKDn_Click);
            // 
            // btnKUp
            // 
            this.btnKUp.Location = new System.Drawing.Point(122, 96);
            this.btnKUp.Name = "btnKUp";
            this.btnKUp.Size = new System.Drawing.Size(27, 23);
            this.btnKUp.TabIndex = 22;
            this.btnKUp.Text = ">";
            this.btnKUp.UseVisualStyleBackColor = true;
            this.btnKUp.Click += new System.EventHandler(this.btnKUp_Click);
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(52, 95);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(63, 22);
            this.tbK.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ti";
            // 
            // btnTiDn
            // 
            this.btnTiDn.Location = new System.Drawing.Point(19, 152);
            this.btnTiDn.Name = "btnTiDn";
            this.btnTiDn.Size = new System.Drawing.Size(27, 23);
            this.btnTiDn.TabIndex = 27;
            this.btnTiDn.Text = "<";
            this.btnTiDn.UseVisualStyleBackColor = true;
            this.btnTiDn.Click += new System.EventHandler(this.btnTiDn_Click);
            // 
            // btnTiUp
            // 
            this.btnTiUp.Location = new System.Drawing.Point(122, 153);
            this.btnTiUp.Name = "btnTiUp";
            this.btnTiUp.Size = new System.Drawing.Size(27, 23);
            this.btnTiUp.TabIndex = 26;
            this.btnTiUp.Text = ">";
            this.btnTiUp.UseVisualStyleBackColor = true;
            this.btnTiUp.Click += new System.EventHandler(this.btnTiUp_Click);
            // 
            // tbTi
            // 
            this.tbTi.Location = new System.Drawing.Point(52, 152);
            this.tbTi.Name = "tbTi";
            this.tbTi.Size = new System.Drawing.Size(63, 22);
            this.tbTi.TabIndex = 25;
            this.tbTi.TextChanged += new System.EventHandler(this.tbTi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Td";
            // 
            // btnTdDn
            // 
            this.btnTdDn.Location = new System.Drawing.Point(19, 215);
            this.btnTdDn.Name = "btnTdDn";
            this.btnTdDn.Size = new System.Drawing.Size(27, 23);
            this.btnTdDn.TabIndex = 31;
            this.btnTdDn.Text = "<";
            this.btnTdDn.UseVisualStyleBackColor = true;
            this.btnTdDn.Click += new System.EventHandler(this.btnTdDn_Click);
            // 
            // btnTdUp
            // 
            this.btnTdUp.Location = new System.Drawing.Point(122, 216);
            this.btnTdUp.Name = "btnTdUp";
            this.btnTdUp.Size = new System.Drawing.Size(27, 23);
            this.btnTdUp.TabIndex = 30;
            this.btnTdUp.Text = ">";
            this.btnTdUp.UseVisualStyleBackColor = true;
            this.btnTdUp.Click += new System.EventHandler(this.btnTdUp_Click);
            // 
            // tbTd
            // 
            this.tbTd.Location = new System.Drawing.Point(52, 215);
            this.tbTd.Name = "tbTd";
            this.tbTd.Size = new System.Drawing.Size(63, 22);
            this.tbTd.TabIndex = 29;
            this.tbTd.TextChanged += new System.EventHandler(this.tbTd_TextChanged);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(244, 214);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(130, 23);
            this.btnAuto.TabIndex = 33;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Xout1:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 22);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(451, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 267);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTdDn);
            this.Controls.Add(this.btnTdUp);
            this.Controls.Add(this.tbTd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTiDn);
            this.Controls.Add(this.btnTiUp);
            this.Controls.Add(this.tbTi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKDn);
            this.Controls.Add(this.btnKUp);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSPDn);
            this.Controls.Add(this.btnSPUp);
            this.Controls.Add(this.tbSetpoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDn2);
            this.Controls.Add(this.btnUp2);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.btnX10);
            this.Controls.Add(this.btnX1);
            this.Controls.Add(this.lbYCaption);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.chMainPlot);
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Name = "MainForm";
            this.Text = "Sample model";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMainPlot;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbYCaption;
        private System.Windows.Forms.Timer tmModel;
        private System.Windows.Forms.Button btnX1;
        private System.Windows.Forms.Button btnX10;
        private System.Windows.Forms.Button btnDn2;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSPDn;
        private System.Windows.Forms.Button btnSPUp;
        private System.Windows.Forms.TextBox tbSetpoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKDn;
        private System.Windows.Forms.Button btnKUp;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTiDn;
        private System.Windows.Forms.Button btnTiUp;
        private System.Windows.Forms.TextBox tbTi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTdDn;
        private System.Windows.Forms.Button btnTdUp;
        private System.Windows.Forms.TextBox tbTd;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

