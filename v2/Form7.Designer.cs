namespace ArendaKvartir
{
    partial class Form7
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.Location = new System.Drawing.Point(20, 76);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(840, 270);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Location = new System.Drawing.Point(20, 356);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(840, 180);
            this.pnlEdit.TabIndex = 1;
            this.pnlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(16, 22);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(100, 18);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(200, 26);
            this.txtLogin.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(330, 22);
            this.lblPass.Name = "lblPass";
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Пароль";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(400, 18);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 26);
            this.txtPass.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(16, 62);
            this.lblRole.Name = "lblRole";
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Роль";
            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(100, 58);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(200, 26);
            this.cmbRole.TabIndex = 7;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] {"Администратор", "Менеджер", "Покупатель", "Пользователь"});
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(330, 62);
            this.lblClient.Name = "lblClient";
            this.lblClient.TabIndex = 8;
            this.lblClient.Text = "Клиент";
            // 
            // cmbClient
            // 
            this.cmbClient.Location = new System.Drawing.Point(400, 58);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(300, 26);
            this.cmbClient.TabIndex = 9;
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(16, 98);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(800, 20);
            this.lblNote.TabIndex = 10;
            this.lblNote.Text = "При изменении записи пустой пароль означает «оставить прежний». Клиент нужен только роли «Покупатель».";
            this.lblNote.Tag = "muted";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(196, 130);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(170, 36);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Сохранить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(376, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 36);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(740, 546);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form7
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.pnlEdit.Controls.Add(this.lblLogin);
            this.pnlEdit.Controls.Add(this.txtLogin);
            this.pnlEdit.Controls.Add(this.lblPass);
            this.pnlEdit.Controls.Add(this.txtPass);
            this.pnlEdit.Controls.Add(this.lblRole);
            this.pnlEdit.Controls.Add(this.cmbRole);
            this.pnlEdit.Controls.Add(this.lblClient);
            this.pnlEdit.Controls.Add(this.cmbClient);
            this.pnlEdit.Controls.Add(this.lblNote);
            this.pnlEdit.Controls.Add(this.btnAdd);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.btnClose);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MinimumSize = new System.Drawing.Size(880, 600);
            this.Name = "Form7";
            this.Text = "Пользователи системы";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}
