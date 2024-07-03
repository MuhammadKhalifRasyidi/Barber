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
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=LAPTOP-0SQR7EBD\\DZAKYHANIFANNAFI;" +
            "Initial Catalog=BarberShop;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Antrian_Click(object sender, EventArgs e)
        {
            var antrianForm = new AntrianForm();
            antrianForm.Show();
        }

        private void Pembookingan_Click(object sender, EventArgs e)
        {
            var bookingForm = new BookingForm();
            bookingForm.Show();
        }

        private void TukangCukur_Click(object sender, EventArgs e)
        {
            var tukangCukurForm = new TukangCukurForm();
            tukangCukurForm.Show();
        }

        private void DataPelanggan_Click(object sender, EventArgs e)
        {
            var pelangganForm = new PelangganForm();
            pelangganForm.Show();
        }
    }
}

