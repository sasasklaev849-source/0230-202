namespace ArendaKvartir
{
    partial class Form8
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
            this.lblApt = new System.Windows.Forms.Label();
            this.cmbApt = new System.Windows.Forms.ComboBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.dgvCalc = new System.Windows.Forms.DataGridView();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApt
            // 
            this.lblApt.AutoSize = true;
            this.lblApt.Location = new System.Drawing.Point(20, 80);
            this.lblApt.Name = "lblApt";
            this.lblApt.TabIndex = 0;
            this.lblApt.Text = "Квартира";
            // 
            // cmbApt
            // 
            this.cmbApt.Location = new System.Drawing.Point(95, 76);
            this.cmbApt.Name = "cmbApt";
            this.cmbApt.Size = new System.Drawing.Size(400, 26);
            this.cmbApt.TabIndex = 1;
            this.cmbApt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApt.SelectedIndexChanged += new System.EventHandler(this.Recalc_Changed);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(520, 80);
            this.lblMax.Name = "lblMax";
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Рассчитать до (мес.)";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(670, 76);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(70, 26);
            this.numMax.TabIndex = 3;
            this.numMax.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numMax.Maximum = new decimal(new int[] {60, 0, 0, 0});
            this.numMax.Value = new decimal(new int[] {24, 0, 0, 0});
            this.numMax.ValueChanged += new System.EventHandler(this.Recalc_Changed);
            // 
            // dgvCalc
            // 
            this.dgvCalc.Location = new System.Drawing.Point(20, 116);
            this.dgvCalc.Name = "dgvCalc";
            this.dgvCalc.Size = new System.Drawing.Size(560, 450);
            this.dgvCalc.TabIndex = 4;
            this.dgvCalc.AllowUserToAddRows = false;
            this.dgvCalc.AllowUserToDeleteRows = false;
            this.dgvCalc.ReadOnly = true;
            this.dgvCalc.MultiSelect = false;
            this.dgvCalc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            // 
            // pnlChart
            // 
            this.pnlChart.Location = new System.Drawing.Point(600, 116);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(340, 450);
            this.pnlChart.TabIndex = 5;
            this.pnlChart.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.pnlChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart_Paint);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(20, 580);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(700, 40);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "";
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            this.lblInfo.Tag = "muted";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(820, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form8
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.lblApt);
            this.Controls.Add(this.cmbApt);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.dgvCalc);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClose);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "Form8";
            this.Text = "Расчёт стоимости аренды";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblApt;
        private System.Windows.Forms.ComboBox cmbApt;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.DataGridView dgvCalc;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnClose;
    }
}
