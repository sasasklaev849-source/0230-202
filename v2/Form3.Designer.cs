namespace ArendaKvartir
{
    partial class Form3
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
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.chkFree = new System.Windows.Forms.CheckBox();
            this.dgvApartments = new System.Windows.Forms.DataGridView();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.lblRoomsN = new System.Windows.Forms.Label();
            this.numRooms = new System.Windows.Forms.NumericUpDown();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 80);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Поиск по адресу";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(135, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // cmbRooms
            // 
            this.cmbRooms.Location = new System.Drawing.Point(395, 76);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(160, 26);
            this.cmbRooms.TabIndex = 2;
            this.cmbRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRooms.Items.AddRange(new object[] {"Любое число комнат", "1 комната", "2 комнаты", "3 комнаты", "4 и более"});
            this.cmbRooms.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // chkFree
            // 
            this.chkFree.Location = new System.Drawing.Point(575, 78);
            this.chkFree.Name = "chkFree";
            this.chkFree.Size = new System.Drawing.Size(200, 24);
            this.chkFree.TabIndex = 3;
            this.chkFree.Text = "Только свободные";
            this.chkFree.AutoSize = true;
            this.chkFree.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // dgvApartments
            // 
            this.dgvApartments.Location = new System.Drawing.Point(20, 116);
            this.dgvApartments.Name = "dgvApartments";
            this.dgvApartments.Size = new System.Drawing.Size(880, 276);
            this.dgvApartments.TabIndex = 4;
            this.dgvApartments.AllowUserToAddRows = false;
            this.dgvApartments.AllowUserToDeleteRows = false;
            this.dgvApartments.ReadOnly = true;
            this.dgvApartments.MultiSelect = false;
            this.dgvApartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApartments.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvApartments.SelectionChanged += new System.EventHandler(this.dgvApartments_SelectionChanged);
            this.dgvApartments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvApartments_CellFormatting);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Location = new System.Drawing.Point(20, 402);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(880, 140);
            this.pnlEdit.TabIndex = 5;
            this.pnlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(16, 20);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.TabIndex = 6;
            this.lblAddr.Text = "Адрес";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(110, 16);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(380, 26);
            this.txtAddr.TabIndex = 7;
            // 
            // lblRoomsN
            // 
            this.lblRoomsN.AutoSize = true;
            this.lblRoomsN.Location = new System.Drawing.Point(510, 20);
            this.lblRoomsN.Name = "lblRoomsN";
            this.lblRoomsN.TabIndex = 8;
            this.lblRoomsN.Text = "Комнат";
            // 
            // numRooms
            // 
            this.numRooms.Location = new System.Drawing.Point(575, 16);
            this.numRooms.Name = "numRooms";
            this.numRooms.Size = new System.Drawing.Size(60, 26);
            this.numRooms.TabIndex = 9;
            this.numRooms.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numRooms.Maximum = new decimal(new int[] {10, 0, 0, 0});
            this.numRooms.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(16, 60);
            this.lblArea.Name = "lblArea";
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Площадь, м²";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(110, 56);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(90, 26);
            this.txtArea.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(220, 60);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Цена, руб/мес";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(320, 56);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 26);
            this.txtPrice.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(440, 60);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Статус";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Location = new System.Drawing.Point(495, 56);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(140, 26);
            this.cmbStatus.TabIndex = 15;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] {"Свободна", "Сдана"});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(680, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 36);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(680, 52);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 36);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Сохранить изменения";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(680, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 36);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(20, 566);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(400, 20);
            this.lblCount.TabIndex = 19;
            this.lblCount.Text = "";
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            this.lblCount.Tag = "muted";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(780, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(920, 620);
            this.pnlEdit.Controls.Add(this.lblAddr);
            this.pnlEdit.Controls.Add(this.txtAddr);
            this.pnlEdit.Controls.Add(this.lblRoomsN);
            this.pnlEdit.Controls.Add(this.numRooms);
            this.pnlEdit.Controls.Add(this.lblArea);
            this.pnlEdit.Controls.Add(this.txtArea);
            this.pnlEdit.Controls.Add(this.lblPrice);
            this.pnlEdit.Controls.Add(this.txtPrice);
            this.pnlEdit.Controls.Add(this.lblStatus);
            this.pnlEdit.Controls.Add(this.cmbStatus);
            this.pnlEdit.Controls.Add(this.btnAdd);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbRooms);
            this.Controls.Add(this.chkFree);
            this.Controls.Add(this.dgvApartments);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnClose);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MinimumSize = new System.Drawing.Size(920, 620);
            this.Name = "Form3";
            this.Text = "Квартиры";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.CheckBox chkFree;
        private System.Windows.Forms.DataGridView dgvApartments;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label lblRoomsN;
        private System.Windows.Forms.NumericUpDown numRooms;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnClose;
    }
}
