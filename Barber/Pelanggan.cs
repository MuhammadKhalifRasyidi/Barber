using System;
using System.Data;
using System.Windows.Forms;

namespace Barber
{
    public partial class Pelanggan : Form
    {
        int bttn; // Variabel untuk menentukan aksi tambah (1), edit (2), dll.

        public Pelanggan()
        {
            InitializeComponent();
            dataGridViewPelanggan.CellClick += dataGridViewPelanggan_CellClick;
        }

        private void setDefaultForm()
        {
            IdPelanggan.Enabled = false;
            Nama.Enabled = false;
            NoTelepon.Enabled = false;

            bttnAdd.Enabled = true;
            bttnUpdate.Enabled = true;
            bttnDelete.Enabled = true;
            bttnSearch.Enabled = true;
            bttnBack.Enabled = true;
        }

        private void setData()
        {
            IdPelanggan.Enabled = true;
            Nama.Enabled = true;
            NoTelepon.Enabled = true;

            bttnAdd.Enabled = false;
            bttnUpdate.Enabled = false;
            bttnDelete.Enabled = false;
            bttnSearch.Enabled = false;
            bttnBack.Enabled = true;
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            HomePage HomePageForm = new HomePage();
            HomePageForm.Show();
            this.Hide();
        }

        private void Pelanggan_Load(object sender, EventArgs e)
        {
            // Load data dari tabel Pelanggan ke DataGridView saat form dimuat
            this.pelangganTableAdapter.Fill(this.barbershopDataSet.Pelanggan);
            setDefaultForm(); // Set form ke kondisi default
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            bttn = 1; // Aksi tambah
            setData(); // Mengaktifkan input data
            ClearInputFields(); // Mengosongkan field input
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            bttn = 2; // Aksi update
            setData(); // Mengaktifkan input data
            IdPelanggan.Enabled = false; // IdPelanggan tidak bisa diubah saat update

            if (dataGridViewPelanggan.CurrentRow != null)
            {
                bttn = 2; // Aksi update
                setData(); // Mengaktifkan input data
                IdPelanggan.Enabled = false; // IdPelanggan tidak bisa diubah saat update

                // Pastikan field input diisi dengan data yang dipilih
                DataGridViewRow row = dataGridViewPelanggan.CurrentRow;
                IdPelanggan.Text = row.Cells["id_pelanggan"].Value.ToString();
                Nama.Text = row.Cells["Nama_pelanggan"].Value.ToString();
                NoTelepon.Text = row.Cells["No_telp"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Pilih baris data yang ingin diupdate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            // Menampilkan dialog konfirmasi penghapusan
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                                                  "Konfirmasi Hapus Data",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Mendapatkan IdPelanggan dari baris terpilih dalam DataGridView
                string idPelanggan = dataGridViewPelanggan.CurrentRow.Cells["id_pelanggan"].Value.ToString();

                // Hapus data dari tabel dan dataset
                DeletePelanggan(idPelanggan);
            }
        }

        private void DeletePelanggan(string idPelanggan)
        {
            DataRow[] rows = barbershopDataSet.Pelanggan.Select($"id_pelanggan = '{idPelanggan}'");

            if (rows.Length > 0)
            {
                rows[0].Delete(); // Hapus baris dari dataset
                pelangganTableAdapter.Update(barbershopDataSet.Pelanggan); // Update perubahan ke database
                this.pelangganTableAdapter.Fill(this.barbershopDataSet.Pelanggan); // Refresh DataGridView
                setDefaultForm(); // Kembalikan form ke keadaan default
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                if (bttn == 1)
                {
                    // Aksi tambah data baru
                    AddNewPelanggan();
                }
                else if (bttn == 2)
                {
                    // Aksi update data
                    UpdatePelanggan();
                }

                // Kembalikan form ke keadaan default setelah penyimpanan
                setDefaultForm();
            }
        }

        private void AddNewPelanggan()
        {
            // Buat baris baru untuk dataset
            DataRow newRow = barbershopDataSet.Pelanggan.NewRow();
            newRow["id_pelanggan"] = IdPelanggan.Text;
            newRow["Nama_pelanggan"] = Nama.Text;
            newRow["No_telp"] = NoTelepon.Text;

            // Tambahkan baris baru ke dataset
            barbershopDataSet.Pelanggan.Rows.Add(newRow);

            // Update dataset ke database
            pelangganTableAdapter.Update(barbershopDataSet.Pelanggan);

            // Refresh DataGridView
            this.pelangganTableAdapter.Fill(this.barbershopDataSet.Pelanggan);
        }

        private void UpdatePelanggan()
        {
            // Cari baris yang sesuai dengan idPelanggan yang dipilih
            DataRow[] rows = barbershopDataSet.Pelanggan.Select($"idPelanggan = '{IdPelanggan.Text}'");

            if (rows.Length > 0)
            {
                // Update data di baris yang ditemukan
                rows[0]["Nama_pelanggan"] = Nama.Text;
                rows[0]["No_telp"] = NoTelepon.Text;

                // Update dataset ke database
                pelangganTableAdapter.Update(barbershopDataSet.Pelanggan);

                // Refresh DataGridView
                this.pelangganTableAdapter.Fill(this.barbershopDataSet.Pelanggan);
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidInput()
        {
            // Validasi input sebelum penyimpanan
            if (
                string.IsNullOrEmpty(Nama.Text) ||
                string.IsNullOrEmpty(NoTelepon.Text))
            {
                MessageBox.Show("Semua kolom harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validasi tambahan sesuai kebutuhan (misalnya panjang karakter, format, dll.)

            return true;
        }

        private void ClearInputFields()
        {
            // Mengosongkan semua field input
            IdPelanggan.Text = "";
            Nama.Text = "";
            NoTelepon.Text = "";
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            ClearInputFields(); // Mengosongkan semua field input
            setDefaultForm(); // Mengembalikan form ke keadaan default
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = SearchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dv = barbershopDataSet.Pelanggan.DefaultView;
                dv.RowFilter = $"Nama_pelanggan LIKE '%{searchValue}%' OR No_telp LIKE '%{searchValue}%'";
                dataGridViewPelanggan.DataSource = dv;
            }
            else
            {
                // Jika kotak pencarian kosong, tampilkan semua data
                dataGridViewPelanggan.DataSource = barbershopDataSet.Pelanggan;
            }
        }

        private void dataGridViewPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang dipilih valid
            {
                DataGridViewRow row = dataGridViewPelanggan.Rows[e.RowIndex];
                IdPelanggan.Text = row.Cells["id_pelanggan"].Value.ToString();
                Nama.Text = row.Cells["Nama_pelanggan"].Value.ToString();
                NoTelepon.Text = row.Cells["No_telp"].Value.ToString();
            }
        }
    }
}