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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; user ID=postgres;Database=blockbusterDB;password=180951");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void mskd_customerID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customer";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO customer(customer_id,store_id,first_name,last_name,email,address_id,activebool,create_date,last_update) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            command1.Parameters.AddWithValue("@p1", int.Parse(mskd_customerID.Text));
            command1.Parameters.AddWithValue("@p2", int.Parse(mskd_storeID.Text));
            command1.Parameters.AddWithValue("@p3", mskd_fName.Text);
            command1.Parameters.AddWithValue("@p4", mskd_lName.Text);
            command1.Parameters.AddWithValue("@p5", mskd_mail.Text);
            command1.Parameters.AddWithValue("@p6", mskd_addressID);
            command1.Parameters.AddWithValue("@p7", bool.Parse(mskd_activeBool.Text));
            command1.Parameters.AddWithValue("@p8", dateTimePickerCreateDate.Value);
            command1.Parameters.AddWithValue("@p9", dateTimePickerLastUpdate.Value);

            command1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Address successfully added!");
        }

        private void btn_main_menu_Click(object sender, EventArgs e)
        {
            menu1 main_menu = new WinFormsApp1.menu1();
            main_menu.Show();
            this.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("DELETE FROM customer WHERE customer_id=@p1", baglanti);
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                command2.Parameters.AddWithValue("@p1", int.Parse(mskd_customerID.Text));
                command2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Successfully deleted!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("UPDATE customer SET store_id=@p1,first_name=@p2,last_name=@p3,email=@p4,address_id=@p5,activebool=@p6,create_date=@p7,last_update=@p8 where film_id=@p9", baglanti);
            
            command3.Parameters.AddWithValue("@p1", int.Parse(mskd_storeID.Text));
            command3.Parameters.AddWithValue("@p2", mskd_fName.Text);
            command3.Parameters.AddWithValue("@p3", mskd_lName.Text);
            command3.Parameters.AddWithValue("@p4", mskd_mail.Text);
            command3.Parameters.AddWithValue("@p5", mskd_addressID);
            command3.Parameters.AddWithValue("@p6", bool.Parse(mskd_activeBool.Text));
            command3.Parameters.AddWithValue("@p7", dateTimePickerCreateDate.Value);
            command3.Parameters.AddWithValue("@p8", dateTimePickerLastUpdate.Value);
            command3.Parameters.AddWithValue("@p9", int.Parse(mskd_customerID.Text));
            command3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film successfully updated!");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;

            bs.Filter = "first_name like '%" + mskd_fName.Text + "%'";
            dataGridView1.DataSource = bs;
            baglanti.Close();
        }
    }
}
