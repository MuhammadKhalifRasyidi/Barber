using Barber.BarbershopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Barber
{
    public partial class Tukang_Cukur : Form
    {
        private Image curImage = null; // Deklarasi variabel curImage
        private string saveImageName = ""; // Deklarasi variabel saveImageName
        private string curFileName = "";
        int bttn; // Variabel untuk menentukan aksi tambah (1), edit (2), dll.

        public Tukang_Cukur()
        {
            InitializeComponent();
            dataGridViewTukangCukur.CellClick += dataGridViewTukangCukur_CellContentClick;
            this.tukangCukurTableAdapter.Fill(this.barbershopDataSet.TukangCukur);

        }

        private void setDefaultForm()
        {
            IdTukangCukur.Enabled = false;
            Nama.Enabled = false;
            JadwalKerja.Enabled = false;
            Pengalaman.Enabled = false;

            bttnAdd.Enabled = true;
            bttnUpdate.Enabled = true;
            bttnDelete.Enabled = true;
            bttnSearch.Enabled = true;
            bttnBack.Enabled = true;
        }

        private void setData()
        {
            IdTukangCukur.Enabled = true;
            Nama.Enabled = true;
            JadwalKerja.Enabled = true;
            Pengalaman.Enabled = true;

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

        private void Tukang_Cukur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barbershopDataSet.TukangCukur' table. You can move, or remove it, as needed.
            this.tukangCukurTableAdapter.Fill(this.barbershopDataSet.TukangCukur);
            // TODO: This line of code loads data into the 'barbershopDataSet.TukangCukur' table. You can move, or remove it, as needed.
            this.tukangCukurTableAdapter.Fill(this.barbershopDataSet.TukangCukur);
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
            IdTukangCukur.Enabled = false; // IdAntrian tidak bisa diubah saat update

            if (dataGridViewTukangCukur.CurrentRow != null)
            {
                bttn = 2; // Aksi update
                setData(); // Mengaktifkan input data
                IdTukangCukur.Enabled = false; // IdAntrian tidak bisa diubah saat update

                // Pastikan field input diisi dengan data yang dipilih
                DataGridViewRow row = dataGridViewTukangCukur.CurrentRow;
                IdTukangCukur.Text = row.Cells["Id_TukangCukur"].Value.ToString();
                Nama.Text = row.Cells["Nama_pelanggan"].Value.ToString();
                JadwalKerja.Text = row.Cells["Jadwal_kerja"].Value.ToString();
                Pengalaman.Text = row.Cells["pengalamann"].Value.ToString();
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
                string idTukangCukur = dataGridViewTukangCukur.CurrentRow.Cells["Id_TukangCukur"].Value.ToString();

                // Hapus data dari tabel dan dataset
                DeleteTukangCukur(idTukangCukur);
            }
        }

        private void DeleteTukangCukur(string idTukangCukur)
        {
            DataRow[] rows = barbershopDataSet.TukangCukur.Select($"Id_TkgCukur = '{idTukangCukur}'");

            if (rows.Length > 0)
            {
                rows[0].Delete(); // Hapus baris dari dataset
                tukangCukurTableAdapter.Update(barbershopDataSet.TukangCukur); // Update perubahan ke database
                this.tukangCukurTableAdapter.Fill(this.barbershopDataSet.TukangCukur); // Refresh DataGridView
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
                    AddNewTukangCukur();
                }
                else if (bttn == 2)
                {
                    // Aksi update data
                    UpdateTukangCukur();
                }

                // Kembalikan form ke keadaan default setelah penyimpanan
                setDefaultForm();
            }
        }

        private void AddNewTukangCukur()
        {
            // Buat baris baru untuk dataset
            DataRow newRow = barbershopDataSet.TukangCukur.NewRow();
            newRow["Id_TkgCukur"] = IdTukangCukur.Text;
            newRow["Nama"] = Nama.Text;
            newRow["Jadwal_kerja"] = JadwalKerja.Text;
            newRow["pengalaman"] = Pengalaman.Text;

            // Tambahkan baris baru ke dataset
            barbershopDataSet.TukangCukur.Rows.Add(newRow);

            // Update dataset ke database
            tukangCukurTableAdapter.Update(barbershopDataSet.TukangCukur);

            // Refresh DataGridView
            this.tukangCukurTableAdapter.Fill(this.barbershopDataSet.TukangCukur);
        }

        private void UpdateTukangCukur()
        {
            // Cari baris yang sesuai dengan Id_antrian yang dipilih
            DataRow[] rows = barbershopDataSet.TukangCukur.Select($"Id_TkgCukur = '{IdTukangCukur.Text}'");
            

            if (rows.Length > 0)
            {
                // Update data di baris yang ditemukan
                rows[0]["Nama"] = Nama.Text;
                rows[0]["Jadwal_kerja"] = JadwalKerja.Text;
                rows[0]["pengalaman"] = Pengalaman.Text;

                // Update dataset ke database
                tukangCukurTableAdapter.Update(barbershopDataSet.TukangCukur);

                // Refresh DataGridView
                this.tukangCukurTableAdapter.Fill(this.barbershopDataSet.TukangCukur);
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
                string.IsNullOrEmpty(JadwalKerja.Text) ||
                string.IsNullOrEmpty(Pengalaman.Text))

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
            IdTukangCukur.Text = "";
            Nama.Text = "";
            JadwalKerja.Text = "";
            Pengalaman.Text = "";
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
                DataView dv = barbershopDataSet.TukangCukur.DefaultView;
                dv.RowFilter = $"Nama LIKE '%{searchValue}%' OR Jadwal_kerja LIKE '%{searchValue}%' OR pengalaman LIKE '%{searchValue}%'";
                dataGridViewTukangCukur.DataSource = dv;
            }
            else
            {
                dataGridViewTukangCukur.DataSource = barbershopDataSet.TukangCukur;
            }
        }

        private void dataGridViewTukangCukur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang dipilih valid
            {
                DataGridViewRow row = dataGridViewTukangCukur.Rows[e.RowIndex];
                IdTukangCukur.Text = row.Cells["Id_TukangCukur"].Value.ToString();
                Nama.Text = row.Cells["Nama_pelanggan"].Value.ToString();
                JadwalKerja.Text = row.Cells["Jadwal_kerja"].Value.ToString();
                Pengalaman.Text = row.Cells["pengalamann"].Value.ToString();
            }
        }

        private void bttnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = openDlg.FileName;
                BrowseTextBox.Text = openDlg.FileName;

                // Display the selected image in pictureBox1
                curImage = Image.FromFile(curFileName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = curImage;
            }
        }

        private void bttnUpload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BrowseTextBox.Text))
            {
                FileStream file = new FileStream(curFileName, FileMode.OpenOrCreate, FileAccess.Read);
                byte[] rawdtata = new byte[file.Length];
                file.Read(rawdtata, 0, System.Convert.ToInt32(file.Length));
                file.Close();

                // Display the image immediately after upload 
                curImage = Image.FromStream(new MemoryStream(rawdtata));
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set the sizemode to zoom
                pictureBox.Image = curImage;
                pictureBox.Refresh(); // Make sure the pictureBox is updated immediately

                MessageBox.Show("Image Saved and Displayed");
            }
            else
                MessageBox.Show("Click the Browse button to select an image");

        }

        private void bttnClearfoto_Click(object sender, EventArgs e)
        {
            // Clear the TextBox
            BrowseTextBox.Text = "";

            // Reset the PictureBox
            pictureBox.Image = null;

            // Reset current filename and image variable
            curFileName = "";
            curImage = null;

            // Optionally, reset the savedImageName if needed
            saveImageName = "";

            // Display a confirmation message to the user
            MessageBox.Show("Data has been cleared");

        }
    }
}
