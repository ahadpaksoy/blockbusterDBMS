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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; user ID=postgres;Database=blockbusterDB;password=180951");

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM inventory";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO inventory(inventory_id,film_id,store_id,last_update) values (@p1,@p2,@p3,@p4)", baglanti);
            command1.Parameters.AddWithValue("@p1", int.Parse(mskd_inventory_id.Text));
            command1.Parameters.AddWithValue("@p2", int.Parse(mskd_film_id.Text));
            command1.Parameters.AddWithValue("@p3", int.Parse(mskd_store_id.Text));
            command1.Parameters.AddWithValue("@p4", dateTimeInventory.Value);

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
            NpgsqlCommand command2 = new NpgsqlCommand("DELETE FROM inventory WHERE invenytory_id=@p1", baglanti);
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                command2.Parameters.AddWithValue("@p1", int.Parse(mskd_inventory_id.Text));
                command2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Successfully deleted!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("UPDATE inventory SET film_id=@p1,store_id=@p2,last_update=@p4 where inventory_id=@p4", baglanti);

            command3.Parameters.AddWithValue("@p1", int.Parse(mskd_film_id.Text));
            command3.Parameters.AddWithValue("@p2", int.Parse(mskd_store_id.Text));
            command3.Parameters.AddWithValue("@p3", dateTimeInventory.Value);
            command3.Parameters.AddWithValue("@p4", int.Parse(mskd_inventory_id.Text));
            command3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film successfully updated!");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;

            bs.Filter = "inventory_id like '%" + Convert.ToInt32(mskd_inventory_id.Text) + "%'";
            dataGridView1.DataSource = bs;
            baglanti.Close();
        }
    }
}
