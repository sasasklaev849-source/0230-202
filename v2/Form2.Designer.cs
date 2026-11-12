namespace ArendaKvartir
{
    partial class Form2
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnApartments = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(30, 74);
            this.lblUser.Name = "lblUser";
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Пользователь";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(30, 98);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(660, 22);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "";
            this.lblInfo.Tag = "muted";
            // 
            // flpMenu
            // 
            this.flpMenu.Location = new System.Drawing.Point(25, 130);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(670, 290);
            this.flpMenu.TabIndex = 2;
            // 
            // btnApartments
            // 
            this.btnApartments.Location = new System.Drawing.Point(0, 0);
            this.btnApartments.Name = "btnApartments";
            this.btnApartments.Size = new System.Drawing.Size(320, 84);
            this.btnApartments.TabIndex = 3;
            this.btnApartments.Text = "Квартиры";
            this.btnApartments.UseVisualStyleBackColor = true;
            this.btnApartments.Tag = "tile";
            this.btnApartments.Margin = new System.Windows.Forms.Padding(5);
            this.btnApartments.Click += new System.EventHandler(this.btnApartments_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(0, 0);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(320, 84);
            this.btnClients.TabIndex = 4;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Tag = "tile";
            this.btnClients.Margin = new System.Windows.Forms.Padding(5);
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(0, 0);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(320, 84);
            this.btnContracts.TabIndex = 5;
            this.btnContracts.Text = "Договоры аренды";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Tag = "tile";
            this.btnContracts.Margin = new System.Windows.Forms.Padding(5);
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(0, 0);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(320, 84);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Расчёт стоимости";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Tag = "tile";
            this.btnCalc.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(320, 84);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "Пользователи";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Tag = "tile";
            this.btnUsers.Margin = new System.Windows.Forms.Padding(5);
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(30, 442);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 38);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Сменить пользователя";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(480, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 38);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.flpMenu.Controls.Add(this.btnApartments);
            this.flpMenu.Controls.Add(this.btnClients);
            this.flpMenu.Controls.Add(this.btnContracts);
            this.flpMenu.Controls.Add(this.btnCalc);
            this.flpMenu.Controls.Add(this.btnUsers);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form2";
            this.Text = "Аренда квартир";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnApartments;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
    }
}
