using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barber
{
    public partial class BookingForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-0SQR7EBD\\DZAKYHANIFANNAFI;" +
            "Initial Catalog=BarberShop;Integrated Security=True";
        public BookingForm()
        {
            InitializeComponent();
        }

        public void clearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            this.pembookinganTableAdapter.Fill(this.barberShopDataSet.Pembookingan);
            clearForm();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Get values from text boxes
            string nama = textBox1.Text;
            string nomorTelepon = textBox2.Text;
            string waktuBooking = textBox3.Text;

            // Validation (you can add more validation here)
            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Please enter the customer name.");
                return;
            }
            if (string.IsNullOrEmpty(nomorTelepon))
            {
                MessageBox.Show("Please enter the phone number.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Pembookingan (Nama, NomorTelepon, WaktuBooking) VALUES (@Nama, @NomorTelepon, @WaktuBooking)", conn);
                    cmd.Parameters.AddWithValue("@Nama", nama);
                    cmd.Parameters.AddWithValue("@NomorTelepon", nomorTelepon);
                    cmd.Parameters.AddWithValue("@WaktuBooking", waktuBooking);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking added successfully.");
                    this.pembookinganTableAdapter.Fill(this.barberShopDataSet.Pembookingan); // Refresh data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding booking: " + ex.Message);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (pembookinganDataGridView.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(pembookinganDataGridView.SelectedRows[0].Cells["Id_booking"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Pembookingan WHERE Id_booking = @BookingId", conn);
                        cmd.Parameters.AddWithValue("@BookingId", bookingId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Booking deleted successfully.");
                        this.pembookinganTableAdapter.Fill(this.barberShopDataSet.Pembookingan); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting booking: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to delete.");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (pembookinganDataGridView.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(pembookinganDataGridView.SelectedRows[0].Cells["Id_booking"].Value);

                string nama = textBox1.Text;
                string nomorTelepon = textBox2.Text;
                string waktuBooking = textBox3.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Pembookingan SET Nama = @Nama, NomorTelepon = @NomorTelepon, WaktuBooking = @WaktuBooking WHERE Id_booking = @BookingId", conn);
                        cmd.Parameters.AddWithValue("@Nama", nama);
                        cmd.Parameters.AddWithValue("@NomorTelepon", nomorTelepon);
                        cmd.Parameters.AddWithValue("@WaktuBooking", waktuBooking);
                        cmd.Parameters.AddWithValue("@BookingId", bookingId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Booking updated successfully.");
                        this.pembookinganTableAdapter.Fill(this.barberShopDataSet.Pembookingan); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating booking: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to update.");
            }
        }
    }
}