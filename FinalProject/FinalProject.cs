using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;    // 這是用來讀寫檔案的工具包
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class FinalProject : Form
    {
        public FinalProject()
        {
            InitializeComponent();
        }

        private void comboxClassification_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "accounting_data.csv");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("找不到存檔紀錄！請先新增並存檔。", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 讀檔前先清空 lsvDetails
                lsvDetails.Items.Clear();

                using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        if (data.Length == 5)
                        {
                            ListViewItem item = new ListViewItem(data[0]); // 日期
                            item.SubItems.Add(data[1]); // 收支
                            item.SubItems.Add(data[2]); // 分類
                            item.SubItems.Add(data[3]); // 金額
                            item.SubItems.Add(data[4]); // 備註

                            if (data[1] == "支出")
                            {
                                item.ForeColor = Color.Red;
                            }
                            else
                            {
                                item.ForeColor = Color.Green;
                            }

                            // 加進你的 lsvDetails
                            lsvDetails.Items.Add(item);
                        }
                    }
                }
                MessageBox.Show("讀取成功！", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀檔失敗發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "accounting_data.csv");

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    // 注意這裡已經換成你的 lsvDetails 了！
                    foreach (ListViewItem item in lsvDetails.Items)
                    {
                        // 用逗號把五個欄位串起來
                        string line = $"{item.SubItems[0].Text},{item.SubItems[1].Text},{item.SubItems[2].Text},{item.SubItems[3].Text},{item.SubItems[4].Text}";
                        sw.WriteLine(line);
                    }
                }
                MessageBox.Show("存檔成功！資料已儲存。", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("存檔失敗發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 防呆 1：檢查有沒有選收支類型
            if (!radiobtnOutcome.Checked && !radiobtnIncome.Checked)
            {
                MessageBox.Show("請選擇「支出」或「收入」！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 防呆 2：檢查有沒有填寫分類
            if (string.IsNullOrWhiteSpace(comboxClassification.Text))
            {
                MessageBox.Show("請選擇或輸入「分類」！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 防呆 3：檢查 txtMoney 是否為正確的數字，且大於 0
            if (!int.TryParse(txtMoney.Text, out int parsedAmount) || parsedAmount <= 0)
            {
                MessageBox.Show("金額請輸入大於 0 的正確數字！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 停止執行，不加入表格
            }

            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string type = radiobtnOutcome.Checked ? "支出" : "收入";

            ListViewItem item = new ListViewItem(date);
            item.UseItemStyleForSubItems = false; // 關閉整行同色

            item.SubItems.Add(type);
            item.SubItems.Add(comboxClassification.Text);
            item.SubItems.Add(txtMoney.Text);
            item.SubItems.Add(txtRemark.Text);

            // 依據收支上色 (只讓「收支」和「金額」變色)
            Color rowColor = (type == "支出") ? Color.Red : Color.Green;
            item.SubItems[1].ForeColor = rowColor;
            item.SubItems[3].ForeColor = rowColor;

            lsvDetails.Items.Add(item);

            // 新增成功後，清空輸入框
            txtMoney.Clear();
            txtRemark.Clear();

            // UpdateSummary(); 
        }

        private void lsvDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 確認使用者有選取到資料
            if (lsvDetails.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvDetails.SelectedItems[0];

                // 帶入日期與收支
                dateTimePicker1.Value = DateTime.Parse(item.SubItems[0].Text);
                if (item.SubItems[1].Text == "支出")
                {
                    radiobtnOutcome.Checked = true; // ★ 改成你的支出按鈕
                }
                else
                {
                    radiobtnIncome.Checked = true;  // ★ 改成你的收入按鈕
                }

                // ★ 使用你專屬的元件名稱帶入資料
                comboxClassification.Text = item.SubItems[2].Text;  // 分類
                txtMoney.Text = item.SubItems[3].Text;              // 金額
                txtRemark.Text = item.SubItems[4].Text;             // 備註
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // 防呆：如果沒選取資料就按修改
            if (lsvDetails.SelectedItems.Count == 0)
            {
                MessageBox.Show("請先從右邊表格選擇要修改的帳目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 防呆：檢查 txtMoney 是否為正確數字
            if (!int.TryParse(txtMoney.Text, out int parsedAmount))
            {
                MessageBox.Show("金額請輸入正確的數字！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 抓出正在修改的那一行
            ListViewItem item = lsvDetails.SelectedItems[0];

            // ★ 透過你的支出按鈕來判斷類型
            string type = radiobtnOutcome.Checked ? "支出" : "收入";

            // ★ 將修改後的新資料覆蓋回表格
            item.SubItems[0].Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            item.SubItems[1].Text = type;
            item.SubItems[2].Text = comboxClassification.Text;
            item.SubItems[3].Text = txtMoney.Text;
            item.SubItems[4].Text = txtRemark.Text;

            // 重新上色 (避免收支類型改變後，顏色沒跟著變)
            Color rowColor = (type == "支出") ? Color.Red : Color.Green;
            item.SubItems[1].ForeColor = rowColor;
            item.SubItems[3].ForeColor = rowColor;

            // 如果你有寫更新總計的功能，請把下面這行的雙斜線拿掉
            // UpdateSummary(); 

            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 防呆：如果沒選取資料就按刪除
            if (lsvDetails.SelectedItems.Count == 0)
            {
                MessageBox.Show("請先從右邊表格選擇要刪除的帳目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 刪除前跳出確認視窗，避免手滑
            DialogResult result = MessageBox.Show("確定要刪除這筆帳目嗎？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // 刪除選取的那一行
                lsvDetails.SelectedItems[0].Remove();

                // ★ 清空你專屬的金額與備註輸入框
                txtMoney.Clear();
                txtRemark.Clear();

                // 如果你有寫更新總計的功能，請把下面這行的雙斜線拿掉
                // UpdateSummary(); 
            }
        }

        private void btnShowSummary_Click(object sender, EventArgs e)
        {
            // 1. 先準備好三個變數，用來存計算結果
            int totalIncome = 0;
            int totalOutcome = 0;

            // 2. 跑迴圈，把右邊表格 (lsvDetails) 裡的每一行拿出來算
            foreach (ListViewItem item in lsvDetails.Items)
            {
                string type = item.SubItems[1].Text;  // 第2欄是收支
                int amount = int.Parse(item.SubItems[3].Text); // 第4欄是金額

                if (type == "收入")
                {
                    totalIncome += amount;
                }
                else if (type == "支出")
                {
                    totalOutcome += amount;
                }
            }

            // 3. 算出結餘
            int balance = totalIncome - totalOutcome;

            // 4. ★ 核心關鍵：呼叫 Form2，並且把算好的 3 個數字「傳遞」過去！
            Total f2 = new Total(totalIncome, totalOutcome, balance);

            // 5. 把 Form2 顯示出來 (ShowDialog 會鎖住主畫面，必須關掉統計視窗才能繼續記帳)
            f2.ShowDialog();
        }
    }
}
