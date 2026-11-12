namespace ArendaKvartir
{
    partial class Form1
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(30, 80);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(30, 102);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(360, 26);
            this.txtLogin.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(30, 142);
            this.lblPass.Name = "lblPass";
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Пароль";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(30, 164);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(360, 26);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(30, 214);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(360, 40);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Войти";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(30, 262);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(360, 36);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Регистрация нового пользователя";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(30, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(360, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblHint
            // 
            this.lblHint.Location = new System.Drawing.Point(30, 358);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(360, 66);
            this.lblHint.TabIndex = 7;
            this.lblHint.Text = "Тестовые учётные записи (логин / пароль):\nadmin / admin     manager / manager\nbuyer / buyer     user / user";
            this.lblHint.Tag = "muted";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AcceptButton = this.btnOk;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(420, 440);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblHint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHint;
    }
}
