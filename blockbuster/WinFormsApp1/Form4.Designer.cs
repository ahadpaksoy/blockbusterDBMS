
namespace WinFormsApp1
{
    partial class inventory
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.inventory_id = new System.Windows.Forms.Label();
            this.film_id = new System.Windows.Forms.Label();
            this.store_id = new System.Windows.Forms.Label();
            this.last_update = new System.Windows.Forms.Label();
            this.mskd_store_id = new System.Windows.Forms.MaskedTextBox();
            this.mskd_film_id = new System.Windows.Forms.MaskedTextBox();
            this.mskd_inventory_id = new System.Windows.Forms.MaskedTextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dateTimeInventory = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(881, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(661, 529);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 69);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(661, 444);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(188, 69);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(661, 359);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 69);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(661, 273);
            this.btnView.Margin = new System.Windows.Forms.Padding(5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(188, 69);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // inventory_id
            // 
            this.inventory_id.AutoSize = true;
            this.inventory_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventory_id.Location = new System.Drawing.Point(162, 362);
            this.inventory_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventory_id.Name = "inventory_id";
            this.inventory_id.Size = new System.Drawing.Size(134, 28);
            this.inventory_id.TabIndex = 14;
            this.inventory_id.Text = "INVENTORY_ID";
            // 
            // film_id
            // 
            this.film_id.AutoSize = true;
            this.film_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.film_id.Location = new System.Drawing.Point(215, 411);
            this.film_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.film_id.Name = "film_id";
            this.film_id.Size = new System.Drawing.Size(78, 28);
            this.film_id.TabIndex = 15;
            this.film_id.Text = "FILM_ID";
            // 
            // store_id
            // 
            this.store_id.AutoSize = true;
            this.store_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.store_id.Location = new System.Drawing.Point(203, 457);
            this.store_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.store_id.Name = "store_id";
            this.store_id.Size = new System.Drawing.Size(92, 28);
            this.store_id.TabIndex = 16;
            this.store_id.Text = "STORE_ID";
            // 
            // last_update
            // 
            this.last_update.AutoSize = true;
            this.last_update.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.last_update.Location = new System.Drawing.Point(176, 501);
            this.last_update.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.last_update.Name = "last_update";
            this.last_update.Size = new System.Drawing.Size(117, 28);
            this.last_update.TabIndex = 17;
            this.last_update.Text = "LAST UPDATE";
            // 
            // mskd_store_id
            // 
            this.mskd_store_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_store_id.Location = new System.Drawing.Point(305, 454);
            this.mskd_store_id.Name = "mskd_store_id";
            this.mskd_store_id.Size = new System.Drawing.Size(247, 31);
            this.mskd_store_id.TabIndex = 20;
            // 
            // mskd_film_id
            // 
            this.mskd_film_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_film_id.Location = new System.Drawing.Point(305, 408);
            this.mskd_film_id.Name = "mskd_film_id";
            this.mskd_film_id.Size = new System.Drawing.Size(247, 31);
            this.mskd_film_id.TabIndex = 21;
            // 
            // mskd_inventory_id
            // 
            this.mskd_inventory_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskd_inventory_id.Location = new System.Drawing.Point(305, 359);
            this.mskd_inventory_id.Name = "mskd_inventory_id";
            this.mskd_inventory_id.Size = new System.Drawing.Size(247, 31);
            this.mskd_inventory_id.TabIndex = 18;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.Location = new System.Drawing.Point(13, 625);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(125, 50);
            this.btnMenu.TabIndex = 23;
            this.btnMenu.Text = "MAIN MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dateTimeInventory
            // 
            this.dateTimeInventory.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeInventory.Location = new System.Drawing.Point(305, 502);
            this.dateTimeInventory.Name = "dateTimeInventory";
            this.dateTimeInventory.Size = new System.Drawing.Size(249, 31);
            this.dateTimeInventory.TabIndex = 24;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(661, 606);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(188, 69);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 685);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dateTimeInventory);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.mskd_film_id);
            this.Controls.Add(this.mskd_store_id);
            this.Controls.Add(this.mskd_inventory_id);
            this.Controls.Add(this.last_update);
            this.Controls.Add(this.store_id);
            this.Controls.Add(this.film_id);
            this.Controls.Add(this.inventory_id);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "inventory";
            this.Text = "inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label inventory_id;
        private System.Windows.Forms.Label film_id;
        private System.Windows.Forms.Label store_id;
        private System.Windows.Forms.Label last_update;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox mskd_store_id;
        private System.Windows.Forms.MaskedTextBox mskd_film_id;
        private System.Windows.Forms.MaskedTextBox mskd_inventory_id;
        private System.Windows.Forms.DateTimePicker dateTimeInventory;
        private System.Windows.Forms.Button btn_search;
    }
}