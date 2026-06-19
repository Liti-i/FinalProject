namespace FinalProject
{
    partial class Total
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
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblTotalOutcome = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalIncome.Location = new System.Drawing.Point(33, 90);
            this.lblTotalIncome.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(113, 40);
            this.lblTotalIncome.TabIndex = 0;
            this.lblTotalIncome.Text = "總收入";
            // 
            // lblTotalOutcome
            // 
            this.lblTotalOutcome.AutoSize = true;
            this.lblTotalOutcome.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalOutcome.Location = new System.Drawing.Point(33, 179);
            this.lblTotalOutcome.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTotalOutcome.Name = "lblTotalOutcome";
            this.lblTotalOutcome.Size = new System.Drawing.Size(113, 40);
            this.lblTotalOutcome.TabIndex = 1;
            this.lblTotalOutcome.Text = "總支入";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBalance.Location = new System.Drawing.Point(33, 269);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(113, 40);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "總經濟";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(416, -1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(560, 547);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblTotalOutcome);
            this.Controls.Add(this.lblTotalIncome);
            this.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Total";
            this.Text = "帳目統計";
            this.Load += new System.EventHandler(this.Total_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblTotalOutcome;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}