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
    public partial class PelangganForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-0SQR7EBD\\DZAKYHANIFANNAFI;" +
            "Initial Catalog=BarberShop;Integrated Security=True";

        public PelangganForm()
        {
            InitializeComponent();
        }

        public void clearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }


        private void PelangganForm_Load(object sender, EventArgs e)
        {
            // Fill the DataGridView with data from the database
            this.pelangganTableAdapter.Fill(this.barberShopDataSet.Pelanggan);
            clearForm();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Get the values from the text boxes
            string name = textBox1.Text;
            string phone = textBox2.Text;

            // Check if any field is empty
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a command to insert a new customer into the database
                    SqlCommand command = new SqlCommand("INSERT INTO Pelanggan (Name, Phone) VALUES (@Name, @Phone)", connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Phone", phone);

                    // Execute the command
                    command.ExecuteNonQuery();

                    // Show a success message
                    MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the data in the DataGridView
                    this.pelangganTableAdapter.Fill(this.barberShopDataSet.Pelanggan);

                    // Clear the text boxes
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (pelangganDataGridView.SelectedRows.Count > 0)
            {
                // Get the customer ID from the selected row
                int customerId = Convert.ToInt32(pelangganDataGridView.SelectedRows[0].Cells["CustomerId"].Value);

                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Create a command to delete the customer from the database
                        SqlCommand command = new SqlCommand("DELETE FROM Pelanggan WHERE CustomerId = @CustomerId", connection);

                        // Add a parameter to the command
                        command.Parameters.AddWithValue("@CustomerId", customerId);

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Show a success message
                        MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the data in the DataGridView
                        this.pelangganTableAdapter.Fill(this.barberShopDataSet.Pelanggan);
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Show an error message if no row is selected
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (pelangganDataGridView.SelectedRows.Count > 0)
            {
                // Get the customer ID from the selected row
                int customerId = Convert.ToInt32(pelangganDataGridView.SelectedRows[0].Cells["CustomerId"].Value);

                // Get the values from the text boxes
                string name = textBox1.Text;
                string phone = textBox2.Text;

                // Check if any field is empty
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Create a command to update the customer in the database
                        SqlCommand command = new SqlCommand("UPDATE Pelanggan SET Name = @Name, Phone = @Phone WHERE CustomerId = @CustomerId", connection);

                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@CustomerId", customerId);

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Show a success message
                        MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the data in the DataGridView
                        this.pelangganTableAdapter.Fill(this.barberShopDataSet.Pelanggan);
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        MessageBox.Show("Error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Show an error message if no row is selected
                MessageBox.Show("Please select a customer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}