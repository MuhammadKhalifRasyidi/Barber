namespace Barber
{
    partial class Tukang_Cukur
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
            this.tukangCukurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barbershopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barbershopDataSet = new Barber.BarbershopDataSet();
            this.tukangCukurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTukangCukur = new System.Windows.Forms.DataGridView();
            this.Nama_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Jadwal_kerja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengalamann = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_TukangCukur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.TextBox();
            this.IdTukangCukur = new System.Windows.Forms.TextBox();
            this.JadwalKerja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.tukangCukurTableAdapter = new Barber.BarbershopDataSetTableAdapters.TukangCukurTableAdapter();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.BrowseTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bttnBrowse = new System.Windows.Forms.Button();
            this.bttnUpload = new System.Windows.Forms.Button();
            this.bttnClearfoto = new System.Windows.Forms.Button();
            this.Pengalaman = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTukangCukur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tukangCukurBindingSource1
            // 
            this.tukangCukurBindingSource1.DataMember = "TukangCukur";
            this.tukangCukurBindingSource1.DataSource = this.barbershopDataSetBindingSource;
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
            // tukangCukurBindingSource
            // 
            this.tukangCukurBindingSource.DataMember = "TukangCukur";
            this.tukangCukurBindingSource.DataSource = this.barbershopDataSetBindingSource;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Pengalaman";
            // 
            // dataGridViewTukangCukur
            // 
            this.dataGridViewTukangCukur.AutoGenerateColumns = false;
            this.dataGridViewTukangCukur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTukangCukur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama_pelanggan,
            this.Foto,
            this.Jadwal_kerja,
            this.pengalamann,
            this.Id_TukangCukur,
            this.Id_pelanggan});
            this.dataGridViewTukangCukur.DataSource = this.tukangCukurBindingSource1;
            this.dataGridViewTukangCukur.Location = new System.Drawing.Point(387, 134);
            this.dataGridViewTukangCukur.Name = "dataGridViewTukangCukur";
            this.dataGridViewTukangCukur.RowHeadersWidth = 62;
            this.dataGridViewTukangCukur.RowTemplate.Height = 28;
            this.dataGridViewTukangCukur.Size = new System.Drawing.Size(805, 253);
            this.dataGridViewTukangCukur.TabIndex = 36;
            this.dataGridViewTukangCukur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTukangCukur_CellContentClick);
            // 
            // Nama_pelanggan
            // 
            this.Nama_pelanggan.DataPropertyName = "Nama";
            this.Nama_pelanggan.HeaderText = "Nama";
            this.Nama_pelanggan.MinimumWidth = 8;
            this.Nama_pelanggan.Name = "Nama_pelanggan";
            this.Nama_pelanggan.Width = 150;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.MinimumWidth = 8;
            this.Foto.Name = "Foto";
            this.Foto.Width = 150;
            // 
            // Jadwal_kerja
            // 
            this.Jadwal_kerja.DataPropertyName = "Jadwal_kerja";
            this.Jadwal_kerja.HeaderText = "Jadwal_kerja";
            this.Jadwal_kerja.MinimumWidth = 8;
            this.Jadwal_kerja.Name = "Jadwal_kerja";
            this.Jadwal_kerja.Width = 150;
            // 
            // pengalamann
            // 
            this.pengalamann.DataPropertyName = "pengalaman";
            this.pengalamann.HeaderText = "pengalaman";
            this.pengalamann.MinimumWidth = 8;
            this.pengalamann.Name = "pengalamann";
            this.pengalamann.Width = 150;
            // 
            // Id_TukangCukur
            // 
            this.Id_TukangCukur.DataPropertyName = "Id_TkgCukur";
            this.Id_TukangCukur.HeaderText = "Id_TkgCukur";
            this.Id_TukangCukur.MinimumWidth = 8;
            this.Id_TukangCukur.Name = "Id_TukangCukur";
            this.Id_TukangCukur.Width = 150;
            // 
            // Id_pelanggan
            // 
            this.Id_pelanggan.DataPropertyName = "idPelanggan";
            this.Id_pelanggan.HeaderText = "idPelanggan";
            this.Id_pelanggan.MinimumWidth = 8;
            this.Id_pelanggan.Name = "Id_pelanggan";
            this.Id_pelanggan.Width = 150;
            // 
            // Nama
            // 
            this.Nama.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tukangCukurBindingSource1, "Nama", true));
            this.Nama.Location = new System.Drawing.Point(22, 159);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(346, 26);
            this.Nama.TabIndex = 32;
            // 
            // IdTukangCukur
            // 
            this.IdTukangCukur.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tukangCukurBindingSource1, "Id_TkgCukur", true));
            this.IdTukangCukur.Location = new System.Drawing.Point(20, 95);
            this.IdTukangCukur.Name = "IdTukangCukur";
            this.IdTukangCukur.Size = new System.Drawing.Size(346, 26);
            this.IdTukangCukur.TabIndex = 31;
            // 
            // JadwalKerja
            // 
            this.JadwalKerja.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tukangCukurBindingSource1, "Jadwal_kerja", true));
            this.JadwalKerja.Location = new System.Drawing.Point(22, 227);
            this.JadwalKerja.Name = "JadwalKerja";
            this.JadwalKerja.Size = new System.Drawing.Size(346, 26);
            this.JadwalKerja.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Jadwal Kerja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id Tukang Cukur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 48);
            this.label4.TabIndex = 26;
            this.label4.Text = "Data Tukang Cukur";
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(1295, 29);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(57, 38);
            this.bttnBack.TabIndex = 39;
            this.bttnBack.Text = "<-";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(737, 95);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(75, 31);
            this.bttnSearch.TabIndex = 49;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(386, 95);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(346, 26);
            this.SearchTextBox.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Cari Data Tukang Cukur";
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(848, 417);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(116, 48);
            this.bttnUpdate.TabIndex = 52;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(726, 417);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(116, 48);
            this.bttnDelete.TabIndex = 51;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(604, 417);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(116, 48);
            this.bttnAdd.TabIndex = 50;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // tukangCukurTableAdapter
            // 
            this.tukangCukurTableAdapter.ClearBeforeFill = true;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(23, 345);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(116, 48);
            this.bttnSave.TabIndex = 55;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(250, 345);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(116, 48);
            this.bttnCancel.TabIndex = 56;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // BrowseTextBox
            // 
            this.BrowseTextBox.Location = new System.Drawing.Point(1198, 95);
            this.BrowseTextBox.Name = "BrowseTextBox";
            this.BrowseTextBox.Size = new System.Drawing.Size(117, 26);
            this.BrowseTextBox.TabIndex = 61;
            // 
            // pictureBox
            // 
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tukangCukurBindingSource, "Foto", true));
            this.pictureBox.Location = new System.Drawing.Point(1198, 134);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(198, 224);
            this.pictureBox.TabIndex = 60;
            this.pictureBox.TabStop = false;
            // 
            // bttnBrowse
            // 
            this.bttnBrowse.Location = new System.Drawing.Point(1321, 93);
            this.bttnBrowse.Name = "bttnBrowse";
            this.bttnBrowse.Size = new System.Drawing.Size(75, 33);
            this.bttnBrowse.TabIndex = 62;
            this.bttnBrowse.Text = "browse";
            this.bttnBrowse.UseVisualStyleBackColor = true;
            this.bttnBrowse.Click += new System.EventHandler(this.bttnBrowse_Click);
            // 
            // bttnUpload
            // 
            this.bttnUpload.Location = new System.Drawing.Point(1198, 361);
            this.bttnUpload.Name = "bttnUpload";
            this.bttnUpload.Size = new System.Drawing.Size(75, 32);
            this.bttnUpload.TabIndex = 63;
            this.bttnUpload.Text = "upload";
            this.bttnUpload.UseVisualStyleBackColor = true;
            this.bttnUpload.Click += new System.EventHandler(this.bttnUpload_Click);
            // 
            // bttnClearfoto
            // 
            this.bttnClearfoto.Location = new System.Drawing.Point(1321, 361);
            this.bttnClearfoto.Name = "bttnClearfoto";
            this.bttnClearfoto.Size = new System.Drawing.Size(75, 32);
            this.bttnClearfoto.TabIndex = 64;
            this.bttnClearfoto.Text = "clear";
            this.bttnClearfoto.UseVisualStyleBackColor = true;
            this.bttnClearfoto.Click += new System.EventHandler(this.bttnClearfoto_Click);
            // 
            // Pengalaman
            // 
            this.Pengalaman.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tukangCukurBindingSource1, "pengalaman", true));
            this.Pengalaman.Location = new System.Drawing.Point(22, 296);
            this.Pengalaman.Name = "Pengalaman";
            this.Pengalaman.Size = new System.Drawing.Size(346, 26);
            this.Pengalaman.TabIndex = 38;
            // 
            // Tukang_Cukur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 542);
            this.Controls.Add(this.bttnClearfoto);
            this.Controls.Add(this.bttnUpload);
            this.Controls.Add(this.bttnBrowse);
            this.Controls.Add(this.BrowseTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.Pengalaman);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewTukangCukur);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.IdTukangCukur);
            this.Controls.Add(this.JadwalKerja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Tukang_Cukur";
            this.Text = "Tukang_Cukur";
            this.Load += new System.EventHandler(this.Tukang_Cukur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTukangCukur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewTukangCukur;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox IdTukangCukur;
        private System.Windows.Forms.TextBox JadwalKerja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.BindingSource barbershopDataSetBindingSource;
        private BarbershopDataSet barbershopDataSet;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource;
        private BarbershopDataSetTableAdapters.TukangCukurTableAdapter tukangCukurTableAdapter;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.TextBox BrowseTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button bttnBrowse;
        private System.Windows.Forms.Button bttnUpload;
        private System.Windows.Forms.Button bttnClearfoto;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_pelanggan;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jadwal_kerja;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengalamann;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_TukangCukur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_pelanggan;
        private System.Windows.Forms.TextBox Pengalaman;
    }
}