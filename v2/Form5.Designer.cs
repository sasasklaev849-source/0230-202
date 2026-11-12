namespace ArendaKvartir
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.pnlNew = new System.Windows.Forms.Panel();
            this.lblApt = new System.Windows.Forms.Label();
            this.cmbApt = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblMonths = new System.Windows.Forms.Label();
            this.numMonths = new System.Windows.Forms.NumericUpDown();
            this.lblPriceInfo = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblRule = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dgvContracts
            // 
            this.dgvContracts.Location = new System.Drawing.Point(20, 76);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.Size = new System.Drawing.Size(940, 280);
            this.dgvContracts.TabIndex = 0;
            this.dgvContracts.AllowUserToAddRows = false;
            this.dgvContracts.AllowUserToDeleteRows = false;
            this.dgvContracts.ReadOnly = true;
            this.dgvContracts.MultiSelect = false;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            // 
            // pnlNew
            // 
            this.pnlNew.Location = new System.Drawing.Point(20, 366);
            this.pnlNew.Name = "pnlNew";
            this.pnlNew.Size = new System.Drawing.Size(940, 230);
            this.pnlNew.TabIndex = 1;
            this.pnlNew.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            // 
            // lblApt
            // 
            this.lblApt.AutoSize = true;
            this.lblApt.Location = new System.Drawing.Point(16, 22);
            this.lblApt.Name = "lblApt";
            this.lblApt.TabIndex = 2;
            this.lblApt.Text = "Квартира";
            // 
            // cmbApt
            // 
            this.cmbApt.Location = new System.Drawing.Point(110, 18);
            this.cmbApt.Name = "cmbApt";
            this.cmbApt.Size = new System.Drawing.Size(420, 26);
            this.cmbApt.TabIndex = 3;
            this.cmbApt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApt.SelectedIndexChanged += new System.EventHandler(this.Recalc_Changed);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(16, 62);
            this.lblClient.Name = "lblClient";
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "Клиент";
            // 
            // cmbClient
            // 
            this.cmbClient.Location = new System.Drawing.Point(110, 58);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(420, 26);
            this.cmbClient.TabIndex = 5;
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 102);
            this.lblDate.Name = "lblDate";
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Дата начала";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(110, 98);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(140, 26);
            this.dtpStart.TabIndex = 7;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(280, 102);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.TabIndex = 8;
            this.lblMonths.Text = "Месяцев";
            // 
            // numMonths
            // 
            this.numMonths.Location = new System.Drawing.Point(345, 98);
            this.numMonths.Name = "numMonths";
            this.numMonths.Size = new System.Drawing.Size(70, 26);
            this.numMonths.TabIndex = 9;
            this.numMonths.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numMonths.Maximum = new decimal(new int[] {60, 0, 0, 0});
            this.numMonths.Value = new decimal(new int[] {1, 0, 0, 0});
            this.numMonths.ValueChanged += new System.EventHandler(this.Recalc_Changed);
            // 
            // lblPriceInfo
            // 
            this.lblPriceInfo.AutoSize = true;
            this.lblPriceInfo.Location = new System.Drawing.Point(570, 22);
            this.lblPriceInfo.Name = "lblPriceInfo";
            this.lblPriceInfo.TabIndex = 10;
            this.lblPriceInfo.Text = "Цена: -";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(570, 56);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Скидка: -";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(570, 92);
            this.lblSum.Name = "lblSum";
            this.lblSum.TabIndex = 12;
            this.lblSum.Text = "Итого: -";
            this.lblSum.Tag = "big";
            // 
            // lblRule
            // 
            this.lblRule.Location = new System.Drawing.Point(570, 130);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(350, 40);
            this.lblRule.TabIndex = 13;
            this.lblRule.Text = "Скидка за срок: от 6 мес. - 5%, от 12 мес. - 10%, от 24 мес. - 15%";
            this.lblRule.Tag = "muted";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 40);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Оформить договор";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(226, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 40);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Удалить договор";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(840, 606);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(980, 660);
            this.pnlNew.Controls.Add(this.lblApt);
            this.pnlNew.Controls.Add(this.cmbApt);
            this.pnlNew.Controls.Add(this.lblClient);
            this.pnlNew.Controls.Add(this.cmbClient);
            this.pnlNew.Controls.Add(this.lblDate);
            this.pnlNew.Controls.Add(this.dtpStart);
            this.pnlNew.Controls.Add(this.lblMonths);
            this.pnlNew.Controls.Add(this.numMonths);
            this.pnlNew.Controls.Add(this.lblPriceInfo);
            this.pnlNew.Controls.Add(this.lblDiscount);
            this.pnlNew.Controls.Add(this.lblSum);
            this.pnlNew.Controls.Add(this.lblRule);
            this.pnlNew.Controls.Add(this.btnAdd);
            this.pnlNew.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvContracts);
            this.Controls.Add(this.pnlNew);
            this.Controls.Add(this.btnClose);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MinimumSize = new System.Drawing.Size(980, 660);
            this.Name = "Form5";
            this.Text = "Договоры аренды";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Panel pnlNew;
        private System.Windows.Forms.Label lblApt;
        private System.Windows.Forms.ComboBox cmbApt;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.NumericUpDown numMonths;
        private System.Windows.Forms.Label lblPriceInfo;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}
