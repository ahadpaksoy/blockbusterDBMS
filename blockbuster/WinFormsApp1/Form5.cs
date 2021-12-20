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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; user ID=postgres;Database=blockbusterDB;password=180951");

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("UPDATE staff SET first_name=@p1,last_name=@p2,address_id=@p3,email=@p4,store_id=@p5,active=@p6,username=@p7,password=@8,last_update=@9 where staff_id=@p10", baglanti);

            command3.Parameters.AddWithValue("@p1",  mskd_first_name.Text);
            command3.Parameters.AddWithValue("@p2",  mskd_last_name.Text);
            command3.Parameters.AddWithValue("@p3",  int.Parse(numericUpDownAddressID.Value.ToString()));
            command3.Parameters.AddWithValue("@p4",  mskd_email.Text);
            command3.Parameters.AddWithValue("@p5",  int.Parse(numericUpStoreID.Value.ToString()));
            command3.Parameters.AddWithValue("@p6",  bool.Parse(mksd_active.Text));
            command3.Parameters.AddWithValue("@p7",  mksd_username.Text);
            command3.Parameters.AddWithValue("@p8",  mskd_password.Text);
            command3.Parameters.AddWithValue("@p9",  dateTimePickerStaff.Value);
            command3.Parameters.AddWithValue("@p10", int.Parse(mskd_staffID.Text));
            command3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Staff successfully updated!");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("DELETE FROM staff WHERE staff_id=@p1", baglanti);
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                command2.Parameters.AddWithValue("@p1", int.Parse(mskd_staffID.Text));
                command2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Successfully deleted!");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO staff(staff_id,first_name,last_name,address_id,email,store_id,active,username,password,last_update) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
            command1.Parameters.AddWithValue("@p1",  int.Parse(mskd_staffID.Text));
            command1.Parameters.AddWithValue("@p2",  mskd_first_name.Text);
            command1.Parameters.AddWithValue("@p3",  mskd_last_name.Text);
            command1.Parameters.AddWithValue("@p4",  numericUpDownAddressID.Value);
            command1.Parameters.AddWithValue("@p5",  mskd_email.Text);
            command1.Parameters.AddWithValue("@p6",  numericUpStoreID.Value);
            command1.Parameters.AddWithValue("@p7",  bool.Parse(mksd_active.Text));
            command1.Parameters.AddWithValue("@p8",  mksd_username.Text);
            command1.Parameters.AddWithValue("@p9",  mskd_password.Text);
            command1.Parameters.AddWithValue("@p10", dateTimePickerStaff.Value);
            command1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Staff successfully added!");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM staff";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewStaff.DataSource = ds.Tables[0];
        }


        private void staff_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menu1 main_menu = new WinFormsApp1.menu1();
            main_menu.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridViewStaff.DataSource;

            bs.Filter = "first_name like '%" + mskd_first_name.Text + "%'";
            dataGridViewStaff.DataSource = bs;
            baglanti.Close();
        }
    }
}
