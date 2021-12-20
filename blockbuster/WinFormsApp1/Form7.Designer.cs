
namespace WinFormsApp1
{
    partial class rental
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
            this.dataGridViewRental = new System.Windows.Forms.DataGridView();
            this.rentl_date = new System.Windows.Forms.Label();
            this.inventory_id = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.Label();
            this.return_date = new System.Windows.Forms.Label();
            this.staff_id = new System.Windows.Forms.Label();
            this.last_update = new System.Windows.Forms.Label();
            this.mskd_customer_id = new System.Windows.Forms.MaskedTextBox();
            this.mskd_staff_id = new System.Windows.Forms.MaskedTextBox();
            this.mskd_inventory_id = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.mskd_rental_id = new System.Windows.Forms.MaskedTextBox();
            this.labelRentalID = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dateTimePickerRentalDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRental
            // 
            this.dataGridViewRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRental.Location = new System.Drawing.Point(0, -1);
            this.dataGridViewRental.Name = "dataGridViewRental";
            this.dataGridViewRental.RowTemplate.Height = 25;
            this.dataGridViewRental.Size = new System.Drawing.Size(801, 176);
            this.dataGridViewRental.TabIndex = 0;
            // 
            // rentl_date
            // 
            this.rentl_date.AutoSize = true;
            this.rentl_date.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentl_date.Location = new System.Drawing.Point(165, 241);
            this.rentl_date.Name = "rentl_date";
            this.rentl_date.Size = new System.Drawing.Size(117, 28);
            this.rentl_date.TabIndex = 2;
            this.rentl_date.Text = "RENTAL DATE";
            // 
            // inventory_id
            // 
            this.inventory_id.AutoSize = true;
            this.inventory_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventory_id.Location = new System.Drawing.Point(150, 280);
            this.inventory_id.Name = "inventory_id";
            this.inventory_id.Size = new System.Drawing.Size(134, 28);
            this.inventory_id.TabIndex = 3;
            this.inventory_id.Text = "INVENTORY_ID";
            // 
            // customer_id
            // 
            this.customer_id.AutoSize = true;
            this.customer_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customer_id.Location = new System.Drawing.Point(152, 320);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(130, 28);
            this.customer_id.TabIndex = 4;
            this.customer_id.Text = "CUSTOMER_ID";
            // 
            // return_date
            // 
            this.return_date.AutoSize = true;
            this.return_date.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.return_date.Location = new System.Drawing.Point(164, 356);
            this.return_date.Name = "return_date";
            this.return_date.Size = new System.Drawing.Size(118, 28);
            this.return_date.TabIndex = 5;
            this.return_date.Text = "RETURN DATE";
            // 
            // staff_id
            // 
            this.staff_id.AutoSize = true;
            this.staff_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staff_id.Location = new System.Drawing.Point(192, 393);
            this.staff_id.Name = "staff_id";
            this.staff_id.Size = new System.Drawing.Size(90, 28);
            this.staff_id.TabIndex = 6;
            this.staff_id.Text = "STAFF_ID";
            // 
            // last_update
            // 
            this.last_update.AutoSize = true;
            this.last_update.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.last_update.Location = new System.Drawing.Point(166, 430);
            this.last_update.Name = "last_update";
            this.last_update.Size = new System.Drawing.Size(117, 28);
            this.last_update.TabIndex = 7;
            this.last_update.Text = "LAST UPDATE";
            // 
            // mskd_customer_id
            // 
            this.mskd_customer_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_customer_id.Location = new System.Drawing.Point(288, 317);
            this.mskd_customer_id.Name = "mskd_customer_id";
            this.mskd_customer_id.Size = new System.Drawing.Size(262, 31);
            this.mskd_customer_id.TabIndex = 9;
            // 
            // mskd_staff_id
            // 
            this.mskd_staff_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_staff_id.Location = new System.Drawing.Point(290, 390);
            this.mskd_staff_id.Name = "mskd_staff_id";
            this.mskd_staff_id.Size = new System.Drawing.Size(260, 31);
            this.mskd_staff_id.TabIndex = 12;
            // 
            // mskd_inventory_id
            // 
            this.mskd_inventory_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_inventory_id.Location = new System.Drawing.Point(288, 280);
            this.mskd_inventory_id.Name = "mskd_inventory_id";
            this.mskd_inventory_id.Size = new System.Drawing.Size(262, 31);
            this.mskd_inventory_id.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(622, 371);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 50);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(622, 308);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 50);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(622, 241);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 50);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(622, 182);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(125, 50);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // mskd_rental_id
            // 
            this.mskd_rental_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_rental_id.Location = new System.Drawing.Point(288, 204);
            this.mskd_rental_id.Name = "mskd_rental_id";
            this.mskd_rental_id.Size = new System.Drawing.Size(261, 31);
            this.mskd_rental_id.TabIndex = 18;
            this.mskd_rental_id.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox7_MaskInputRejected);
            // 
            // labelRentalID
            // 
            this.labelRentalID.AutoSize = true;
            this.labelRentalID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRentalID.Location = new System.Drawing.Point(183, 204);
            this.labelRentalID.Name = "labelRentalID";
            this.labelRentalID.Size = new System.Drawing.Size(101, 28);
            this.labelRentalID.TabIndex = 19;
            this.labelRentalID.Text = "RENTAL_ID";
            this.labelRentalID.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.Location = new System.Drawing.Point(13, 430);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(125, 50);
            this.btnMenu.TabIndex = 23;
            this.btnMenu.Text = "MAIN MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dateTimePickerRentalDate
            // 
            this.dateTimePickerRentalDate.CalendarFont = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerRentalDate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerRentalDate.Location = new System.Drawing.Point(288, 241);
            this.dateTimePickerRentalDate.Name = "dateTimePickerRentalDate";
            this.dateTimePickerRentalDate.Size = new System.Drawing.Size(261, 31);
            this.dateTimePickerRentalDate.TabIndex = 36;
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.CalendarFont = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerReturnDate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(289, 354);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(261, 31);
            this.dateTimePickerReturnDate.TabIndex = 37;
            // 
            // dateTimePickerLastUpdate
            // 
            this.dateTimePickerLastUpdate.CalendarFont = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerLastUpdate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerLastUpdate.Location = new System.Drawing.Point(289, 430);
            this.dateTimePickerLastUpdate.Name = "dateTimePickerLastUpdate";
            this.dateTimePickerLastUpdate.Size = new System.Drawing.Size(261, 31);
            this.dateTimePickerLastUpdate.TabIndex = 38;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(622, 431);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(124, 50);
            this.btn_search.TabIndex = 39;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dateTimePickerLastUpdate);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.dateTimePickerRentalDate);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.labelRentalID);
            this.Controls.Add(this.mskd_rental_id);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.mskd_inventory_id);
            this.Controls.Add(this.mskd_staff_id);
            this.Controls.Add(this.mskd_customer_id);
            this.Controls.Add(this.last_update);
            this.Controls.Add(this.staff_id);
            this.Controls.Add(this.return_date);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.inventory_id);
            this.Controls.Add(this.rentl_date);
            this.Controls.Add(this.dataGridViewRental);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "rental";
            this.Text = "rental";
            this.Load += new System.EventHandler(this.rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRental;
        private System.Windows.Forms.Label rentl_date;
        private System.Windows.Forms.Label inventory_id;
        private System.Windows.Forms.Label customer_id;
        private System.Windows.Forms.Label return_date;
        private System.Windows.Forms.Label staff_id;
        private System.Windows.Forms.Label last_update;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.MaskedTextBox mskd_rental_id;
        private System.Windows.Forms.Label labelRentalID;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DateTimePicker dateTimePickerRentalDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastUpdate;
        private System.Windows.Forms.MaskedTextBox mskd_customer_id;
        private System.Windows.Forms.MaskedTextBox mskd_staff_id;
        private System.Windows.Forms.MaskedTextBox mskd_inventory_id;
        private System.Windows.Forms.Button btn_search;
    }
}