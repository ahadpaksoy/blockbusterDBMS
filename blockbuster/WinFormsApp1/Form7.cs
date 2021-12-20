using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    public partial class rental : Form
    {
        public rental()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; user ID=postgres;Database=blockbusterDB;password=180951");
        private void rental_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM rental";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewRental.DataSource = ds.Tables[0];
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menu1 main_menu = new WinFormsApp1.menu1();
            main_menu.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO rental(rental_id,rental_date,inventory_id,customer_id,return_date,staff_id,last_update) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            command1.Parameters.AddWithValue("@p1", int.Parse(mskd_rental_id.Text));
            command1.Parameters.AddWithValue("@p2", dateTimePickerRentalDate.Value);
            command1.Parameters.AddWithValue("@p3", int.Parse(mskd_inventory_id.Text));
            command1.Parameters.AddWithValue("@p4", int.Parse(mskd_customer_id.Text));
            command1.Parameters.AddWithValue("@p5", dateTimePickerReturnDate.Value);
            command1.Parameters.AddWithValue("@p6", int.Parse(mskd_staff_id.Text));
            command1.Parameters.AddWithValue("@p7", dateTimePickerLastUpdate.Value);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("DELETE FROM rental WHERE rental_id=@p1", baglanti);
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                command2.Parameters.AddWithValue("@p1", int.Parse(mskd_rental_id.Text));
                command2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Successfully deleted!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("UPDATE rental SET rental_date=@p1,inventory_id=@p2,customer_id=@p3,return_date=@p4,staff_id=@p5,last_update=@p6 where rental_id=@p7", baglanti);

            command3.Parameters.AddWithValue("@p1", dateTimePickerRentalDate.Value);
            command3.Parameters.AddWithValue("@p2", int.Parse(mskd_inventory_id.Text));
            command3.Parameters.AddWithValue("@p3", int.Parse(mskd_customer_id.Text));
            command3.Parameters.AddWithValue("@p4", dateTimePickerReturnDate.Text);
            command3.Parameters.AddWithValue("@p5", int.Parse(mskd_staff_id.Text));
            command3.Parameters.AddWithValue("@p6", dateTimePickerLastUpdate.Value);
            command3.Parameters.AddWithValue("@p7", int.Parse(mskd_staff_id.Text));
            command3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rental film successfully updated!");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridViewRental.DataSource;

            bs.Filter = "rental_id like '%" +Convert.ToInt32(mskd_rental_id.Text)+ "%'";
            dataGridViewRental.DataSource = bs;
            baglanti.Close();
        }
    }
}
