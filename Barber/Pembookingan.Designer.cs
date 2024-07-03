namespace Barber
{
    partial class Pembookingan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.NoAntrian = new System.Windows.Forms.TextBox();
            this.pembookinganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barbershopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barbershopDataSet = new Barber.BarbershopDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            this.Id_booking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waktu_booking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_antrian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pelanggann = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tkgcukurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoTelepon = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.WaktuBooking = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IdBooking = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IdPelanggan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IdTukangCukur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pembookinganTableAdapter = new Barber.BarbershopDataSetTableAdapters.PembookinganTableAdapter();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Pembookingan";
            // 
            // NoAntrian
            // 
            this.NoAntrian.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pembookinganBindingSource, "No_antrian", true));
            this.NoAntrian.Location = new System.Drawing.Point(25, 447);
            this.NoAntrian.Name = "NoAntrian";
            this.NoAntrian.Size = new System.Drawing.Size(343, 26);
            this.NoAntrian.TabIndex = 25;
            // 
            // pembookinganBindingSource
            // 
            this.pembookinganBindingSource.DataMember = "Pembookingan";
            this.pembookinganBindingSource.DataSource = this.barbershopDataSetBindingSource;
            // 
            // barbershopDataSetBindingSource
            // 
            this.barbershopDataSetBindingSource.DataSource = this.barbershopDataSet;
            this.barbershopDataSetBindingSource.Position = 0;
            // 
            // barbershopDataSet
            // 
            this.barbershopDataSet.DataSetName = "BarbershopDataSet";
            this.barbershopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nomor Antrian";
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.AutoGenerateColumns = false;
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_booking,
            this.Nama_pelanggan,
            this.No_telp,
            this.Waktu_booking,
            this.No_antrian,
            this.id_pelanggann,
            this.id_tkgcukurr});
            this.dataGridViewBooking.DataSource = this.pembookinganBindingSource;
            this.dataGridViewBooking.Location = new System.Drawing.Point(387, 134);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.RowHeadersWidth = 62;
            this.dataGridViewBooking.RowTemplate.Height = 28;
            this.dataGridViewBooking.Size = new System.Drawing.Size(1111, 339);
            this.dataGridViewBooking.TabIndex = 23;
            this.dataGridViewBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooking_CellClick);
            // 
            // Id_booking
            // 
            this.Id_booking.DataPropertyName = "Id_booking";
            this.Id_booking.HeaderText = "Id_booking";
            this.Id_booking.MinimumWidth = 8;
            this.Id_booking.Name = "Id_booking";
            this.Id_booking.Width = 150;
            // 
            // Nama_pelanggan
            // 
            this.Nama_pelanggan.DataPropertyName = "Nama_pelanggan";
            this.Nama_pelanggan.HeaderText = "Nama_pelanggan";
            this.Nama_pelanggan.MinimumWidth = 8;
            this.Nama_pelanggan.Name = "Nama_pelanggan";
            this.Nama_pelanggan.Width = 150;
            // 
            // No_telp
            // 
            this.No_telp.DataPropertyName = "No_telp";
            this.No_telp.HeaderText = "No_telp";
            this.No_telp.MinimumWidth = 8;
            this.No_telp.Name = "No_telp";
            this.No_telp.Width = 150;
            // 
            // Waktu_booking
            // 
            this.Waktu_booking.DataPropertyName = "Waktu_booking";
            this.Waktu_booking.HeaderText = "Waktu_booking";
            this.Waktu_booking.MinimumWidth = 8;
            this.Waktu_booking.Name = "Waktu_booking";
            this.Waktu_booking.Width = 150;
            // 
            // No_antrian
            // 
            this.No_antrian.DataPropertyName = "No_antrian";
            this.No_antrian.HeaderText = "No_antrian";
            this.No_antrian.MinimumWidth = 8;
            this.No_antrian.Name = "No_antrian";
            this.No_antrian.Width = 150;
            // 
            // id_pelanggann
            // 
            this.id_pelanggann.DataPropertyName = "idPelanggan";
            this.id_pelanggann.HeaderText = "idPelanggan";
            this.id_pelanggann.MinimumWidth = 8;
            this.id_pelanggann.Name = "id_pelanggann";
            this.id_pelanggann.Width = 150;
            // 
            // id_tkgcukurr
            // 
            this.id_tkgcukurr.DataPropertyName = "Id_TkgCukur";
            this.id_tkgcukurr.HeaderText = "Id_TkgCukur";
            this.id_tkgcukurr.MinimumWidth = 8;
            this.id_tkgcukurr.Name = "id_tkgcukurr";
            this.id_tkgcukurr.Width = 150;
            // 
            // NoTelepon
            // 
            this.NoTelepon.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pembookinganBindingSource, "No_telp", true));
            this.NoTelepon.Location = new System.Drawing.Point(24, 331);
            this.NoTelepon.Name = "NoTelepon";
            this.NoTelepon.Size = new System.Drawing.Size(344, 26);
            this.NoTelepon.TabIndex = 19;
            // 
            // Nama
            // 
            this.Nama.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pembookinganBindingSource, "Nama_pelanggan", true));
            this.Nama.Location = new System.Drawing.Point(22, 270);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(346, 26);
            this.Nama.TabIndex = 18;
            // 
            // WaktuBooking
            // 
            this.WaktuBooking.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pembookinganBindingSource, "Waktu_booking", true));
            this.WaktuBooking.Location = new System.Drawing.Point(25, 391);
            this.WaktuBooking.Name = "WaktuBooking";
            this.WaktuBooking.Size = new System.Drawing.Size(343, 26);
            this.WaktuBooking.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Waktu Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "No Telepon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nama ";
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(1378, 30);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(57, 38);
            this.bttnBack.TabIndex = 26;
            this.bttnBack.Text = "<-";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(1010, 504);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(116, 48);
            this.bttnUpdate.TabIndex = 29;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(889, 504);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(116, 48);
            this.bttnDelete.TabIndex = 28;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(768, 504);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(116, 48);
            this.bttnAdd.TabIndex = 27;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(737, 96);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(75, 31);
            this.bttnSearch.TabIndex = 32;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(386, 96);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(346, 26);
            this.SearchTextBox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cari Data Pembookingan";
            // 
            // IdBooking
            // 
            this.IdBooking.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pembookinganBindingSource, "Id_booking", true));
            this.IdBooking.Location = new System.Drawing.Point(20, 96);
            this.IdBooking.Name = "IdBooking";
            this.IdBooking.Size = new System.Drawing.Size(346, 26);
            this.IdBooking.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Id Booking";
            // 
            // IdPelanggan
            // 
            this.IdPelanggan.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pembookinganBindingSource, "idPelanggan", true));
            this.IdPelanggan.Location = new System.Drawing.Point(20, 156);
            this.IdPelanggan.Name = "IdPelanggan";
            this.IdPelanggan.Size = new System.Drawing.Size(346, 26);
            this.IdPelanggan.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Id Pelanggan";
            // 
            // IdTukangCukur
            // 
            this.IdTukangCukur.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pembookinganBindingSource, "Id_TkgCukur", true));
            this.IdTukangCukur.Location = new System.Drawing.Point(19, 213);
            this.IdTukangCukur.Name = "IdTukangCukur";
            this.IdTukangCukur.Size = new System.Drawing.Size(346, 26);
            this.IdTukangCukur.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Id Tukang Cukur";
            // 
            // pembookinganTableAdapter
            // 
            this.pembookinganTableAdapter.ClearBeforeFill = true;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(22, 504);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(116, 48);
            this.bttnSave.TabIndex = 39;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(249, 504);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(116, 48);
            this.bttnCancel.TabIndex = 40;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // Pembookingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 622);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.IdTukangCukur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IdPelanggan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IdBooking);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.NoAntrian);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewBooking);
            this.Controls.Add(this.NoTelepon);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.WaktuBooking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Pembookingan";
            this.Text = "Pembookingan";
            this.Load += new System.EventHandler(this.Pembookingan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoAntrian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.TextBox NoTelepon;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox WaktuBooking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdBooking;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IdPelanggan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource barbershopDataSetBindingSource;
        private BarbershopDataSet barbershopDataSet;
        private System.Windows.Forms.TextBox IdTukangCukur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource pembookinganBindingSource;
        private BarbershopDataSetTableAdapters.PembookinganTableAdapter pembookinganTableAdapter;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_booking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_telp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waktu_booking;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_antrian;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_tkgcukur;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pelanggann;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tkgcukurr;
    }
}