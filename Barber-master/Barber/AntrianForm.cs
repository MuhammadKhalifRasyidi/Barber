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
    public partial class AntrianForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-0SQR7EBD\\DZAKYHANIFANNAFI;Initial Catalog=BarberShop;Integrated Security=True";

        public AntrianForm()
        {
            InitializeComponent();
        }

        public void clearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void AntrianForm_Load(object sender, EventArgs e)
        {
            this.antrianTableAdapter.Fill(this.barberShopDataSet.Antrian);
            clearForm();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Antrian", conn);
                    DataTable antrianTable = new DataTable();
                    adapter.Fill(antrianTable);
                    antrianDataGridView.DataSource = antrianTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Antrian (Nama_pelanggan, No_antrian, Waktu_tunggu) VALUES (@Nama_pelanggan, @No_antrian, @Waktu_tunggu)", conn);
                    cmd.Parameters.AddWithValue("@Nama_pelanggan", textBox1.Text);
                    cmd.Parameters.AddWithValue("@No_antrian", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Waktu_tunggu", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Queue added successfully.");
                    LoadData(); // Refresh data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding queue: " + ex.Message);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (antrianDataGridView.SelectedRows.Count > 0)
            {
                int queueId = Convert.ToInt32(antrianDataGridView.SelectedRows[0].Cells["Id_antrian"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Antrian WHERE Id_antrian = @Id_antrian", conn);
                        cmd.Parameters.AddWithValue("@Id_antrian", queueId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Queue deleted successfully.");
                        LoadData(); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting queue: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a queue to delete.");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (antrianDataGridView.SelectedRows.Count > 0)
            {
                int queueId = Convert.ToInt32(antrianDataGridView.SelectedRows[0].Cells["Id_antrian"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Antrian SET Nama_pelanggan = @Nama_pelanggan, No_antrian = @No_antrian, Waktu_tunggu = @Waktu_tunggu WHERE Id_antrian = @Id_antrian", conn);
                        cmd.Parameters.AddWithValue("@Nama_pelanggan", textBox1.Text);
                        cmd.Parameters.AddWithValue("@No_antrian", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Waktu_tunggu", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Id_antrian", queueId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Antrian updated successfully.");
                        LoadData(); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating antrian: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an antrian to update.");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchCustomer(textBoxSearch.Text);
        }

        private void SearchCustomer(string customerName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Antrian WHERE Nama_pelanggan LIKE @Nama_pelanggan", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Nama_pelanggan", "%" + customerName + "%");
                    DataTable antrianTable = new DataTable();
                    adapter.Fill(antrianTable);
                    antrianDataGridView.DataSource = antrianTable;

                    if (antrianTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching customer found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching customer: " + ex.Message);
                }
            }
        }
    }
}
