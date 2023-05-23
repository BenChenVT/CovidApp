using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace CovidApp
{
    partial class CovidVisualization
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DC_Button = new System.Windows.Forms.RadioButton();
            this.GA_Button = new System.Windows.Forms.RadioButton();
            this.MD_Button = new System.Windows.Forms.RadioButton();
            this.NC_Button = new System.Windows.Forms.RadioButton();
            this.TN_Button = new System.Windows.Forms.RadioButton();
            this.VA_Button = new System.Windows.Forms.RadioButton();
            this.alphaSort = new System.Windows.Forms.Button();
            this.numericalSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(28, 135);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "ethnic";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1263, 514);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // DC_Button
            // 
            this.DC_Button.AutoSize = true;
            this.DC_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC_Button.Location = new System.Drawing.Point(58, 717);
            this.DC_Button.Name = "DC_Button";
            this.DC_Button.Size = new System.Drawing.Size(115, 55);
            this.DC_Button.TabIndex = 3;
            this.DC_Button.TabStop = true;
            this.DC_Button.Text = "DC";
            this.DC_Button.UseVisualStyleBackColor = true;
            this.DC_Button.CheckedChanged += new System.EventHandler(this.DC_Button_CheckedChanged);
            // 
            // GA_Button
            // 
            this.GA_Button.AutoSize = true;
            this.GA_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GA_Button.Location = new System.Drawing.Point(219, 717);
            this.GA_Button.Name = "GA_Button";
            this.GA_Button.Size = new System.Drawing.Size(115, 55);
            this.GA_Button.TabIndex = 4;
            this.GA_Button.TabStop = true;
            this.GA_Button.Text = "GA";
            this.GA_Button.UseVisualStyleBackColor = true;
            this.GA_Button.CheckedChanged += new System.EventHandler(this.GA_Button_CheckedChanged);
            // 
            // MD_Button
            // 
            this.MD_Button.AutoSize = true;
            this.MD_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD_Button.Location = new System.Drawing.Point(388, 717);
            this.MD_Button.Name = "MD_Button";
            this.MD_Button.Size = new System.Drawing.Size(120, 55);
            this.MD_Button.TabIndex = 5;
            this.MD_Button.TabStop = true;
            this.MD_Button.Text = "MD";
            this.MD_Button.UseVisualStyleBackColor = true;
            this.MD_Button.CheckedChanged += new System.EventHandler(this.MD_Button_CheckedChanged);
            // 
            // NC_Button
            // 
            this.NC_Button.AutoSize = true;
            this.NC_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NC_Button.Location = new System.Drawing.Point(565, 717);
            this.NC_Button.Name = "NC_Button";
            this.NC_Button.Size = new System.Drawing.Size(115, 55);
            this.NC_Button.TabIndex = 6;
            this.NC_Button.TabStop = true;
            this.NC_Button.Text = "NC";
            this.NC_Button.UseVisualStyleBackColor = true;
            this.NC_Button.CheckedChanged += new System.EventHandler(this.NC_Button_CheckedChanged);
            // 
            // TN_Button
            // 
            this.TN_Button.AutoSize = true;
            this.TN_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TN_Button.Location = new System.Drawing.Point(739, 717);
            this.TN_Button.Name = "TN_Button";
            this.TN_Button.Size = new System.Drawing.Size(110, 55);
            this.TN_Button.TabIndex = 7;
            this.TN_Button.TabStop = true;
            this.TN_Button.Text = "TN";
            this.TN_Button.UseVisualStyleBackColor = true;
            this.TN_Button.CheckedChanged += new System.EventHandler(this.TN_Button_CheckedChanged);
            // 
            // VA_Button
            // 
            this.VA_Button.AutoSize = true;
            this.VA_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VA_Button.Location = new System.Drawing.Point(905, 717);
            this.VA_Button.Name = "VA_Button";
            this.VA_Button.Size = new System.Drawing.Size(111, 55);
            this.VA_Button.TabIndex = 8;
            this.VA_Button.TabStop = true;
            this.VA_Button.Text = "VA";
            this.VA_Button.UseVisualStyleBackColor = true;
            this.VA_Button.CheckedChanged += new System.EventHandler(this.VA_Button_CheckedChanged);
            // 
            // alphaSort
            // 
            this.alphaSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaSort.Location = new System.Drawing.Point(115, 46);
            this.alphaSort.Name = "alphaSort";
            this.alphaSort.Size = new System.Drawing.Size(431, 64);
            this.alphaSort.TabIndex = 9;
            this.alphaSort.Text = "sort alphabetically of ethnics";
            this.alphaSort.UseVisualStyleBackColor = true;
            // 
            // numericalSort
            // 
            this.numericalSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericalSort.Location = new System.Drawing.Point(677, 46);
            this.numericalSort.Name = "numericalSort";
            this.numericalSort.Size = new System.Drawing.Size(431, 64);
            this.numericalSort.TabIndex = 10;
            this.numericalSort.Text = "sort numerically of the data";
            this.numericalSort.UseVisualStyleBackColor = true;
            // 
            // CovidVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 829);
            this.Controls.Add(this.numericalSort);
            this.Controls.Add(this.alphaSort);
            this.Controls.Add(this.VA_Button);
            this.Controls.Add(this.TN_Button);
            this.Controls.Add(this.NC_Button);
            this.Controls.Add(this.MD_Button);
            this.Controls.Add(this.GA_Button);
            this.Controls.Add(this.DC_Button);
            this.Controls.Add(this.chart1);
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "CovidVisualization";
            this.Text = "CovidVisualization";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton DC_Button;
        private System.Windows.Forms.RadioButton GA_Button;
        private System.Windows.Forms.RadioButton MD_Button;
        private System.Windows.Forms.RadioButton NC_Button;
        private System.Windows.Forms.RadioButton TN_Button;
        private System.Windows.Forms.RadioButton VA_Button;
        private System.Windows.Forms.Button alphaSort;
        private System.Windows.Forms.Button numericalSort;
    }
}