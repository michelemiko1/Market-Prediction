﻿namespace MarketPrediction
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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.checkBoxMacd = new System.Windows.Forms.CheckBox();
            this.checkBoxRsi = new System.Windows.Forms.CheckBox();
            this.checkBoxEma = new System.Windows.Forms.CheckBox();
            this.comboBoxSeries = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxIndex = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panelChart.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.BorderColor = System.Drawing.Color.Silver;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.SystemColors.Control;
            legend2.BorderColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart.Size = new System.Drawing.Size(702, 426);
            this.chart.TabIndex = 0;
            // 
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.Controls.Add(this.chart);
            this.panelChart.Location = new System.Drawing.Point(0, 0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(702, 426);
            this.panelChart.TabIndex = 1;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.checkBoxIndex);
            this.panelControl.Controls.Add(this.checkBoxMacd);
            this.panelControl.Controls.Add(this.checkBoxRsi);
            this.panelControl.Controls.Add(this.checkBoxEma);
            this.panelControl.Controls.Add(this.comboBoxSeries);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 419);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(702, 48);
            this.panelControl.TabIndex = 3;
            // 
            // checkBoxMacd
            // 
            this.checkBoxMacd.AutoSize = true;
            this.checkBoxMacd.Location = new System.Drawing.Point(320, 18);
            this.checkBoxMacd.Name = "checkBoxMacd";
            this.checkBoxMacd.Size = new System.Drawing.Size(57, 17);
            this.checkBoxMacd.TabIndex = 6;
            this.checkBoxMacd.Text = "MACD";
            this.toolTip.SetToolTip(this.checkBoxMacd, "Moving Average Convergence Divergence");
            this.checkBoxMacd.UseVisualStyleBackColor = true;
            this.checkBoxMacd.CheckedChanged += new System.EventHandler(this.checkBoxMacd_CheckedChanged);
            // 
            // checkBoxRsi
            // 
            this.checkBoxRsi.AutoSize = true;
            this.checkBoxRsi.Location = new System.Drawing.Point(270, 18);
            this.checkBoxRsi.Name = "checkBoxRsi";
            this.checkBoxRsi.Size = new System.Drawing.Size(44, 17);
            this.checkBoxRsi.TabIndex = 5;
            this.checkBoxRsi.Text = "RSI";
            this.toolTip.SetToolTip(this.checkBoxRsi, "Relative Strength Index");
            this.checkBoxRsi.UseVisualStyleBackColor = true;
            this.checkBoxRsi.CheckedChanged += new System.EventHandler(this.checkBoxRsi_CheckedChanged);
            // 
            // checkBoxEma
            // 
            this.checkBoxEma.AutoSize = true;
            this.checkBoxEma.Location = new System.Drawing.Point(215, 18);
            this.checkBoxEma.Name = "checkBoxEma";
            this.checkBoxEma.Size = new System.Drawing.Size(49, 17);
            this.checkBoxEma.TabIndex = 1;
            this.checkBoxEma.Text = "EMA";
            this.toolTip.SetToolTip(this.checkBoxEma, "Exponential Moving Average");
            this.checkBoxEma.UseVisualStyleBackColor = true;
            this.checkBoxEma.CheckedChanged += new System.EventHandler(this.checkBoxEma_CheckedChanged);
            // 
            // comboBoxSeries
            // 
            this.comboBoxSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeries.FormattingEnabled = true;
            this.comboBoxSeries.Location = new System.Drawing.Point(12, 15);
            this.comboBoxSeries.Name = "comboBoxSeries";
            this.comboBoxSeries.Size = new System.Drawing.Size(131, 21);
            this.comboBoxSeries.TabIndex = 4;
            this.comboBoxSeries.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeries_SelectedIndexChanged);
            // 
            // checkBoxIndex
            // 
            this.checkBoxIndex.AutoSize = true;
            this.checkBoxIndex.Location = new System.Drawing.Point(157, 18);
            this.checkBoxIndex.Name = "checkBoxIndex";
            this.checkBoxIndex.Size = new System.Drawing.Size(52, 17);
            this.checkBoxIndex.TabIndex = 7;
            this.checkBoxIndex.Text = "Index";
            this.toolTip.SetToolTip(this.checkBoxIndex, "Currency Index");
            this.checkBoxIndex.UseVisualStyleBackColor = true;
            this.checkBoxIndex.CheckedChanged += new System.EventHandler(this.checkBoxIndex_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 467);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelChart);
            this.Name = "MainForm";
            this.Text = "Market Prediction";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panelChart.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ComboBox comboBoxSeries;
        private System.Windows.Forms.CheckBox checkBoxMacd;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkBoxRsi;
        private System.Windows.Forms.CheckBox checkBoxEma;
        private System.Windows.Forms.CheckBox checkBoxIndex;
    }
}

