using System;
using System.Data;
using System.Windows.Forms;

namespace Barber
{
    public partial class Antrian : Form
    {
        int bttn; // Variabel untuk menentukan aksi tambah (1), edit (2), dll.

        public Antrian()
        {
            InitializeComponent();
            dataGridViewAntrian.CellClick += dataGridViewAntrian_CellClick;
        }

        private void setDefaultForm()
        {
            IdAntrian.Enabled = false;
            Nama.Enabled = false;
            NoAntrian.Enabled = false;
            WaktuTunggu.Enabled = false;

            bttnAdd.Enabled = true;
            bttnUpdate.Enabled = true;
            bttnDelete.Enabled = true;
            bttnSearch.Enabled = true;
            bttnBack.Enabled = true;
        }

        private void setData()
        {
            IdAntrian.Enabled = true;
            Nama.Enabled = true;
            NoAntrian.Enabled = true;
            WaktuTunggu.Enabled = true;

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

        private void Antrian_Load(object sender, EventArgs e)
        {
            // Load data dari tabel Antrian ke DataGridView saat form dimuat
            this.antrianTableAdapter.Fill(this.barbershopDataSet.Antrian);
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
            IdAntrian.Enabled = false; // IdAntrian tidak bisa diubah saat update

            if (dataGridViewAntrian.CurrentRow != null)
            {
                bttn = 2; // Aksi update
                setData(); // Mengaktifkan input data
                IdAntrian.Enabled = false; // IdAntrian tidak bisa diubah saat update

                // Pastikan field input diisi dengan data yang dipilih
                DataGridViewRow row = dataGridViewAntrian.CurrentRow;
                IdAntrian.Text = row.Cells["ID_Antrian"].Value.ToString();
                Nama.Text = row.Cells["Nama_pelanggan"].Value.ToString();
                NoAntrian.Text = row.Cells["No_antrian"].Value.ToString();
                WaktuTunggu.Text = row.Cells["Waktu_tunggu"].Value.ToString();
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
                // Mendapatkan IdAntrian dari baris terpilih dalam DataGridView
                string idAntrian = dataGridViewAntrian.CurrentRow.Cells["ID_Antrian"].Value.ToString();

                // Hapus data dari tabel dan dataset
                DeleteAntrian(idAntrian);
            }
        }

        private void DeleteAntrian(string idAntrian)
        {
            DataRow[] rows = barbershopDataSet.Antrian.Select($"Id_antrian = '{idAntrian}'");

            if (rows.Length > 0)
            {
                rows[0].Delete(); // Hapus baris dari dataset
                antrianTableAdapter.Update(barbershopDataSet.Antrian); // Update perubahan ke database
                this.antrianTableAdapter.Fill(this.barbershopDataSet.Antrian); // Refresh DataGridView
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
                    AddNewAntrian();
                }
                else if (bttn == 2)
                {
                    // Aksi update data
                    UpdateAntrian();
                }

                // Kembalikan form ke keadaan default setelah penyimpanan
                setDefaultForm();
            }
        }

        private void AddNewAntrian()
        {
            // Buat baris baru untuk dataset
            DataRow newRow = barbershopDataSet.Antrian.NewRow();
            newRow["Id_antrian"] = IdAntrian.Text;
            newRow["Nama_pelanggan"] = Nama.Text;
            newRow["No_antrian"] = NoAntrian.Text;
            newRow["Waktu_tunggu"] = WaktuTunggu.Text;

            // Tambahkan baris baru ke dataset
            barbershopDataSet.Antrian.Rows.Add(newRow);

            // Update dataset ke database
            antrianTableAdapter.Update(barbershopDataSet.Antrian);

            // Refresh DataGridView
            this.antrianTableAdapter.Fill(this.barbershopDataSet.Antrian);
        }

        private void UpdateAntrian()
        {
            // Cari baris yang sesuai dengan Id_antrian yang dipilih
            DataRow[] rows = barbershopDataSet.Antrian.Select($"Id_antrian = '{IdAntrian.Text}'");

            if (rows.Length > 0)
            {
                // Update data di baris yang ditemukan
                rows[0]["Nama_pelanggan"] = Nama.Text;
                rows[0]["No_antrian"] = NoAntrian.Text;
                rows[0]["Waktu_tunggu"] = WaktuTunggu.Text;

                // Update dataset ke database
                antrianTableAdapter.Update(barbershopDataSet.Antrian);

                // Refresh DataGridView
                this.antrianTableAdapter.Fill(this.barbershopDataSet.Antrian);
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
                string.IsNullOrEmpty(NoAntrian.Text) ||
                string.IsNullOrEmpty(WaktuTunggu.Text))
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
            IdAntrian.Text = "";
            Nama.Text = "";
            NoAntrian.Text = "";
            WaktuTunggu.Text = "";
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            ClearInputFields(); // Mengosongkan semua field input
            setDefaultForm(); // Mengembalikan form ke keadaan default
        }

        private void dataGridViewAntrian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang dipilih valid
            {
                DataGridViewRow row = dataGridViewAntrian.Rows[e.RowIndex];
                IdAntrian.Text = row.Cells["ID_Antrian"].Value.ToString();
                Nama.Text = row.Cells["Nama_pelanggan"].Value.ToString();
                NoAntrian.Text = row.Cells["No_antrian"].Value.ToString();
                WaktuTunggu.Text = row.Cells["Waktu_tunggu"].Value.ToString();
            }
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = SearchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dv = barbershopDataSet.Antrian.DefaultView;
                dv.RowFilter = $"Nama_pelanggan LIKE '%{searchValue}%' OR No_antrian LIKE '%{searchValue}%' OR Waktu_tunggu LIKE '%{searchValue}%'";
                dataGridViewAntrian.DataSource = dv;
            }
            else
            {
                // Jika kotak pencarian kosong, tampilkan semua data
                dataGridViewAntrian.DataSource = barbershopDataSet.Antrian;
            }
        }
    }
}
