using System;
using System.Data;
using System.Windows.Forms;

namespace Barber
{
    public partial class Pembookingan : Form
    {
        int bttn; // Variabel untuk menentukan aksi tambah (1), edit (2), dll.

        public Pembookingan()
        {
            InitializeComponent();
            dataGridViewBooking.CellClick += dataGridViewBooking_CellClick;
        }


        private void setDefaultForm()
        {
            IdBooking.Enabled = false;
            IdPelanggan.Enabled = false;
            IdTukangCukur.Enabled = false;
            Nama.Enabled = false;
            NoTelepon.Enabled = false;
            WaktuBooking.Enabled = false;
            NoAntrian.Enabled = false;

            bttnAdd.Enabled = true;
            bttnUpdate.Enabled = true;
            bttnDelete.Enabled = true;
            bttnSearch.Enabled = true;
            bttnBack.Enabled = true;
        }

        private void setData()
        {
            IdBooking.Enabled = true;
            IdPelanggan.Enabled = true;
            IdTukangCukur.Enabled = true;
            Nama.Enabled = true;
            NoTelepon.Enabled = true;
            WaktuBooking.Enabled = true;
            NoAntrian.Enabled = true;

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

        private void Pembookingan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barbershopDataSet.Pembookingan' table. You can move, or remove it, as needed.
            this.pembookinganTableAdapter.Fill(this.barbershopDataSet.Pembookingan);
            setDefaultForm(); // Set form ke kondisi default
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            bttn = 1; // Aksi tambah
            setData(); // Mengaktifkan input data
            ClearInputFields(); // Mengosongkan field input
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
                // Mendapatkan IdBooking dari baris terpilih dalam DataGridView
                string idBooking = dataGridViewBooking.CurrentRow.Cells["Id_booking"].Value.ToString();

                // Hapus data dari tabel dan dataset
                DeleteBooking(idBooking);
            }
        }

