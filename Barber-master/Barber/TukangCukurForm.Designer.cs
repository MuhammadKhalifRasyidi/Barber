namespace Barber
{
    partial class TukangCukurForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barberShopDataSet = new Barber.BarberShopDataSet();
            this.tukangCukurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tukangCukurTableAdapter = new Barber.BarberShopDataSetTableAdapters.TukangCukurTableAdapter();
            this.tukangCukurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tukangCukurBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tukangCukurBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tukangCukurDataGridView = new System.Windows.Forms.DataGridView();
            this.tukangCukurBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalkerjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengalamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTkgCukurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tukangCukurBindingSource, "Id_TkgCukur", true));
            this.textBox1.Location = new System.Drawing.Point(54, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tukangCukurBindingSource1, "Nama", true));
            this.textBox2.Location = new System.Drawing.Point(53, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tukangCukurBindingSource2, "Jadwal_kerja", true));
            this.textBox3.Location = new System.Drawing.Point(50, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tukangCukurBindingSource3, "pengalaman", true));
            this.textBox4.Location = new System.Drawing.Point(47, 311);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 22);
            this.textBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Tukang Cukur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jadwal Kerja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pengalaman";
            // 
            // barberShopDataSet
            // 
            this.barberShopDataSet.DataSetName = "BarberShopDataSet";
            this.barberShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tukangCukurBindingSource
            // 
            this.tukangCukurBindingSource.DataMember = "TukangCukur";
            this.tukangCukurBindingSource.DataSource = this.barberShopDataSet;
            // 
            // tukangCukurTableAdapter
            // 
            this.tukangCukurTableAdapter.ClearBeforeFill = true;
            // 
            // tukangCukurBindingSource1
            // 
            this.tukangCukurBindingSource1.DataMember = "TukangCukur";
            this.tukangCukurBindingSource1.DataSource = this.barberShopDataSet;
            // 
            // tukangCukurBindingSource2
            // 
            this.tukangCukurBindingSource2.DataMember = "TukangCukur";
            this.tukangCukurBindingSource2.DataSource = this.barberShopDataSet;
            // 
            // tukangCukurBindingSource3
            // 
            this.tukangCukurBindingSource3.DataMember = "TukangCukur";
            this.tukangCukurBindingSource3.DataSource = this.barberShopDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Update_Click);
            // 
            // tukangCukurDataGridView
            // 
            this.tukangCukurDataGridView.AutoGenerateColumns = false;
            this.tukangCukurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tukangCukurDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaDataGridViewTextBoxColumn,
            this.jadwalkerjaDataGridViewTextBoxColumn,
            this.pengalamanDataGridViewTextBoxColumn,
            this.idTkgCukurDataGridViewTextBoxColumn,
            this.idPelangganDataGridViewTextBoxColumn});
            this.tukangCukurDataGridView.DataSource = this.tukangCukurBindingSource4;
            this.tukangCukurDataGridView.Location = new System.Drawing.Point(357, 76);
            this.tukangCukurDataGridView.Name = "tukangCukurDataGridView";
            this.tukangCukurDataGridView.RowHeadersWidth = 51;
            this.tukangCukurDataGridView.RowTemplate.Height = 24;
            this.tukangCukurDataGridView.Size = new System.Drawing.Size(431, 150);
            this.tukangCukurDataGridView.TabIndex = 11;
            // 
            // tukangCukurBindingSource4
            // 
            this.tukangCukurBindingSource4.DataMember = "TukangCukur";
            this.tukangCukurBindingSource4.DataSource = this.barberShopDataSet;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jadwalkerjaDataGridViewTextBoxColumn
            // 
            this.jadwalkerjaDataGridViewTextBoxColumn.DataPropertyName = "Jadwal_kerja";
            this.jadwalkerjaDataGridViewTextBoxColumn.HeaderText = "Jadwal_kerja";
            this.jadwalkerjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jadwalkerjaDataGridViewTextBoxColumn.Name = "jadwalkerjaDataGridViewTextBoxColumn";
            this.jadwalkerjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pengalamanDataGridViewTextBoxColumn
            // 
            this.pengalamanDataGridViewTextBoxColumn.DataPropertyName = "pengalaman";
            this.pengalamanDataGridViewTextBoxColumn.HeaderText = "pengalaman";
            this.pengalamanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pengalamanDataGridViewTextBoxColumn.Name = "pengalamanDataGridViewTextBoxColumn";
            this.pengalamanDataGridViewTextBoxColumn.Width = 125;
            // 
            // idTkgCukurDataGridViewTextBoxColumn
            // 
            this.idTkgCukurDataGridViewTextBoxColumn.DataPropertyName = "Id_TkgCukur";
            this.idTkgCukurDataGridViewTextBoxColumn.HeaderText = "Id_TkgCukur";
            this.idTkgCukurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTkgCukurDataGridViewTextBoxColumn.Name = "idTkgCukurDataGridViewTextBoxColumn";
            this.idTkgCukurDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPelangganDataGridViewTextBoxColumn
            // 
            this.idPelangganDataGridViewTextBoxColumn.DataPropertyName = "idPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.HeaderText = "idPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPelangganDataGridViewTextBoxColumn.Name = "idPelangganDataGridViewTextBoxColumn";
            this.idPelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // TukangCukurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tukangCukurDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "TukangCukurForm";
            this.Text = "TukangCukur";
            this.Load += new System.EventHandler(this.TukangCukurForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private BarberShopDataSet barberShopDataSet;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource;
        private BarberShopDataSetTableAdapters.TukangCukurTableAdapter tukangCukurTableAdapter;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource1;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource2;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView tukangCukurDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jadwalkerjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengalamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTkgCukurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource4;
    }
}