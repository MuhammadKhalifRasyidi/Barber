using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barber
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instantiate the AntrianForm
            Antrian antrianForm = new Antrian();

            // Show the AntrianForm
            antrianForm.Show();

            // Optionally, hide the current form
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Instantiate the AntrianForm
            Pembookingan pembookinganForm = new Pembookingan();

            // Show the AntrianForm
            pembookinganForm.Show();

            // Optionally, hide the current form
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Instantiate the AntrianForm
            Pelanggan pelangganForm = new Pelanggan();

            // Show the AntrianForm
            pelangganForm.Show();

            // Optionally, hide the current form
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Instantiate the AntrianForm
            Tukang_Cukur TukangCukurForm = new Tukang_Cukur();

            // Show the AntrianForm
            TukangCukurForm.Show();

            // Optionally, hide the current form
            this.Hide();
        }
    }
}
