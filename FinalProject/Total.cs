using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // ★ 畫圖表必備的工具包

namespace FinalProject
{
    public partial class Total : Form
    {
        public Total()
        {
            InitializeComponent();
        }

        // 接收 Form1 傳來的資料
        public Total(int income, int outcome, int balance)
        {
            InitializeComponent();

            // ==========================================
            // 1. 文字與顏色美化
            // ==========================================
            lblTotalIncome.Text = $"總收入：\nNT$ {income:N0}";
            lblTotalOutcome.Text = $"總支出：\nNT$ {outcome:N0}";
            lblBalance.Text = $"總經濟：\nNT$ {balance:N0}";

            lblTotalIncome.ForeColor = Color.SeaGreen;
            lblTotalOutcome.ForeColor = Color.Crimson;
            lblBalance.ForeColor = (balance >= 0) ? Color.RoyalBlue : Color.Crimson;

            // ==========================================
            // 2. 啟動畫圖表功能
            // ==========================================
            DrawPieChart(income, outcome);

            // ==========================================
            // 3. ★ 動態產生「匯出圖表」按鈕 (不用手動拉！)
            // ==========================================
            Button btnExport = new Button();
            btnExport.Text = "💾 匯出圖表";
            btnExport.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
            btnExport.Size = new Size(130, 45);
            btnExport.Location = new Point(20, 20); // 放在左上角
            btnExport.BackColor = Color.LightSteelBlue;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Cursor = Cursors.Hand;
            btnExport.Click += BtnExport_Click; // 綁定點擊事件
            this.Controls.Add(btnExport); // 將按鈕加入畫面
        }

        // ==========================================
        // ★ 匯出圖表的點擊事件
        // ==========================================
        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (this.Controls.Find("chart1", true).Length == 0) return;
            Chart chart = (Chart)this.Controls.Find("chart1", true)[0];

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG 圖片|*.png"; // 限制存成 PNG
            sfd.FileName = "收支統計圖表.png"; // 預設檔名

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                chart.SaveImage(sfd.FileName, ChartImageFormat.Png);
                MessageBox.Show("圖表匯出成功！可以去資料夾查看囉。", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ==========================================
        // 4. 繪製甜甜圈圓餅圖的方法
        // ==========================================
        private void DrawPieChart(int income, int outcome)
        {
            if (this.Controls.Find("chart1", true).Length == 0) return;
            Chart chart = (Chart)this.Controls.Find("chart1", true)[0];

            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            chart.Titles.Add("收支比例分析");
            chart.Titles[0].Font = new Font("微軟正黑體", 16, FontStyle.Bold);

            Series series = new Series("收支");
            series.ChartType = SeriesChartType.Doughnut;

            series.Label = "#VALX \n #PERCENT{P1}";
            series.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
            series["PieLabelStyle"] = "Outside";
            series.LabelForeColor = Color.Black;

            // ★ 新增功能：滑鼠移上去時會顯示精確金額！
            series.ToolTip = "#VALX: NT$ #VAL{N0}";

            if (income > 0)
            {
                int ptIncome = series.Points.AddXY("收入", income);
                series.Points[ptIncome].Color = Color.SeaGreen;
            }

            if (outcome > 0)
            {
                int ptOutcome = series.Points.AddXY("支出", outcome);
                series.Points[ptOutcome].Color = Color.Crimson;
            }

            chart.Series.Add(series);
        }

        private void Total_Load(object sender, EventArgs e)
        {
        }
    }
}