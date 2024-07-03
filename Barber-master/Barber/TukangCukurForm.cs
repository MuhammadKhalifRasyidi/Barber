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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Barber
{
    public partial class TukangCukurForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-0SQR7EBD\\DZAKYHANIFANNAFI;Initial Catalog=BarberShop;Integrated Security=True";
        public TukangCukurForm()
        {
            InitializeComponent();
        }

        public void clearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }


        private void TukangCukurForm_Load(object sender, EventArgs e)
        {
            this.tukangCukurTableAdapter.Fill(this.barberShopDataSet.TukangCukur);
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
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TukangCukur", conn);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    tukangCukurDataGridView.DataSource = dt;
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO TukangCukur (Nama, JadwalKerja, Pengalaman, IdTkgCukur) VALUES (@Nama, @JadwalKerja, @Pengalaman, @IdTkgCukur)", conn);
                    cmd.Parameters.AddWithValue("@Nama", textBox2.Text);
                    cmd.Parameters.AddWithValue("@JadwalKerja", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Pengalaman", textBox4.Text);
                    cmd.Parameters.AddWithValue("@IdTkgCukur", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Barber added successfully.");
                    LoadData(); // Refresh data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding barber: " + ex.Message);
                }
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (tukangCukurDataGridView.SelectedRows.Count > 0)
            {
                string idTkgCukur = tukangCukurDataGridView.SelectedRows[0].Cells["IdTkgCukur"].Value.ToString();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM TukangCukur WHERE IdTkgCukur = @IdTkgCukur", conn);
                        cmd.Parameters.AddWithValue("@IdTkgCukur", idTkgCukur);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Barber deleted successfully.");
                        LoadData(); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting barber: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a barber to delete.");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (tukangCukurDataGridView.SelectedRows.Count > 0)
            {
                string idTkgCukur = tukangCukurDataGridView.SelectedRows[0].Cells["IdTkgCukur"].Value.ToString();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE TukangCukur SET Nama = @Nama, JadwalKerja = @JadwalKerja, Pengalaman = @Pengalaman WHERE IdTkgCukur = @IdTkgCukur", conn);
                        cmd.Parameters.AddWithValue("@Nama", textBox2.Text);
                        cmd.Parameters.AddWithValue("@JadwalKerja", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Pengalaman", textBox4.Text);
                        cmd.Parameters.AddWithValue("@IdTkgCukur", idTkgCukur);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Barber updated successfully.");
                        LoadData(); // Refresh data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating barber: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a barber to update.");
            }
        }
    }
}
