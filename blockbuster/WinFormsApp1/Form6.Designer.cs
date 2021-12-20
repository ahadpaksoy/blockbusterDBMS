
namespace WinFormsApp1
{
    partial class menu1
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
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.category = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.rental = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.Button();
            this.btnActor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(114, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 114);
            this.button1.TabIndex = 0;
            this.button1.Text = "STAFF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.category.Location = new System.Drawing.Point(114, 275);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(123, 114);
            this.category.TabIndex = 1;
            this.category.Text = "CATEGORY";
            this.category.UseVisualStyleBackColor = true;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(348, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 114);
            this.button3.TabIndex = 2;
            this.button3.Text = "INVENTORY";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(566, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 114);
            this.button4.TabIndex = 3;
            this.button4.Text = "FILM";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(348, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 114);
            this.button5.TabIndex = 4;
            this.button5.Text = "CUSTOMER";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // rental
            // 
            this.rental.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rental.Location = new System.Drawing.Point(566, 35);
            this.rental.Name = "rental";
            this.rental.Size = new System.Drawing.Size(123, 114);
            this.rental.TabIndex = 5;
            this.rental.Text = "RENTAL";
            this.rental.UseVisualStyleBackColor = true;
            this.rental.Click += new System.EventHandler(this.rental_Click);
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(114, 155);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(123, 114);
            this.address.TabIndex = 6;
            this.address.Text = "ADDRESS";
            this.address.UseVisualStyleBackColor = true;
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // btnActor
            // 
            this.btnActor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActor.Location = new System.Drawing.Point(566, 161);
            this.btnActor.Name = "btnActor";
            this.btnActor.Size = new System.Drawing.Size(123, 114);
            this.btnActor.TabIndex = 7;
            this.btnActor.Text = "ACTOR";
            this.btnActor.UseVisualStyleBackColor = true;
            this.btnActor.Click += new System.EventHandler(this.btnActor_Click);
            // 
            // menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActor);
            this.Controls.Add(this.address);
            this.Controls.Add(this.rental);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.category);
            this.Controls.Add(this.button1);
            this.Name = "menu1";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button rental;
        private System.Windows.Forms.Button address;
        private System.Windows.Forms.Button btnActor;
    }
}