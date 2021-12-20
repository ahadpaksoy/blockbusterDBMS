
using System;

namespace WinFormsApp1
{
    partial class staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.f_name = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.address_id = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.store_id = new System.Windows.Forms.Label();
            this.active = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.last_update = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.mskd_first_name = new System.Windows.Forms.MaskedTextBox();
            this.mskd_last_name = new System.Windows.Forms.MaskedTextBox();
            this.mskd_email = new System.Windows.Forms.MaskedTextBox();
            this.mksd_active = new System.Windows.Forms.MaskedTextBox();
            this.mksd_username = new System.Windows.Forms.MaskedTextBox();
            this.mskd_password = new System.Windows.Forms.MaskedTextBox();
            this.labelStaffID = new System.Windows.Forms.Label();
            this.mskd_staffID = new System.Windows.Forms.MaskedTextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dateTimePickerStaff = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownAddressID = new System.Windows.Forms.NumericUpDown();
            this.numericUpStoreID = new System.Windows.Forms.NumericUpDown();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddressID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpStoreID)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(1, -3);
            this.dataGridViewStaff.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowTemplate.Height = 25;
            this.dataGridViewStaff.Size = new System.Drawing.Size(1226, 207);
            this.dataGridViewStaff.TabIndex = 0;
            // 
            // f_name
            // 
            this.f_name.AutoSize = true;
            this.f_name.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.f_name.Location = new System.Drawing.Point(293, 254);
            this.f_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(106, 28);
            this.f_name.TabIndex = 1;
            this.f_name.Text = "FIRST NAME";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_name.Location = new System.Drawing.Point(293, 295);
            this.l_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(102, 28);
            this.l_name.TabIndex = 2;
            this.l_name.Text = "LAST NAME";
            // 
            // address_id
            // 
            this.address_id.AutoSize = true;
            this.address_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.address_id.Location = new System.Drawing.Point(284, 343);
            this.address_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address_id.Name = "address_id";
            this.address_id.Size = new System.Drawing.Size(116, 28);
            this.address_id.TabIndex = 3;
            this.address_id.Text = "ADDRESS_ID";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(334, 386);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(61, 28);
            this.email.TabIndex = 4;
            this.email.Text = "EMAIL";
            // 
            // store_id
            // 
            this.store_id.AutoSize = true;
            this.store_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.store_id.Location = new System.Drawing.Point(307, 434);
            this.store_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.store_id.Name = "store_id";
            this.store_id.Size = new System.Drawing.Size(92, 28);
            this.store_id.TabIndex = 5;
            this.store_id.Text = "STORE_ID";
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.active.Location = new System.Drawing.Point(324, 484);
            this.active.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(71, 28);
            this.active.TabIndex = 6;
            this.active.Text = "ACTIVE";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(295, 522);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 28);
            this.username.TabIndex = 7;
            this.username.Text = "USERNAME";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(293, 567);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(106, 28);
            this.password.TabIndex = 8;
            this.password.Text = "PASSWORD";
            // 
            // last_update
            // 
            this.last_update.AutoSize = true;
            this.last_update.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.last_update.Location = new System.Drawing.Point(283, 609);
            this.last_update.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.last_update.Name = "last_update";
            this.last_update.Size = new System.Drawing.Size(117, 28);
            this.last_update.TabIndex = 9;
            this.last_update.Text = "LAST UPDATE";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(782, 446);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 98);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(1021, 446);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(192, 98);
            this.btnDel.TabIndex = 21;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(1021, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(192, 98);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(782, 289);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(192, 98);
            this.btnView.TabIndex = 19;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // mskd_first_name
            // 
            this.mskd_first_name.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_first_name.Location = new System.Drawing.Point(433, 251);
            this.mskd_first_name.Name = "mskd_first_name";
            this.mskd_first_name.Size = new System.Drawing.Size(277, 31);
            this.mskd_first_name.TabIndex = 23;
            // 
            // mskd_last_name
            // 
            this.mskd_last_name.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_last_name.Location = new System.Drawing.Point(433, 292);
            this.mskd_last_name.Name = "mskd_last_name";
            this.mskd_last_name.Size = new System.Drawing.Size(277, 31);
            this.mskd_last_name.TabIndex = 24;
            // 
            // mskd_email
            // 
            this.mskd_email.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_email.Location = new System.Drawing.Point(433, 383);
            this.mskd_email.Name = "mskd_email";
            this.mskd_email.Size = new System.Drawing.Size(277, 31);
            this.mskd_email.TabIndex = 26;
            // 
            // mksd_active
            // 
            this.mksd_active.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mksd_active.Location = new System.Drawing.Point(433, 482);
            this.mksd_active.Mask = "0";
            this.mksd_active.Name = "mksd_active";
            this.mksd_active.Size = new System.Drawing.Size(277, 31);
            this.mksd_active.TabIndex = 28;
            this.mksd_active.ValidatingType = typeof(int);
            // 
            // mksd_username
            // 
            this.mksd_username.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mksd_username.Location = new System.Drawing.Point(433, 519);
            this.mksd_username.Name = "mksd_username";
            this.mksd_username.Size = new System.Drawing.Size(277, 31);
            this.mksd_username.TabIndex = 29;
            // 
            // mskd_password
            // 
            this.mskd_password.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_password.Location = new System.Drawing.Point(433, 564);
            this.mskd_password.Name = "mskd_password";
            this.mskd_password.Size = new System.Drawing.Size(277, 31);
            this.mskd_password.TabIndex = 30;
            // 
            // labelStaffID
            // 
            this.labelStaffID.AutoSize = true;
            this.labelStaffID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStaffID.Location = new System.Drawing.Point(310, 214);
            this.labelStaffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(90, 28);
            this.labelStaffID.TabIndex = 32;
            this.labelStaffID.Text = "STAFF_ID";
            // 
            // mskd_staffID
            // 
            this.mskd_staffID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_staffID.Location = new System.Drawing.Point(433, 211);
            this.mskd_staffID.Name = "mskd_staffID";
            this.mskd_staffID.Size = new System.Drawing.Size(277, 31);
            this.mskd_staffID.TabIndex = 33;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.Location = new System.Drawing.Point(13, 605);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(125, 50);
            this.btnMenu.TabIndex = 34;
            this.btnMenu.Text = "MAIN MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dateTimePickerStaff
            // 
            this.dateTimePickerStaff.CalendarFont = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStaff.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStaff.Location = new System.Drawing.Point(433, 606);
            this.dateTimePickerStaff.Name = "dateTimePickerStaff";
            this.dateTimePickerStaff.Size = new System.Drawing.Size(277, 31);
            this.dateTimePickerStaff.TabIndex = 35;
            // 
            // numericUpDownAddressID
            // 
            this.numericUpDownAddressID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownAddressID.Location = new System.Drawing.Point(433, 343);
            this.numericUpDownAddressID.Name = "numericUpDownAddressID";
            this.numericUpDownAddressID.Size = new System.Drawing.Size(277, 31);
            this.numericUpDownAddressID.TabIndex = 36;
            this.numericUpDownAddressID.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpStoreID
            // 
            this.numericUpStoreID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpStoreID.Location = new System.Drawing.Point(433, 431);
            this.numericUpStoreID.Name = "numericUpStoreID";
            this.numericUpStoreID.Size = new System.Drawing.Size(277, 31);
            this.numericUpStoreID.TabIndex = 37;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(906, 557);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(192, 98);
            this.btn_search.TabIndex = 38;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 668);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.numericUpStoreID);
            this.Controls.Add(this.numericUpDownAddressID);
            this.Controls.Add(this.dateTimePickerStaff);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.mskd_staffID);
            this.Controls.Add(this.labelStaffID);
            this.Controls.Add(this.mskd_password);
            this.Controls.Add(this.mksd_username);
            this.Controls.Add(this.mksd_active);
            this.Controls.Add(this.mskd_email);
            this.Controls.Add(this.mskd_last_name);
            this.Controls.Add(this.mskd_first_name);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.last_update);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.active);
            this.Controls.Add(this.store_id);
            this.Controls.Add(this.email);
            this.Controls.Add(this.address_id);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.dataGridViewStaff);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "staff";
            this.Text = "staff";
            this.Load += new System.EventHandler(this.staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddressID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpStoreID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.Label f_name;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label address_id;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label store_id;
        private System.Windows.Forms.Label active;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label last_update;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.Label labelStaffID;
        private System.Windows.Forms.MaskedTextBox mskd_staffID;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.MaskedTextBox mskd_first_name;
        private System.Windows.Forms.MaskedTextBox mskd_last_name;
        private System.Windows.Forms.MaskedTextBox mskd_email;
        private System.Windows.Forms.MaskedTextBox mksd_active;
        private System.Windows.Forms.MaskedTextBox mksd_username;
        private System.Windows.Forms.MaskedTextBox mskd_password;
        private System.Windows.Forms.DateTimePicker dateTimePickerStaff;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDownAddressID;
        private System.Windows.Forms.NumericUpDown numericUpStoreıD;
        private System.Windows.Forms.NumericUpDown numericUpStoreID;
        private System.Windows.Forms.Button btn_search;

        public EventHandler password_Click { get; private set; }
    }
}