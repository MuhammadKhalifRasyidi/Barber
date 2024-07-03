namespace Barber
{
    partial class Pelanggan
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
            this.dataGridViewPelanggan = new System.Windows.Forms.DataGridView();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barbershopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barbershopDataSet = new Barber.BarbershopDataSet();
            this.NoTelepon = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.IdPelanggan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pelangganTableAdapter = new Barber.BarbershopDataSetTableAdapters.PelangganTableAdapter();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.Nama_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelanggan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPelanggan
            // 
            this.dataGridViewPelanggan.AutoGenerateColumns = false;
            this.dataGridViewPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPelanggan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama_pelanggan,
            this.No_telp,
            this.id_pelanggan});
            this.dataGridViewPelanggan.DataSource = this.pelangganBindingSource;
            this.dataGridViewPelanggan.Location = new System.Drawing.Point(387, 134);
            this.dataGridViewPelanggan.Name = "dataGridViewPelanggan";
            this.dataGridViewPelanggan.RowHeadersWidth = 62;
            this.dataGridViewPelanggan.RowTemplate.Height = 28;
            this.dataGridViewPelanggan.Size = new System.Drawing.Size(513, 189);
            this.dataGridViewPelanggan.TabIndex = 36;
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataMember = "Pelanggan";
            this.pelangganBindingSource.DataSource = this.barbershopDataSetBindingSource;
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
            // NoTelepon
            // 
            this.NoTelepon.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pelangganBindingSource, "No_telp", true));
            this.NoTelepon.Location = new System.Drawing.Point(21, 212);
            this.NoTelepon.Name = "NoTelepon";
            this.NoTelepon.Size = new System.Drawing.Size(346, 26);
            this.NoTelepon.TabIndex = 32;
            // 
            // Nama
            // 
            this.Nama.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pelangganBindingSource, "Nama_pelanggan", true));
            this.Nama.Location = new System.Drawing.Point(20, 134);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(346, 26);
            this.Nama.TabIndex = 31;
            // 
            // IdPelanggan
            // 
            this.IdPelanggan.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pelangganBindingSource, "idPelanggan", true));
            this.IdPelanggan.Location = new System.Drawing.Point(20, 292);
            this.IdPelanggan.Name = "IdPelanggan";
            this.IdPelanggan.Size = new System.Drawing.Size(346, 26);
            this.IdPelanggan.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Id Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "No Telepon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nama ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 48);
            this.label4.TabIndex = 26;
            this.label4.Text = "Data Pelanggan";
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(802, 31);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(57, 38);
            this.bttnBack.TabIndex = 37;
            this.bttnBack.Text = "<-";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(719, 338);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(116, 48);
            this.bttnUpdate.TabIndex = 43;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(597, 338);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(116, 48);
            this.bttnDelete.TabIndex = 42;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(476, 338);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(116, 48);
            this.bttnAdd.TabIndex = 41;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(737, 97);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(75, 31);
            this.bttnSearch.TabIndex = 46;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(386, 97);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(346, 26);
            this.SearchTextBox.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Cari Data Pelanggan";
            // 
            // pelangganTableAdapter
            // 
            this.pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(21, 338);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(116, 48);
            this.bttnSave.TabIndex = 47;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(251, 338);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(116, 48);
            this.bttnCancel.TabIndex = 48;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
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
            // id_pelanggan
            // 
            this.id_pelanggan.DataPropertyName = "idPelanggan";
            this.id_pelanggan.HeaderText = "idPelanggan";
            this.id_pelanggan.MinimumWidth = 8;
            this.id_pelanggan.Name = "id_pelanggan";
            this.id_pelanggan.Width = 150;
            // 
            // Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 430);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.dataGridViewPelanggan);
            this.Controls.Add(this.NoTelepon);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.IdPelanggan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Pelanggan";
            this.Text = "Pelanggan";
            this.Load += new System.EventHandler(this.Pelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelanggan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbershopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPelanggan;
        private System.Windows.Forms.TextBox NoTelepon;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox IdPelanggan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource barbershopDataSetBindingSource;
        private BarbershopDataSet barbershopDataSet;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private BarbershopDataSetTableAdapters.PelangganTableAdapter pelangganTableAdapter;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_telp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pelanggan;
    }
}