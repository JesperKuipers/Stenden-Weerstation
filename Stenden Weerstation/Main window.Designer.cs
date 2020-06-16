using System.Diagnostics.Tracing;
using System.Drawing;

namespace Stenden_Weerstation
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Actueel_Update = new System.Windows.Forms.Label();
            this.Actueel_Wind = new System.Windows.Forms.Label();
            this.Actueel_Luchtvochtigheid = new System.Windows.Forms.Label();
            this.Actueel_Temperatuur = new System.Windows.Forms.Label();
            this.Actueel_weer = new System.Windows.Forms.Label();
            this.Actueel_Plaats = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Title2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Opties_Succeed = new System.Windows.Forms.Label();
            this.Opties_Error = new System.Windows.Forms.Label();
            this.Opties_Interval2 = new System.Windows.Forms.NumericUpDown();
            this.Fahrenheit = new System.Windows.Forms.RadioButton();
            this.Celsius = new System.Windows.Forms.RadioButton();
            this.Opties_Plaats2 = new System.Windows.Forms.TextBox();
            this.Opties_Interval3 = new System.Windows.Forms.Label();
            this.Opties_Weergave = new System.Windows.Forms.Label();
            this.Opties_Interval = new System.Windows.Forms.Label();
            this.Opties_Plaats = new System.Windows.Forms.Label();
            this.Opties_Button = new System.Windows.Forms.Button();
            this.Title3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.huidigeTemperatuurErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verversenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Opties_Interval2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 338);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.Title1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(431, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Actueel";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Actueel_Update);
            this.panel2.Controls.Add(this.Actueel_Wind);
            this.panel2.Controls.Add(this.Actueel_Luchtvochtigheid);
            this.panel2.Controls.Add(this.Actueel_Temperatuur);
            this.panel2.Controls.Add(this.Actueel_weer);
            this.panel2.Controls.Add(this.Actueel_Plaats);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(35, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 228);
            this.panel2.TabIndex = 3;
            // 
            // Actueel_Update
            // 
            this.Actueel_Update.AutoSize = true;
            this.Actueel_Update.Location = new System.Drawing.Point(230, 211);
            this.Actueel_Update.Name = "Actueel_Update";
            this.Actueel_Update.Size = new System.Drawing.Size(122, 13);
            this.Actueel_Update.TabIndex = 6;
            this.Actueel_Update.Text = "(laatste update: 9:53:13)";
            // 
            // Actueel_Wind
            // 
            this.Actueel_Wind.AutoSize = true;
            this.Actueel_Wind.Location = new System.Drawing.Point(26, 178);
            this.Actueel_Wind.Name = "Actueel_Wind";
            this.Actueel_Wind.Size = new System.Drawing.Size(117, 13);
            this.Actueel_Wind.TabIndex = 5;
            this.Actueel_Wind.Text = "Wind: NO met 18 km/h";
            // 
            // Actueel_Luchtvochtigheid
            // 
            this.Actueel_Luchtvochtigheid.AutoSize = true;
            this.Actueel_Luchtvochtigheid.Location = new System.Drawing.Point(26, 144);
            this.Actueel_Luchtvochtigheid.Name = "Actueel_Luchtvochtigheid";
            this.Actueel_Luchtvochtigheid.Size = new System.Drawing.Size(115, 13);
            this.Actueel_Luchtvochtigheid.TabIndex = 4;
            this.Actueel_Luchtvochtigheid.Text = "Luchtvochtigheid: 90%";
            // 
            // Actueel_Temperatuur
            // 
            this.Actueel_Temperatuur.AutoSize = true;
            this.Actueel_Temperatuur.Location = new System.Drawing.Point(26, 110);
            this.Actueel_Temperatuur.Name = "Actueel_Temperatuur";
            this.Actueel_Temperatuur.Size = new System.Drawing.Size(86, 13);
            this.Actueel_Temperatuur.TabIndex = 3;
            this.Actueel_Temperatuur.Text = "Temperatuur: 7C";
            // 
            // Actueel_weer
            // 
            this.Actueel_weer.AutoSize = true;
            this.Actueel_weer.Location = new System.Drawing.Point(107, 55);
            this.Actueel_weer.Name = "Actueel_weer";
            this.Actueel_weer.Size = new System.Drawing.Size(39, 13);
            this.Actueel_weer.TabIndex = 2;
            this.Actueel_weer.Text = "Regen";
            // 
            // Actueel_Plaats
            // 
            this.Actueel_Plaats.AutoSize = true;
            this.Actueel_Plaats.Location = new System.Drawing.Point(104, 13);
            this.Actueel_Plaats.Name = "Actueel_Plaats";
            this.Actueel_Plaats.Size = new System.Drawing.Size(130, 13);
            this.Actueel_Plaats.TabIndex = 1;
            this.Actueel_Plaats.Text = "Amsterdam, North Holland";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stenden_Weerstation.Properties.Resources.thunderstorm;
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Title1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Title1.Location = new System.Drawing.Point(105, 22);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(215, 25);
            this.Title1.TabIndex = 2;
            this.Title1.Text = "Stenden Weerstation";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.Title2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(431, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trend";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.Title = "Dagen";
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.Title = "Temperatuur";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 64);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "GemTemp";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(425, 245);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Title2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Title2.Location = new System.Drawing.Point(105, 22);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(215, 25);
            this.Title2.TabIndex = 2;
            this.Title2.Text = "Stenden Weerstation";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.Title3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(431, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Opties";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Opties_Succeed);
            this.panel1.Controls.Add(this.Opties_Error);
            this.panel1.Controls.Add(this.Opties_Interval2);
            this.panel1.Controls.Add(this.Fahrenheit);
            this.panel1.Controls.Add(this.Celsius);
            this.panel1.Controls.Add(this.Opties_Plaats2);
            this.panel1.Controls.Add(this.Opties_Interval3);
            this.panel1.Controls.Add(this.Opties_Weergave);
            this.panel1.Controls.Add(this.Opties_Interval);
            this.panel1.Controls.Add(this.Opties_Plaats);
            this.panel1.Controls.Add(this.Opties_Button);
            this.panel1.Location = new System.Drawing.Point(35, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 228);
            this.panel1.TabIndex = 3;
            // 
            // Opties_Succeed
            // 
            this.Opties_Succeed.AutoSize = true;
            this.Opties_Succeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Opties_Succeed.Location = new System.Drawing.Point(73, 15);
            this.Opties_Succeed.Name = "Opties_Succeed";
            this.Opties_Succeed.Size = new System.Drawing.Size(0, 13);
            this.Opties_Succeed.TabIndex = 11;
            // 
            // Opties_Error
            // 
            this.Opties_Error.AutoSize = true;
            this.Opties_Error.ForeColor = System.Drawing.Color.Red;
            this.Opties_Error.Location = new System.Drawing.Point(73, 15);
            this.Opties_Error.Name = "Opties_Error";
            this.Opties_Error.Size = new System.Drawing.Size(0, 13);
            this.Opties_Error.TabIndex = 10;
            // 
            // Opties_Interval2
            // 
            this.Opties_Interval2.Location = new System.Drawing.Point(73, 75);
            this.Opties_Interval2.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Opties_Interval2.Name = "Opties_Interval2";
            this.Opties_Interval2.Size = new System.Drawing.Size(45, 20);
            this.Opties_Interval2.TabIndex = 9;
            this.Opties_Interval2.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.AutoSize = true;
            this.Fahrenheit.Location = new System.Drawing.Point(124, 119);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(35, 17);
            this.Fahrenheit.TabIndex = 8;
            this.Fahrenheit.TabStop = true;
            this.Fahrenheit.Text = "°F";
            this.Fahrenheit.UseVisualStyleBackColor = true;
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Checked = true;
            this.Celsius.Location = new System.Drawing.Point(82, 119);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(36, 17);
            this.Celsius.TabIndex = 7;
            this.Celsius.TabStop = true;
            this.Celsius.Text = "°C";
            this.Celsius.UseVisualStyleBackColor = true;
            // 
            // Opties_Plaats2
            // 
            this.Opties_Plaats2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Opties_Plaats2.Location = new System.Drawing.Point(73, 34);
            this.Opties_Plaats2.Name = "Opties_Plaats2";
            this.Opties_Plaats2.Size = new System.Drawing.Size(100, 21);
            this.Opties_Plaats2.TabIndex = 5;
            this.Opties_Plaats2.TextChanged += new System.EventHandler(this.Opties_Plaats2_TextChanged);
            // 
            // Opties_Interval3
            // 
            this.Opties_Interval3.AutoSize = true;
            this.Opties_Interval3.Location = new System.Drawing.Point(121, 82);
            this.Opties_Interval3.Name = "Opties_Interval3";
            this.Opties_Interval3.Size = new System.Drawing.Size(52, 13);
            this.Opties_Interval3.TabIndex = 4;
            this.Opties_Interval3.Text = "(in  secs.)";
            // 
            // Opties_Weergave
            // 
            this.Opties_Weergave.AutoSize = true;
            this.Opties_Weergave.Location = new System.Drawing.Point(19, 123);
            this.Opties_Weergave.Name = "Opties_Weergave";
            this.Opties_Weergave.Size = new System.Drawing.Size(57, 13);
            this.Opties_Weergave.TabIndex = 3;
            this.Opties_Weergave.Text = "Weergave";
            // 
            // Opties_Interval
            // 
            this.Opties_Interval.AutoSize = true;
            this.Opties_Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Opties_Interval.Location = new System.Drawing.Point(18, 82);
            this.Opties_Interval.Name = "Opties_Interval";
            this.Opties_Interval.Size = new System.Drawing.Size(46, 15);
            this.Opties_Interval.TabIndex = 2;
            this.Opties_Interval.Text = "Interval";
            // 
            // Opties_Plaats
            // 
            this.Opties_Plaats.AutoSize = true;
            this.Opties_Plaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Opties_Plaats.Location = new System.Drawing.Point(18, 41);
            this.Opties_Plaats.Name = "Opties_Plaats";
            this.Opties_Plaats.Size = new System.Drawing.Size(41, 15);
            this.Opties_Plaats.TabIndex = 1;
            this.Opties_Plaats.Text = "Plaats";
            // 
            // Opties_Button
            // 
            this.Opties_Button.Location = new System.Drawing.Point(277, 198);
            this.Opties_Button.Name = "Opties_Button";
            this.Opties_Button.Size = new System.Drawing.Size(75, 23);
            this.Opties_Button.TabIndex = 0;
            this.Opties_Button.Text = "Ok";
            this.Opties_Button.UseVisualStyleBackColor = true;
            this.Opties_Button.Click += new System.EventHandler(this.Opties_Button_Click);
            // 
            // Title3
            // 
            this.Title3.AutoSize = true;
            this.Title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Title3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Title3.Location = new System.Drawing.Point(105, 22);
            this.Title3.Name = "Title3";
            this.Title3.Size = new System.Drawing.Size(215, 25);
            this.Title3.TabIndex = 2;
            this.Title3.Text = "Stenden Weerstation";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Stenden Weerstation";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Stenden Weerstation";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huidigeTemperatuurErrorToolStripMenuItem,
            this.overToolStripMenuItem,
            this.verversenToolStripMenuItem,
            this.optiesToolStripMenuItem,
            this.openenToolStripMenuItem,
            this.sluitenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 136);
            // 
            // huidigeTemperatuurErrorToolStripMenuItem
            // 
            this.huidigeTemperatuurErrorToolStripMenuItem.Name = "huidigeTemperatuurErrorToolStripMenuItem";
            this.huidigeTemperatuurErrorToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.huidigeTemperatuurErrorToolStripMenuItem.Text = "Huidige temperatuur: Error";
            // 
            // overToolStripMenuItem
            // 
            this.overToolStripMenuItem.Name = "overToolStripMenuItem";
            this.overToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.overToolStripMenuItem.Text = "Over...";
            this.overToolStripMenuItem.Click += new System.EventHandler(this.overToolStripMenuItem_Click);
            // 
            // verversenToolStripMenuItem
            // 
            this.verversenToolStripMenuItem.Name = "verversenToolStripMenuItem";
            this.verversenToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.verversenToolStripMenuItem.Text = "Verversen...";
            this.verversenToolStripMenuItem.Click += new System.EventHandler(this.verversenToolStripMenuItem_Click);
            // 
            // optiesToolStripMenuItem
            // 
            this.optiesToolStripMenuItem.Name = "optiesToolStripMenuItem";
            this.optiesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.optiesToolStripMenuItem.Text = "Opties...";
            this.optiesToolStripMenuItem.Click += new System.EventHandler(this.optiesToolStripMenuItem_Click);
            // 
            // openenToolStripMenuItem
            // 
            this.openenToolStripMenuItem.Name = "openenToolStripMenuItem";
            this.openenToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.openenToolStripMenuItem.Text = "Openen...";
            this.openenToolStripMenuItem.Click += new System.EventHandler(this.openenToolStripMenuItem_Click);
            // 
            // sluitenToolStripMenuItem
            // 
            this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
            this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.sluitenToolStripMenuItem.Text = "Sluiten";
            this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.sluitenToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 375);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stenden Weerstation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Opties_Interval2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.Label Title3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Opties_Interval;
        private System.Windows.Forms.Label Opties_Plaats;
        private System.Windows.Forms.Button Opties_Button;
        private System.Windows.Forms.RadioButton Fahrenheit;
        private System.Windows.Forms.RadioButton Celsius;
        private System.Windows.Forms.TextBox Opties_Plaats2;
        private System.Windows.Forms.Label Opties_Interval3;
        private System.Windows.Forms.Label Opties_Weergave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Actueel_Plaats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Actueel_Update;
        private System.Windows.Forms.Label Actueel_Wind;
        private System.Windows.Forms.Label Actueel_Luchtvochtigheid;
        private System.Windows.Forms.Label Actueel_Temperatuur;
        private System.Windows.Forms.Label Actueel_weer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem overToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verversenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huidigeTemperatuurErrorToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown Opties_Interval2;
        private System.Windows.Forms.Label Opties_Error;
        private System.Windows.Forms.Label Opties_Succeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