        private void DeleteBooking(string idBooking)
        {
            DataRow[] rows = barbershopDataSet.Pembookingan.Select($"Id_booking = '{idBooking}'");

            if (rows.Length > 0)
            {
                rows[0].Delete(); // Hapus baris dari dataset
                pembookinganTableAdapter.Update(barbershopDataSet.Pembookingan); // Update perubahan ke database
                this.pembookinganTableAdapter.Fill(this.barbershopDataSet.Pembookingan); // Refresh DataGridView
                setDefaultForm(); // Kembalikan form ke keadaan default
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooking.CurrentRow != null)
            {
                bttn = 2; // Aksi update
                setData(); // Mengaktifkan input data
                IdBooking.Enabled = false; // IdBooking tidak bisa diubah saat update

                // Pastikan field input diisi dengan data yang dipilih
                DataGridViewRow row = dataGridViewBooking.CurrentRow;
                IdBooking.Text = row.Cells["Id_booking"].Value.ToString();
                Nama.Text = row.Cells["Nama_pelanggan"].Value.ToString();
                NoTelepon.Text = row.Cells["No_telp"].Value.ToString();
                WaktuBooking.Text = row.Cells["Waktu_booking"].Value.ToString();
                NoAntrian.Text = row.Cells["No_antrian"].Value.ToString();
                IdPelanggan.Text = row.Cells["id_pelanggann"].Value.ToString();
                IdTukangCukur.Text = row.Cells["id_tkgcukurr"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Pilih baris data yang ingin diupdate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            ClearInputFields(); // Mengosongkan semua field input
            setDefaultForm(); // Mengembalikan form ke keadaan default
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            if(IsValidInput())
            {
                if (bttn == 1)
                {
                    // Aksi tambah data baru
                    AddNewBooking();
                }
                else if (bttn == 2)
                {
                    // Aksi update data
                    UpdateBooking();
                }

                // Kembalikan form ke keadaan default setelah penyimpanan
                setDefaultForm();
            }
        }

        private void AddNewBooking()
        {
            // Buat baris baru untuk dataset
            DataRow newRow = barbershopDataSet.Pembookingan.NewRow();
            newRow["Id_booking"] = IdBooking.Text;
            newRow["Nama_pelanggan"] = Nama.Text;
            newRow["No_telp"] = NoTelepon.Text;
            newRow["Waktu_booking"] = WaktuBooking.Text;
            newRow["No_antrian"] = NoAntrian.Text;
            newRow["idPelanggan"] = IdPelanggan.Text;
            newRow["Id_TkgCukur"] = IdTukangCukur.Text;

            // Tambahkan baris baru ke dataset
            barbershopDataSet.Pembookingan.Rows.Add(newRow);

            // Update dataset ke database
            pembookinganTableAdapter.Update(barbershopDataSet.Pembookingan);

            // Refresh DataGridView
            this.pembookinganTableAdapter.Fill(this.barbershopDataSet.Pembookingan);
        }

        private void UpdateBooking()
        {
            // Cari baris yang sesuai dengan Id_booking yang dipilih
            DataRow[] rows = barbershopDataSet.Pembookingan.Select($"Id_booking = '{IdBooking.Text}'");

            if (rows.Length > 0)
            {
                // Update data di baris yang ditemukan
                rows[0]["Nama_pelanggan"] = Nama.Text;
                rows[0]["No_telp"] = NoTelepon.Text;
                rows[0]["Waktu_booking"] = WaktuBooking.Text;
                rows[0]["No_antrian"] = NoAntrian.Text;
                rows[0]["idPelanggan"] = IdPelanggan.Text;
                rows[0]["Id_TkgCukur"] = IdTukangCukur.Text;

                // Update dataset ke database
                pembookinganTableAdapter.Update(barbershopDataSet.Pembookingan);

                // Refresh DataGridView
                this.pembookinganTableAdapter.Fill(this.barbershopDataSet.Pembookingan);
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
                string.IsNullOrEmpty(NoTelepon.Text) ||
                string.IsNullOrEmpty(WaktuBooking.Text) ||
                string.IsNullOrEmpty(NoAntrian.Text) ||
                string.IsNullOrEmpty(IdPelanggan.Text) ||
                string.IsNullOrEmpty(IdTukangCukur.Text))
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
            IdBooking.Text = "";
            Nama.Text = "";
            NoTelepon.Text = "";
            WaktuBooking.Text = "";
            NoAntrian.Text = "";
            IdPelanggan.Text = "";
            IdTukangCukur.Text = "";
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = SearchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dv = barbershopDataSet.Pembookingan.DefaultView;
                dv.RowFilter = $"Nama_pelanggan LIKE '%{searchValue}%' OR No_telp LIKE '%{searchValue}%' OR Waktu_booking LIKE '%{searchValue}%' OR No_antrian LIKE '%{searchValue}%'";
                dataGridViewBooking.DataSource = dv;
            }
            else
            {
                // Jika kotak pencarian kosong, tampilkan semua data
                dataGridViewBooking.DataSource = barbershopDataSet.Pembookingan;
            }
        }

        private void dataGridViewBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang dipilih valid
            {
                DataGridViewRow row = dataGridViewBooking.Rows[e.RowIndex];
                IdBooking.Text = row.Cells["Id_booking"].Value.ToString();
                Nama.Text = row.Cells["Nama_pelanggan"].Value.ToString();
                NoTelepon.Text = row.Cells["No_telp"].Value.ToString();
                WaktuBooking.Text = row.Cells["Waktu_booking"].Value.ToString();
                NoAntrian.Text = row.Cells["No_antrian"].Value.ToString();
                IdPelanggan.Text = row.Cells["id_pelanggann"].Value.ToString();
                IdTukangCukur.Text = row.Cells["id_tkgcukurr"].Value.ToString();
            }
        }
    }
}
