
namespace WinFormsApp1
{
    partial class customer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mskd_fName = new System.Windows.Forms.MaskedTextBox();
            this.mskd_lName = new System.Windows.Forms.MaskedTextBox();
            this.mskd_mail = new System.Windows.Forms.MaskedTextBox();
            this.mskd_addressID = new System.Windows.Forms.MaskedTextBox();
            this.mskd_activeBool = new System.Windows.Forms.MaskedTextBox();
            this.mskd_storeID = new System.Windows.Forms.MaskedTextBox();
            this.f_name = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.address_id = new System.Windows.Forms.Label();
            this.active_bool = new System.Windows.Forms.Label();
            this.create_date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.last_updaate = new System.Windows.Forms.Label();
            this.mskd_customerID = new System.Windows.Forms.MaskedTextBox();
            this.labelCustomer_id = new System.Windows.Forms.Label();
            this.dateTimePickerCreateDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.btn_main_menu = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // mskd_fName
            // 
            this.mskd_fName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_fName.Location = new System.Drawing.Point(341, 306);
            this.mskd_fName.Margin = new System.Windows.Forms.Padding(4);
            this.mskd_fName.Name = "mskd_fName";
            this.mskd_fName.Size = new System.Drawing.Size(284, 31);
            this.mskd_fName.TabIndex = 1;
            // 
            // mskd_lName
            // 
            this.mskd_lName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_lName.Location = new System.Drawing.Point(341, 343);
            this.mskd_lName.Margin = new System.Windows.Forms.Padding(4);
            this.mskd_lName.Name = "mskd_lName";
            this.mskd_lName.Size = new System.Drawing.Size(284, 31);
            this.mskd_lName.TabIndex = 2;
            // 
            // mskd_mail
            // 
            this.mskd_mail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_mail.Location = new System.Drawing.Point(341, 380);
            this.mskd_mail.Margin = new System.Windows.Forms.Padding(4);
            this.mskd_mail.Name = "mskd_mail";
            this.mskd_mail.Size = new System.Drawing.Size(284, 31);
            this.mskd_mail.TabIndex = 3;
            // 
            // mskd_addressID
            // 
            this.mskd_addressID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_addressID.Location = new System.Drawing.Point(341, 417);
            this.mskd_addressID.Margin = new System.Windows.Forms.Padding(4);
            this.mskd_addressID.Name = "mskd_addressID";
            this.mskd_addressID.Size = new System.Drawing.Size(284, 31);
            this.mskd_addressID.TabIndex = 4;
            // 
            // mskd_activeBool
            // 
            this.mskd_activeBool.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_activeBool.Location = new System.Drawing.Point(341, 453);
            this.mskd_activeBool.Margin = new System.Windows.Forms.Padding(4);
            this.mskd_activeBool.Mask = "0";
            this.mskd_activeBool.Name = "mskd_activeBool";
            this.mskd_activeBool.Size = new System.Drawing.Size(284, 31);
            this.mskd_activeBool.TabIndex = 5;
            this.mskd_activeBool.ValidatingType = typeof(int);
            // 
            // mskd_storeID
            // 
            this.mskd_storeID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_storeID.Location = new System.Drawing.Point(341, 267);
            this.mskd_storeID.Margin = new System.Windows.Forms.Padding(4);
            this.mskd_storeID.Name = "mskd_storeID";
            this.mskd_storeID.Size = new System.Drawing.Size(284, 31);
            this.mskd_storeID.TabIndex = 7;
            // 
            // f_name
            // 
            this.f_name.AutoSize = true;
            this.f_name.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.f_name.Location = new System.Drawing.Point(221, 309);
            this.f_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(109, 28);
            this.f_name.TabIndex = 8;
            this.f_name.Text = "FIRST  NAME";
            this.f_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_name.Location = new System.Drawing.Point(231, 346);
            this.l_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(102, 28);
            this.l_name.TabIndex = 9;
            this.l_name.Text = "LAST NAME";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(271, 383);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(61, 28);
            this.email.TabIndex = 10;
            this.email.Text = "EMAIL";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // address_id
            // 
            this.address_id.AutoSize = true;
            this.address_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.address_id.Location = new System.Drawing.Point(223, 420);
            this.address_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address_id.Name = "address_id";
            this.address_id.Size = new System.Drawing.Size(116, 28);
            this.address_id.TabIndex = 11;
            this.address_id.Text = "ADDRESS_ID";
            // 
            // active_bool
            // 
            this.active_bool.AutoSize = true;
            this.active_bool.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.active_bool.Location = new System.Drawing.Point(265, 453);
            this.active_bool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.active_bool.Name = "active_bool";
            this.active_bool.Size = new System.Drawing.Size(71, 28);
            this.active_bool.TabIndex = 12;
            this.active_bool.Text = "ACTIVE";
            // 
            // create_date
            // 
            this.create_date.AutoSize = true;
            this.create_date.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.create_date.Location = new System.Drawing.Point(215, 493);
            this.create_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.create_date.Name = "create_date";
            this.create_date.Size = new System.Drawing.Size(118, 28);
            this.create_date.TabIndex = 13;
            this.create_date.Text = "CREATE DATE";
            this.create_date.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(238, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "STORE_ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(718, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 62);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(877, 401);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(124, 62);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(877, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 62);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(718, 302);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(124, 62);
            this.btnView.TabIndex = 15;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // last_updaate
            // 
            this.last_updaate.AutoSize = true;
            this.last_updaate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.last_updaate.Location = new System.Drawing.Point(215, 529);
            this.last_updaate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.last_updaate.Name = "last_updaate";
            this.last_updaate.Size = new System.Drawing.Size(126, 28);
            this.last_updaate.TabIndex = 20;
            this.last_updaate.Text = "LAST_UPDATE";
            // 
            // mskd_customerID
            // 
            this.mskd_customerID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_customerID.Location = new System.Drawing.Point(341, 228);
            this.mskd_customerID.Margin = new System.Windows.Forms.Padding(4);
            this.mskd_customerID.Name = "mskd_customerID";
            this.mskd_customerID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mskd_customerID.Size = new System.Drawing.Size(284, 31);
            this.mskd_customerID.TabIndex = 21;
            this.mskd_customerID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskd_customerID_MaskInputRejected);
            // 
            // labelCustomer_id
            // 
            this.labelCustomer_id.AutoSize = true;
            this.labelCustomer_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomer_id.Location = new System.Drawing.Point(206, 231);
            this.labelCustomer_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomer_id.Name = "labelCustomer_id";
            this.labelCustomer_id.Size = new System.Drawing.Size(130, 28);
            this.labelCustomer_id.TabIndex = 22;
            this.labelCustomer_id.Text = "CUSTOMER_ID";
            // 
            // dateTimePickerCreateDate
            // 
            this.dateTimePickerCreateDate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerCreateDate.Location = new System.Drawing.Point(340, 490);
            this.dateTimePickerCreateDate.Name = "dateTimePickerCreateDate";
            this.dateTimePickerCreateDate.Size = new System.Drawing.Size(284, 31);
            this.dateTimePickerCreateDate.TabIndex = 24;
            // 
            // dateTimePickerLastUpdate
            // 
            this.dateTimePickerLastUpdate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerLastUpdate.Location = new System.Drawing.Point(341, 526);
            this.dateTimePickerLastUpdate.Name = "dateTimePickerLastUpdate";
            this.dateTimePickerLastUpdate.Size = new System.Drawing.Size(284, 31);
            this.dateTimePickerLastUpdate.TabIndex = 25;
            // 
            // btn_main_menu
            // 
            this.btn_main_menu.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_main_menu.Location = new System.Drawing.Point(12, 490);
            this.btn_main_menu.Name = "btn_main_menu";
            this.btn_main_menu.Size = new System.Drawing.Size(124, 62);
            this.btn_main_menu.TabIndex = 26;
            this.btn_main_menu.Text = "MAIN MENU";
            this.btn_main_menu.UseVisualStyleBackColor = true;
            this.btn_main_menu.Click += new System.EventHandler(this.btn_main_menu_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(801, 476);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(124, 62);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_main_menu);
            this.Controls.Add(this.dateTimePickerLastUpdate);
            this.Controls.Add(this.dateTimePickerCreateDate);
            this.Controls.Add(this.labelCustomer_id);
            this.Controls.Add(this.mskd_customerID);
            this.Controls.Add(this.last_updaate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.create_date);
            this.Controls.Add(this.active_bool);
            this.Controls.Add(this.address_id);
            this.Controls.Add(this.email);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.mskd_storeID);
            this.Controls.Add(this.mskd_activeBool);
            this.Controls.Add(this.mskd_addressID);
            this.Controls.Add(this.mskd_mail);
            this.Controls.Add(this.mskd_lName);
            this.Controls.Add(this.mskd_fName);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "customer";
            this.Text = "customer";
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskd_fName;
        private System.Windows.Forms.MaskedTextBox mskd_lName;
        private System.Windows.Forms.MaskedTextBox mskd_mail;
        private System.Windows.Forms.MaskedTextBox mskd_addressID;
        private System.Windows.Forms.MaskedTextBox mskd_activeBool;
        private System.Windows.Forms.MaskedTextBox mskd_storeID;
        private System.Windows.Forms.Label f_name;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label address_id;
        private System.Windows.Forms.Label active_bool;
        private System.Windows.Forms.Label create_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label last_updaate;
        private System.Windows.Forms.MaskedTextBox mskd_customerID;
        private System.Windows.Forms.Label labelCustomer_id;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreateDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastUpdate;
        private System.Windows.Forms.Button btn_main_menu;
        private System.Windows.Forms.Button btn_search;
    }
}