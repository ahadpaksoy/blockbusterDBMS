
namespace WinFormsApp1
{
    partial class film
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textLanguageID = new System.Windows.Forms.TextBox();
            this.textLenght = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelReleaseYear = new System.Windows.Forms.Label();
            this.labelLenght = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelReplacementCost = new System.Windows.Forms.Label();
            this.textReplacementCost = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.textRating = new System.Windows.Forms.TextBox();
            this.dateRelaseYear = new System.Windows.Forms.DateTimePicker();
            this.last_update = new System.Windows.Forms.Label();
            this.dateLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.film_id = new System.Windows.Forms.TextBox();
            this.labelFilm_id = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(984, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(677, 258);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(124, 62);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(836, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 62);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(836, 357);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(124, 62);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(677, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 62);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textTitle
            // 
            this.textTitle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTitle.Location = new System.Drawing.Point(341, 208);
            this.textTitle.Name = "textTitle";
            this.textTitle.PlaceholderText = "e.g.:Fight Club";
            this.textTitle.Size = new System.Drawing.Size(234, 31);
            this.textTitle.TabIndex = 5;
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDescription.Location = new System.Drawing.Point(341, 255);
            this.textDescription.Name = "textDescription";
            this.textDescription.PlaceholderText = "e.g.:An imsoniac office worker and a devil-may-care soap maker from an undergroun" +
    "d...";
            this.textDescription.Size = new System.Drawing.Size(234, 31);
            this.textDescription.TabIndex = 6;
            this.textDescription.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textLanguageID
            // 
            this.textLanguageID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLanguageID.Location = new System.Drawing.Point(340, 301);
            this.textLanguageID.Name = "textLanguageID";
            this.textLanguageID.PlaceholderText = "e.g.: ENG";
            this.textLanguageID.Size = new System.Drawing.Size(234, 31);
            this.textLanguageID.TabIndex = 7;
            // 
            // textLenght
            // 
            this.textLenght.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLenght.Location = new System.Drawing.Point(341, 385);
            this.textLenght.Name = "textLenght";
            this.textLenght.PlaceholderText = "e.g.: 139 minutes";
            this.textLenght.Size = new System.Drawing.Size(234, 31);
            this.textLenght.TabIndex = 9;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(215, 258);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(119, 28);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "DESCRIPTION";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDescription.Click += new System.EventHandler(this.description_Click);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLanguage.Location = new System.Drawing.Point(206, 304);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(129, 28);
            this.labelLanguage.TabIndex = 12;
            this.labelLanguage.Text = "LANGUAGE_ID";
            this.labelLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLanguage.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelReleaseYear
            // 
            this.labelReleaseYear.AutoSize = true;
            this.labelReleaseYear.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelReleaseYear.Location = new System.Drawing.Point(210, 340);
            this.labelReleaseYear.Name = "labelReleaseYear";
            this.labelReleaseYear.Size = new System.Drawing.Size(124, 28);
            this.labelReleaseYear.TabIndex = 13;
            this.labelReleaseYear.Text = "RELEASE YEAR";
            this.labelReleaseYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelReleaseYear.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelLenght
            // 
            this.labelLenght.AutoSize = true;
            this.labelLenght.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLenght.Location = new System.Drawing.Point(257, 388);
            this.labelLenght.Name = "labelLenght";
            this.labelLenght.Size = new System.Drawing.Size(74, 28);
            this.labelLenght.TabIndex = 14;
            this.labelLenght.Text = "LENGHT";
            this.labelLenght.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLenght.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(279, 211);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(52, 28);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "TITLE";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelReplacementCost
            // 
            this.labelReplacementCost.AutoSize = true;
            this.labelReplacementCost.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelReplacementCost.Location = new System.Drawing.Point(161, 426);
            this.labelReplacementCost.Name = "labelReplacementCost";
            this.labelReplacementCost.Size = new System.Drawing.Size(174, 28);
            this.labelReplacementCost.TabIndex = 16;
            this.labelReplacementCost.Text = "REPLACEMENT COST";
            this.labelReplacementCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelReplacementCost.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textReplacementCost
            // 
            this.textReplacementCost.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textReplacementCost.Location = new System.Drawing.Point(341, 423);
            this.textReplacementCost.Name = "textReplacementCost";
            this.textReplacementCost.PlaceholderText = "e.g.:20 (pounds)";
            this.textReplacementCost.Size = new System.Drawing.Size(234, 31);
            this.textReplacementCost.TabIndex = 15;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRating.Location = new System.Drawing.Point(262, 466);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(72, 28);
            this.labelRating.TabIndex = 17;
            this.labelRating.Text = "RATING";
            // 
            // textRating
            // 
            this.textRating.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textRating.Location = new System.Drawing.Point(340, 463);
            this.textRating.Name = "textRating";
            this.textRating.PlaceholderText = "e.g:PG(BBFC)";
            this.textRating.Size = new System.Drawing.Size(234, 31);
            this.textRating.TabIndex = 18;
            this.textRating.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // dateRelaseYear
            // 
            this.dateRelaseYear.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateRelaseYear.Location = new System.Drawing.Point(341, 340);
            this.dateRelaseYear.Name = "dateRelaseYear";
            this.dateRelaseYear.Size = new System.Drawing.Size(234, 31);
            this.dateRelaseYear.TabIndex = 19;
            this.dateRelaseYear.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // last_update
            // 
            this.last_update.AutoSize = true;
            this.last_update.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.last_update.Location = new System.Drawing.Point(218, 505);
            this.last_update.Name = "last_update";
            this.last_update.Size = new System.Drawing.Size(117, 28);
            this.last_update.TabIndex = 21;
            this.last_update.Text = "LAST UPDATE";
            this.last_update.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateLastUpdate
            // 
            this.dateLastUpdate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLastUpdate.Location = new System.Drawing.Point(340, 505);
            this.dateLastUpdate.Name = "dateLastUpdate";
            this.dateLastUpdate.Size = new System.Drawing.Size(234, 31);
            this.dateLastUpdate.TabIndex = 22;
            // 
            // film_id
            // 
            this.film_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.film_id.Location = new System.Drawing.Point(341, 171);
            this.film_id.Name = "film_id";
            this.film_id.PlaceholderText = "e.g.:1";
            this.film_id.Size = new System.Drawing.Size(234, 31);
            this.film_id.TabIndex = 23;
            // 
            // labelFilm_id
            // 
            this.labelFilm_id.AutoSize = true;
            this.labelFilm_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilm_id.Location = new System.Drawing.Point(253, 171);
            this.labelFilm_id.Name = "labelFilm_id";
            this.labelFilm_id.Size = new System.Drawing.Size(78, 28);
            this.labelFilm_id.TabIndex = 24;
            this.labelFilm_id.Text = "FILM_ID";
            this.labelFilm_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.Location = new System.Drawing.Point(13, 485);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(125, 50);
            this.btnMenu.TabIndex = 25;
            this.btnMenu.Text = "MAIN MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(759, 432);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(124, 62);
            this.btn_search.TabIndex = 26;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 548);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.labelFilm_id);
            this.Controls.Add(this.film_id);
            this.Controls.Add(this.dateLastUpdate);
            this.Controls.Add(this.last_update);
            this.Controls.Add(this.dateRelaseYear);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelReplacementCost);
            this.Controls.Add(this.textReplacementCost);
            this.Controls.Add(this.labelLenght);
            this.Controls.Add(this.labelReleaseYear);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textLenght);
            this.Controls.Add(this.textLanguageID);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "film";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "film";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textLanguageID;
        private System.Windows.Forms.TextBox textLenght;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textReplacementCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.DateTimePicker dateRelaseYear;
        private System.Windows.Forms.Label last_update;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelReleaseYear;
        private System.Windows.Forms.Label labelLenght;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelReplacementCost;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.DateTimePicker dateLastUpdate;
        private System.Windows.Forms.TextBox film_id;
        private System.Windows.Forms.Label labelFilm_id;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btn_search;
    }
}

