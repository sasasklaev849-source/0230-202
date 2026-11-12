namespace ArendaKvartir
{
    partial class Form6
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
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(30, 76);
            this.lblType.Name = "lblType";
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Тип учётной записи";
            // 
            // cmbType
            // 
            this.cmbType.Location = new System.Drawing.Point(30, 98);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(370, 26);
            this.cmbType.TabIndex = 1;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Items.AddRange(new object[] {"Покупатель", "Пользователь"});
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 138);
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 2;
            this.lblName.Text = "ФИО";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 160);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 26);
            this.txtName.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 200);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Телефон";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(30, 222);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(370, 26);
            this.txtPhone.TabIndex = 5;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(30, 262);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(30, 284);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(370, 26);
            this.txtLogin.TabIndex = 7;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(30, 324);
            this.lblPass.Name = "lblPass";
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Пароль (не короче 4 символов)";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(30, 346);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(370, 26);
            this.txtPass.TabIndex = 9;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Location = new System.Drawing.Point(30, 386);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.TabIndex = 10;
            this.lblPass2.Text = "Повтор пароля";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(30, 408);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(370, 26);
            this.txtPass2.TabIndex = 11;
            this.txtPass2.UseSystemPasswordChar = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(30, 462);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(370, 40);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Зарегистрироваться";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(30, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(370, 36);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form6
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AcceptButton = this.btnOk;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(440, 590);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass2);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form6";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
