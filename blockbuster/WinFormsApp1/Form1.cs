using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace WinFormsApp1
{
    public partial class film : Form
    {
        public film()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; user ID=postgres;Database=blockbusterDB;password=180951");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO film(film_id,title,description,release_year,language_id,lenght,replacement_cost,rating,last_update) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            command1.Parameters.AddWithValue("@p1", int.Parse(film_id.Text));
            command1.Parameters.AddWithValue("@p2", textTitle.Text);
            command1.Parameters.AddWithValue("@p3", textDescription.Text);
            command1.Parameters.AddWithValue("@p4", dateRelaseYear.Value);
            command1.Parameters.AddWithValue("@p5", textLanguageID.Text);
            command1.Parameters.AddWithValue("@p6", int.Parse(textLenght.Text));
            command1.Parameters.AddWithValue("@p7", int.Parse(textReplacementCost.Text));
            command1.Parameters.AddWithValue("@p8", textRating.Text);
            command1.Parameters.AddWithValue("@p9", dateLastUpdate.Value);
            command1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film successfully added!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM film";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
            NpgsqlCommand command2 = new NpgsqlCommand("DELETE FROM film WHERE film_id=@p1",baglanti);
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                command2.Parameters.AddWithValue("@p1", int.Parse(film_id.Text));
                command2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Successfully deleted!");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("UPDATE film SET title=@p1,description=@p2,release_year=@p3,language_id=@p4,lenght=@p5,replacement_cost=@p6,rating=@p7,last_update=@p8 where film_id=@p9", baglanti);
            command3.Parameters.AddWithValue("@p1", textTitle.Text);
            command3.Parameters.AddWithValue("@p2", textDescription.Text);
            command3.Parameters.AddWithValue("@p3", dateRelaseYear.Value);
            command3.Parameters.AddWithValue("@p4", textLanguageID.Text);
            command3.Parameters.AddWithValue("@p5", int.Parse(textLenght.Text));
            command3.Parameters.AddWithValue("@p6", int.Parse(textReplacementCost.Text));
            command3.Parameters.AddWithValue("@p7", textRating.Text);
            command3.Parameters.AddWithValue("@p8", dateLastUpdate.Value);
            command3.Parameters.AddWithValue("@p9", int.Parse(film_id.Text));
            command3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film successfully updated!");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;

            bs.Filter = "title like '%" + textTitle.Text + "%'";
            dataGridView1.DataSource = bs;
            baglanti.Close();
        }
    }
}
