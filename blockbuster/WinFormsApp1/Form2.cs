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
    public partial class category : Form
    {
        public category()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; user ID=postgres;Database=blockbusterDB;password=180951");


        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM category";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO category(category_id,name,last_update) values (@p1,@p2,@p3)", baglanti);
            command1.Parameters.AddWithValue("@p1", int.Parse(category_id.Text));
            command1.Parameters.AddWithValue("@p2", textCategoryName.Text);
            command1.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
            command1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Category successfully added!");
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
            NpgsqlCommand command2 = new NpgsqlCommand("DELETE FROM category WHERE category_id=@p1", baglanti);
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                command2.Parameters.AddWithValue("@p1", int.Parse(category_id.Text));
                command2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Successfully deleted!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("UPDATE category SET name=@p1,last_update=@p2 where category_id=@p3", baglanti);
            command3.Parameters.AddWithValue("@p1", textCategoryName.Text);
            command3.Parameters.AddWithValue("@p2", dateTimePicker1.Text);
            command3.Parameters.AddWithValue("@p3", int.Parse(category_id.Text));
            command3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Category successfully updated!");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;

            bs.Filter = "name like '%" + textCategoryName.Text + "%'";
            dataGridView1.DataSource = bs;
            baglanti.Close();
        }
    }
}
