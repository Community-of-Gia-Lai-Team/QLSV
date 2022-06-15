namespace WindowsFormsApp1
{
    partial class StaticResultForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label_staticcourse = new System.Windows.Forms.Label();
            this.label_CSharf = new System.Windows.Forms.Label();
            this.label_java = new System.Windows.Forms.Label();
            this.label_cloudcomputing = new System.Windows.Forms.Label();
            this.label_machinelearning = new System.Windows.Forms.Label();
            this.label_staticresult = new System.Windows.Forms.Label();
            this.label_fail = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.chart_result = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Classification = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label_tb = new System.Windows.Forms.Label();
            this.label_k = new System.Windows.Forms.Label();
            this.label_g = new System.Windows.Forms.Label();
            this.label_xx = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Classification)).BeginInit();
            this.SuspendLayout();
            // 
            // label_staticcourse
            // 
            this.label_staticcourse.AutoSize = true;
            this.label_staticcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staticcourse.Location = new System.Drawing.Point(35, 65);
            this.label_staticcourse.Name = "label_staticcourse";
            this.label_staticcourse.Size = new System.Drawing.Size(258, 29);
            this.label_staticcourse.TabIndex = 0;
            this.label_staticcourse.Text = "Statistics By Courses";
            // 
            // label_CSharf
            // 
            this.label_CSharf.AutoSize = true;
            this.label_CSharf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CSharf.Location = new System.Drawing.Point(35, 138);
            this.label_CSharf.Name = "label_CSharf";
            this.label_CSharf.Size = new System.Drawing.Size(44, 25);
            this.label_CSharf.TabIndex = 1;
            this.label_CSharf.Text = "C#:";
            // 
            // label_java
            // 
            this.label_java.AutoSize = true;
            this.label_java.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_java.Location = new System.Drawing.Point(35, 187);
            this.label_java.Name = "label_java";
            this.label_java.Size = new System.Drawing.Size(61, 25);
            this.label_java.TabIndex = 2;
            this.label_java.Text = "Java:";
            // 
            // label_cloudcomputing
            // 
            this.label_cloudcomputing.AutoSize = true;
            this.label_cloudcomputing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cloudcomputing.Location = new System.Drawing.Point(35, 238);
            this.label_cloudcomputing.Name = "label_cloudcomputing";
            this.label_cloudcomputing.Size = new System.Drawing.Size(170, 25);
            this.label_cloudcomputing.TabIndex = 3;
            this.label_cloudcomputing.Text = "Cloud Computing:";
            // 
            // label_machinelearning
            // 
            this.label_machinelearning.AutoSize = true;
            this.label_machinelearning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_machinelearning.Location = new System.Drawing.Point(35, 290);
            this.label_machinelearning.Name = "label_machinelearning";
            this.label_machinelearning.Size = new System.Drawing.Size(174, 25);
            this.label_machinelearning.TabIndex = 4;
            this.label_machinelearning.Text = "Machine Learning:";
            // 
            // label_staticresult
            // 
            this.label_staticresult.AutoSize = true;
            this.label_staticresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staticresult.Location = new System.Drawing.Point(447, 65);
            this.label_staticresult.Name = "label_staticresult";
            this.label_staticresult.Size = new System.Drawing.Size(222, 29);
            this.label_staticresult.TabIndex = 5;
            this.label_staticresult.Text = "Statistic By Result";
            // 
            // label_fail
            // 
            this.label_fail.AutoSize = true;
            this.label_fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fail.Location = new System.Drawing.Point(447, 187);
            this.label_fail.Name = "label_fail";
            this.label_fail.Size = new System.Drawing.Size(49, 25);
            this.label_fail.TabIndex = 6;
            this.label_fail.Text = "Fail:";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(447, 138);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(62, 25);
            this.label_pass.TabIndex = 7;
            this.label_pass.Text = "Pass:";
            // 
            // chart_result
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_result.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_result.Legends.Add(legend1);
            this.chart_result.Location = new System.Drawing.Point(452, 227);
            this.chart_result.Name = "chart_result";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelFormat = "#.## %";
            series1.Legend = "Legend1";
            series1.Name = "Charts";
            this.chart_result.Series.Add(series1);
            this.chart_result.Size = new System.Drawing.Size(371, 300);
            this.chart_result.TabIndex = 8;
            this.chart_result.Text = "Static By Result";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Static By Result";
            this.chart_result.Titles.Add(title1);
            // 
            // chart_Classification
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Classification.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Classification.Legends.Add(legend2);
            this.chart_Classification.Location = new System.Drawing.Point(899, 227);
            this.chart_Classification.Name = "chart_Classification";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.LabelFormat = "#.## %";
            series2.Legend = "Legend1";
            series2.Name = "Chart";
            this.chart_Classification.Series.Add(series2);
            this.chart_Classification.Size = new System.Drawing.Size(359, 300);
            this.chart_Classification.TabIndex = 9;
            this.chart_Classification.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Static By Classification";
            this.chart_Classification.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(894, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Statistic By Classification";
            // 
            // label_tb
            // 
            this.label_tb.AutoSize = true;
            this.label_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tb.Location = new System.Drawing.Point(1171, 104);
            this.label_tb.Name = "label_tb";
            this.label_tb.Size = new System.Drawing.Size(112, 25);
            this.label_tb.TabIndex = 11;
            this.label_tb.Text = "Trung bình:";
            // 
            // label_k
            // 
            this.label_k.AutoSize = true;
            this.label_k.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_k.Location = new System.Drawing.Point(894, 187);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(54, 25);
            this.label_k.TabIndex = 12;
            this.label_k.Text = "Khá:";
            // 
            // label_g
            // 
            this.label_g.AutoSize = true;
            this.label_g.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_g.Location = new System.Drawing.Point(894, 147);
            this.label_g.Name = "label_g";
            this.label_g.Size = new System.Drawing.Size(52, 25);
            this.label_g.TabIndex = 13;
            this.label_g.Text = "Giỏi:";
            // 
            // label_xx
            // 
            this.label_xx.AutoSize = true;
            this.label_xx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_xx.Location = new System.Drawing.Point(894, 104);
            this.label_xx.Name = "label_xx";
            this.label_xx.Size = new System.Drawing.Size(95, 25);
            this.label_xx.TabIndex = 14;
            this.label_xx.Text = "Xuất xắc:";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_y.Location = new System.Drawing.Point(1171, 147);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(53, 25);
            this.label_y.TabIndex = 15;
            this.label_y.Text = "Yếu:";
            // 
            // StaticResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 575);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_xx);
            this.Controls.Add(this.label_g);
            this.Controls.Add(this.label_k);
            this.Controls.Add(this.label_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_Classification);
            this.Controls.Add(this.chart_result);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_fail);
            this.Controls.Add(this.label_staticresult);
            this.Controls.Add(this.label_machinelearning);
            this.Controls.Add(this.label_cloudcomputing);
            this.Controls.Add(this.label_java);
            this.Controls.Add(this.label_CSharf);
            this.Controls.Add(this.label_staticcourse);
            this.Name = "StaticResultForm";
            this.Text = "StaticResultForm";
            this.Load += new System.EventHandler(this.StaticResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Classification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_staticcourse;
        private System.Windows.Forms.Label label_CSharf;
        private System.Windows.Forms.Label label_java;
        private System.Windows.Forms.Label label_cloudcomputing;
        private System.Windows.Forms.Label label_machinelearning;
        private System.Windows.Forms.Label label_staticresult;
        private System.Windows.Forms.Label label_fail;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_result;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Classification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_tb;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Label label_g;
        private System.Windows.Forms.Label label_xx;
        private System.Windows.Forms.Label label_y;
    }
}