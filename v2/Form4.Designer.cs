namespace ArendaKvartir
{
    partial class Form4
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 80);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Поиск (ФИО / телефон)";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(190, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvClients
            // 
            this.dgvClients.Location = new System.Drawing.Point(20, 116);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(800, 296);
            this.dgvClients.TabIndex = 2;
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.ReadOnly = true;
            this.dgvClients.MultiSelect = false;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Location = new System.Drawing.Point(20, 422);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(800, 100);
            this.pnlEdit.TabIndex = 3;
            this.pnlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 20);
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 4;
            this.lblName.Text = "ФИО";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 26);
            this.txtName.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 60);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Телефон";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(100, 56);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 26);
            this.txtPhone.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(450, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(620, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 34);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Сохранить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(450, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(700, 532);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(840, 580);
            this.pnlEdit.Controls.Add(this.lblName);
            this.pnlEdit.Controls.Add(this.txtName);
            this.pnlEdit.Controls.Add(this.lblPhone);
            this.pnlEdit.Controls.Add(this.txtPhone);
            this.pnlEdit.Controls.Add(this.btnAdd);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.btnClose);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MinimumSize = new System.Drawing.Size(840, 580);
            this.Name = "Form4";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}
