namespace FinalProject
{
    partial class FinalProject
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radiobtnIncome = new System.Windows.Forms.RadioButton();
            this.comboxClassification = new System.Windows.Forms.ComboBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lsvDetails = new System.Windows.Forms.ListView();
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInOutcome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClassification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRemark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radiobtnOutcome = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpModify = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpRead = new System.Windows.Forms.GroupBox();
            this.btnShowSummary = new System.Windows.Forms.Button();
            this.grpModify.SuspendLayout();
            this.grpRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(500, 39);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // radiobtnIncome
            // 
            this.radiobtnIncome.AutoSize = true;
            this.radiobtnIncome.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radiobtnIncome.Location = new System.Drawing.Point(272, 115);
            this.radiobtnIncome.Name = "radiobtnIncome";
            this.radiobtnIncome.Size = new System.Drawing.Size(96, 40);
            this.radiobtnIncome.TabIndex = 1;
            this.radiobtnIncome.TabStop = true;
            this.radiobtnIncome.Text = "收入";
            this.radiobtnIncome.UseVisualStyleBackColor = true;
            // 
            // comboxClassification
            // 
            this.comboxClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxClassification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboxClassification.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboxClassification.FormattingEnabled = true;
            this.comboxClassification.Items.AddRange(new object[] {
            "餐飲",
            "交通",
            "娛樂",
            "薪水",
            "水電費",
            "電話費",
            "租稅",
            "其他"});
            this.comboxClassification.Location = new System.Drawing.Point(144, 214);
            this.comboxClassification.Name = "comboxClassification";
            this.comboxClassification.Size = new System.Drawing.Size(500, 44);
            this.comboxClassification.TabIndex = 2;
            this.comboxClassification.SelectedIndexChanged += new System.EventHandler(this.comboxClassification_SelectedIndexChanged);
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMoney.Location = new System.Drawing.Point(144, 298);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(500, 36);
            this.txtMoney.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRemark.Location = new System.Drawing.Point(144, 388);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(500, 36);
            this.txtRemark.TabIndex = 5;
            // 
            // lsvDetails
            // 
            this.lsvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvDetails.BackColor = System.Drawing.SystemColors.Window;
            this.lsvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colInOutcome,
            this.colClassification,
            this.colMoney,
            this.colRemark});
            this.lsvDetails.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lsvDetails.FullRowSelect = true;
            this.lsvDetails.GridLines = true;
            this.lsvDetails.HideSelection = false;
            this.lsvDetails.Location = new System.Drawing.Point(698, -2);
            this.lsvDetails.Name = "lsvDetails";
            this.lsvDetails.Size = new System.Drawing.Size(932, 934);
            this.lsvDetails.SmallImageList = this.imageList1;
            this.lsvDetails.TabIndex = 6;
            this.lsvDetails.UseCompatibleStateImageBehavior = false;
            this.lsvDetails.View = System.Windows.Forms.View.Details;
            this.lsvDetails.SelectedIndexChanged += new System.EventHandler(this.lsvDetails_SelectedIndexChanged);
            // 
            // colDate
            // 
            this.colDate.Text = "日期";
            this.colDate.Width = 150;
            // 
            // colInOutcome
            // 
            this.colInOutcome.Text = "收支";
            this.colInOutcome.Width = 100;
            // 
            // colClassification
            // 
            this.colClassification.Text = "分類";
            this.colClassification.Width = 100;
            // 
            // colMoney
            // 
            this.colMoney.Text = "金額";
            this.colMoney.Width = 150;
            // 
            // colRemark
            // 
            this.colRemark.Text = "備註";
            this.colRemark.Width = 300;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 30);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // radiobtnOutcome
            // 
            this.radiobtnOutcome.AutoSize = true;
            this.radiobtnOutcome.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radiobtnOutcome.Location = new System.Drawing.Point(144, 115);
            this.radiobtnOutcome.Name = "radiobtnOutcome";
            this.radiobtnOutcome.Size = new System.Drawing.Size(96, 40);
            this.radiobtnOutcome.TabIndex = 8;
            this.radiobtnOutcome.TabStop = true;
            this.radiobtnOutcome.Text = "支出";
            this.radiobtnOutcome.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDate.Location = new System.Drawing.Point(46, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 36);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "日期 : ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblType.Location = new System.Drawing.Point(46, 117);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(92, 36);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "類型 : ";
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassification.Location = new System.Drawing.Point(46, 217);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(92, 36);
            this.lblClassification.TabIndex = 11;
            this.lblClassification.Text = "分類 : ";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMoney.Location = new System.Drawing.Point(46, 298);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(92, 36);
            this.lblMoney.TabIndex = 12;
            this.lblMoney.Text = "金額 : ";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRemark.Location = new System.Drawing.Point(46, 388);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(92, 36);
            this.lblRemark.TabIndex = 13;
            this.lblRemark.Text = "備註 : ";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.SandyBrown;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWrite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnWrite.Location = new System.Drawing.Point(19, 44);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(180, 57);
            this.btnWrite.TabIndex = 14;
            this.btnWrite.Text = "存入檔案";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(205, 44);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(180, 57);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "讀取檔案";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(19, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 57);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "新增帳目";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpModify
            // 
            this.grpModify.Controls.Add(this.btnDelete);
            this.grpModify.Controls.Add(this.btnEdit);
            this.grpModify.Controls.Add(this.btnAdd);
            this.grpModify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpModify.Location = new System.Drawing.Point(52, 475);
            this.grpModify.Name = "grpModify";
            this.grpModify.Size = new System.Drawing.Size(592, 123);
            this.grpModify.TabIndex = 17;
            this.grpModify.TabStop = false;
            this.grpModify.Text = "新增/修改/刪除帳目";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(391, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 57);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "刪除帳目";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(205, 44);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 57);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "修改帳目";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpRead
            // 
            this.grpRead.Controls.Add(this.btnShowSummary);
            this.grpRead.Controls.Add(this.btnWrite);
            this.grpRead.Controls.Add(this.btnLoad);
            this.grpRead.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpRead.Location = new System.Drawing.Point(52, 643);
            this.grpRead.Name = "grpRead";
            this.grpRead.Size = new System.Drawing.Size(592, 123);
            this.grpRead.TabIndex = 19;
            this.grpRead.TabStop = false;
            this.grpRead.Text = "存入/讀取帳目";
            // 
            // btnShowSummary
            // 
            this.btnShowSummary.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnShowSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSummary.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowSummary.ForeColor = System.Drawing.Color.White;
            this.btnShowSummary.Location = new System.Drawing.Point(391, 44);
            this.btnShowSummary.Name = "btnShowSummary";
            this.btnShowSummary.Size = new System.Drawing.Size(180, 57);
            this.btnShowSummary.TabIndex = 16;
            this.btnShowSummary.Text = "查看統計";
            this.btnShowSummary.UseVisualStyleBackColor = false;
            this.btnShowSummary.Click += new System.EventHandler(this.btnShowSummary_Click);
            // 
            // FinalProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1642, 944);
            this.Controls.Add(this.grpRead);
            this.Controls.Add(this.grpModify);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblClassification);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.radiobtnOutcome);
            this.Controls.Add(this.lsvDetails);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.comboxClassification);
            this.Controls.Add(this.radiobtnIncome);
            this.Controls.Add(this.dateTimePicker1);
            this.MinimumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "FinalProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人記帳系統";
            this.grpModify.ResumeLayout(false);
            this.grpRead.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radiobtnIncome;
        private System.Windows.Forms.ComboBox comboxClassification;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ListView lsvDetails;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colInOutcome;
        private System.Windows.Forms.ColumnHeader colClassification;
        private System.Windows.Forms.ColumnHeader colMoney;
        private System.Windows.Forms.ColumnHeader colRemark;
        private System.Windows.Forms.RadioButton radiobtnOutcome;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grpModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpRead;
        private System.Windows.Forms.Button btnShowSummary;
    }
}

