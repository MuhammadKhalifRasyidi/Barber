namespace Barber
{
    partial class Antrian
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WaktuTunggu = new System.Windows.Forms.TextBox();
            this.antrianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barbershopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barbershopDataSet = new Barber.BarbershopDataSet();
            this.Nama = new System.Windows.Forms.TextBox();
            this.NoAntrian = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewAntrian = new System.Windows.Forms.DataGridView();
            this.Nama_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_antrian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waktu_tunggu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Antrian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.IdAntrian = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.antrianTableAdapter = new Barber.BarbershopDataSetTableAdapters.AntrianTableAdapter();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntrian)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "No Antrian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Waktu Tunggu";
            // 
            // WaktuTunggu
            // 
            this.WaktuTunggu.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.antrianBindingSource, "Waktu_tunggu", true));
            this.WaktuTunggu.Location = new System.Drawing.Point(14, 315);
            this.WaktuTunggu.Name = "WaktuTunggu";
            this.WaktuTunggu.Size = new System.Drawing.Size(346, 26);
            this.WaktuTunggu.TabIndex = 3;
            // 
            // antrianBindingSource
            // 
            this.antrianBindingSource.DataMember = "Antrian";
            this.antrianBindingSource.DataSource = this.barbershopDataSetBindingSource;
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
            // Nama
            // 
            this.Nama.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.antrianBindingSource, "Nama_pelanggan", true));
            this.Nama.Location = new System.Drawing.Point(14, 163);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(346, 26);
            this.Nama.TabIndex = 4;
            // 
            // NoAntrian
            // 
            this.NoAntrian.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.antrianBindingSource, "No_antrian", true));
            this.NoAntrian.Location = new System.Drawing.Point(14, 240);
            this.NoAntrian.Name = "NoAntrian";
            this.NoAntrian.Size = new System.Drawing.Size(346, 26);
            this.NoAntrian.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Antrian";
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(544, 363);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(116, 48);
            this.bttnAdd.TabIndex = 7;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(666, 363);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(116, 48);
            this.bttnDelete.TabIndex = 8;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(788, 363);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(116, 48);
            this.bttnUpdate.TabIndex = 9;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // dataGridViewAntrian
            // 
            this.dataGridViewAntrian.AutoGenerateColumns = false;
            this.dataGridViewAntrian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAntrian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama_pelanggan,
            this.No_antrian,
            this.Waktu_tunggu,
            this.ID_Antrian});
            this.dataGridViewAntrian.DataSource = this.antrianBindingSource;
            this.dataGridViewAntrian.Location = new System.Drawing.Point(387, 105);
            this.dataGridViewAntrian.Name = "dataGridViewAntrian";
            this.dataGridViewAntrian.RowHeadersWidth = 62;
            this.dataGridViewAntrian.RowTemplate.Height = 28;
            this.dataGridViewAntrian.Size = new System.Drawing.Size(663, 236);
            this.dataGridViewAntrian.TabIndex = 10;
            this.dataGridViewAntrian.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAntrian_CellClick);
            // 
            // Nama_pelanggan
            // 
            this.Nama_pelanggan.DataPropertyName = "Nama_pelanggan";
            this.Nama_pelanggan.HeaderText = "Nama_pelanggan";
            this.Nama_pelanggan.MinimumWidth = 8;
            this.Nama_pelanggan.Name = "Nama_pelanggan";
            this.Nama_pelanggan.Width = 150;
            // 
            // No_antrian
            // 
            this.No_antrian.DataPropertyName = "No_antrian";
            this.No_antrian.HeaderText = "No_antrian";
            this.No_antrian.MinimumWidth = 8;
            this.No_antrian.Name = "No_antrian";
            this.No_antrian.Width = 150;
            // 
            // Waktu_tunggu
            // 
            this.Waktu_tunggu.DataPropertyName = "Waktu_tunggu";
            this.Waktu_tunggu.HeaderText = "Waktu_tunggu";
            this.Waktu_tunggu.MinimumWidth = 8;
            this.Waktu_tunggu.Name = "Waktu_tunggu";
            this.Waktu_tunggu.Width = 150;
            // 
            // ID_Antrian
            // 
            this.ID_Antrian.DataPropertyName = "Id_antrian";
            this.ID_Antrian.HeaderText = "Id_antrian";
            this.ID_Antrian.MinimumWidth = 8;
            this.ID_Antrian.Name = "ID_Antrian";
            this.ID_Antrian.Width = 150;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(387, 68);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(346, 26);
            this.SearchTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cari Data Antrian";
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(738, 68);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(75, 31);
            this.bttnSearch.TabIndex = 13;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(957, 14);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(57, 38);
            this.bttnBack.TabIndex = 14;
            this.bttnBack.Text = "<-";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // IdAntrian
            // 
            this.IdAntrian.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.antrianBindingSource, "Id_antrian", true));
            this.IdAntrian.Location = new System.Drawing.Point(13, 91);
            this.IdAntrian.Name = "IdAntrian";
            this.IdAntrian.Size = new System.Drawing.Size(346, 26);
            this.IdAntrian.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id Antrian";
            // 
            // antrianTableAdapter
            // 
            this.antrianTableAdapter.ClearBeforeFill = true;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(14, 363);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(116, 48);
            this.bttnSave.TabIndex = 17;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(245, 363);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(116, 48);
            this.bttnCancel.TabIndex = 18;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // Antrian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 465);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.IdAntrian);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewAntrian);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NoAntrian);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.WaktuTunggu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Antrian";
            this.Text = "Antrian";
            this.Load += new System.EventHandler(this.Antrian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntrian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WaktuTunggu;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox NoAntrian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewAntrian;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.TextBox IdAntrian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource barbershopDataSetBindingSource;
        private BarbershopDataSet barbershopDataSet;
        private System.Windows.Forms.BindingSource antrianBindingSource;
        private BarbershopDataSetTableAdapters.AntrianTableAdapter antrianTableAdapter;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_antrian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waktu_tunggu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Antrian;
    }
}