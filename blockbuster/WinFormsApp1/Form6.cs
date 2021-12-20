using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class menu1 : Form
    {
        public menu1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            film flm = new WinFormsApp1.film();
            flm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customer customer = new WinFormsApp1.customer();
            customer.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staff stff = new WinFormsApp1.staff();
            stff.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inventory inventory = new WinFormsApp1.inventory();
            inventory.Show();
            this.Hide();
        }

        private void category_Click(object sender, EventArgs e)
        {
            category category = new WinFormsApp1.category();
            category.Show();
            this.Hide();
        }

        private void rental_Click(object sender, EventArgs e)
        {
            rental rent = new WinFormsApp1.rental();
            rent.Show();
            this.Hide();
        }

        private void address_Click(object sender, EventArgs e)
        {
            address address = new WinFormsApp1.address();
            address.Show();
            this.Hide();
        }

        private void btnActor_Click(object sender, EventArgs e)
        {
            actor actor = new WinFormsApp1.actor();
            actor.Show();
            this.Hide();
        }
    }
}
