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
    public partial class address : Form
    {
        public address()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; user ID=postgres;Database=blockbusterDB;password=180951");

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM address";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewAddress.DataSource = ds.Tables[0];
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO address(address_id,address,city_id,postal_code,phone,last_update) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            command1.Parameters.AddWithValue("@p1", int.Parse(mskd_address_id.Text));
            command1.Parameters.AddWithValue("@p2", mskd_address.Text);
            command1.Parameters.AddWithValue("@p3", int.Parse(mskd_city_id.Text));
            command1.Parameters.AddWithValue("@p4", mskd_postal_code.Text);
            command1.Parameters.AddWithValue("@p5", mskd_phone_number.Text);
            command1.Parameters.AddWithValue("@p6", dateTimePickerAddress.Value);
            command1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Address successfully added!");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menu1 main_menu = new WinFormsApp1.menu1();
            main_menu.Show();
            this.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("DELETE FROM address WHERE address_id=@p1", baglanti);
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                command2.Parameters.AddWithValue("@p1", int.Parse(mskd_address_id.Text));
                command2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Successfully deleted!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("UPDATE address SET address=@p1,city_id=@p2,postal_code=@p3,phone=@p4,last_update=@p5 where address_id=@p6", baglanti);

            command3.Parameters.AddWithValue("@p1", mskd_address.Text);
            command3.Parameters.AddWithValue("@p2", int.Parse(mskd_city_id.Text));
            command3.Parameters.AddWithValue("@p3", mskd_postal_code.Text);
            command3.Parameters.AddWithValue("@p4", mskd_phone_number.Text);
            command3.Parameters.AddWithValue("@p5", dateTimePickerAddress);
            command3.Parameters.AddWithValue("@p6", int.Parse(mskd_address_id.Text));

            command3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Address successfully updated!");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridViewAddress.DataSource;

            bs.Filter = "address like '%" + mskd_address.Text + "%'";
            dataGridViewAddress.DataSource = bs;
            baglanti.Close();
        }
    }
}
