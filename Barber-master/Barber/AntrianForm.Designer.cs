namespace Barber
{
    partial class AntrianForm
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
            this.antrianBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barberShopDataSet = new Barber.BarberShopDataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.antrianBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.antrianBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.antrianDataGridView = new System.Windows.Forms.DataGridView();
            this.namapelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noantrianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktutungguDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idantrianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antrianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antrianTableAdapter = new Barber.BarberShopDataSetTableAdapters.AntrianTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrianDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.antrianBindingSource1, "Nama_pelanggan", true));
            this.textBox1.Location = new System.Drawing.Point(30, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 22);
            this.textBox1.TabIndex = 0;
            // 
            // antrianBindingSource1
            // 
            this.antrianBindingSource1.DataMember = "Antrian";
            this.antrianBindingSource1.DataSource = this.barberShopDataSet;
            // 
            // barberShopDataSet
            // 
            this.barberShopDataSet.DataSetName = "BarberShopDataSet";
            this.barberShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.antrianBindingSource2, "No_antrian", true));
            this.textBox2.Location = new System.Drawing.Point(30, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 22);
            this.textBox2.TabIndex = 1;
            // 
            // antrianBindingSource2
            // 
            this.antrianBindingSource2.DataMember = "Antrian";
            this.antrianBindingSource2.DataSource = this.barberShopDataSet;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.antrianBindingSource3, "Waktu_tunggu", true));
            this.textBox3.Location = new System.Drawing.Point(30, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 22);
            this.textBox3.TabIndex = 2;
            // 
            // antrianBindingSource3
            // 
            this.antrianBindingSource3.DataMember = "Antrian";
            this.antrianBindingSource3.DataSource = this.barberShopDataSet;
            // 
            // antrianDataGridView
            // 
            this.antrianDataGridView.AutoGenerateColumns = false;
            this.antrianDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.antrianDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namapelangganDataGridViewTextBoxColumn,
            this.noantrianDataGridViewTextBoxColumn,
            this.waktutungguDataGridViewTextBoxColumn,
            this.idantrianDataGridViewTextBoxColumn});
            this.antrianDataGridView.DataSource = this.antrianBindingSource;
            this.antrianDataGridView.Location = new System.Drawing.Point(446, 36);
            this.antrianDataGridView.Name = "antrianDataGridView";
            this.antrianDataGridView.RowHeadersWidth = 51;
            this.antrianDataGridView.RowTemplate.Height = 24;
            this.antrianDataGridView.Size = new System.Drawing.Size(552, 118);
            this.antrianDataGridView.TabIndex = 3;
            // 
            // namapelangganDataGridViewTextBoxColumn
            // 
            this.namapelangganDataGridViewTextBoxColumn.DataPropertyName = "Nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.HeaderText = "Nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namapelangganDataGridViewTextBoxColumn.Name = "namapelangganDataGridViewTextBoxColumn";
            this.namapelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // noantrianDataGridViewTextBoxColumn
            // 
            this.noantrianDataGridViewTextBoxColumn.DataPropertyName = "No_antrian";
            this.noantrianDataGridViewTextBoxColumn.HeaderText = "No_antrian";
            this.noantrianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noantrianDataGridViewTextBoxColumn.Name = "noantrianDataGridViewTextBoxColumn";
            this.noantrianDataGridViewTextBoxColumn.Width = 125;
            // 
            // waktutungguDataGridViewTextBoxColumn
            // 
            this.waktutungguDataGridViewTextBoxColumn.DataPropertyName = "Waktu_tunggu";
            this.waktutungguDataGridViewTextBoxColumn.HeaderText = "Waktu_tunggu";
            this.waktutungguDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.waktutungguDataGridViewTextBoxColumn.Name = "waktutungguDataGridViewTextBoxColumn";
            this.waktutungguDataGridViewTextBoxColumn.Width = 125;
            // 
            // idantrianDataGridViewTextBoxColumn
            // 
            this.idantrianDataGridViewTextBoxColumn.DataPropertyName = "Id_antrian";
            this.idantrianDataGridViewTextBoxColumn.HeaderText = "Id_antrian";
            this.idantrianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idantrianDataGridViewTextBoxColumn.Name = "idantrianDataGridViewTextBoxColumn";
            this.idantrianDataGridViewTextBoxColumn.Width = 125;
            // 
            // antrianBindingSource
            // 
            this.antrianBindingSource.DataMember = "Antrian";
            this.antrianBindingSource.DataSource = this.barberShopDataSet;
            // 
            // antrianTableAdapter
            // 
            this.antrianTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nomer Antrian";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Waktu Tunggu";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(299, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cari Data Antrian";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(28, 205);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(253, 22);
            this.textBoxSearch.TabIndex = 12;
            // 
            // AntrianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.antrianDataGridView);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AntrianForm";
            this.Text = "AntrianForm";
            this.Load += new System.EventHandler(this.AntrianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrianDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView antrianDataGridView;
        private BarberShopDataSet barberShopDataSet;
        private System.Windows.Forms.BindingSource antrianBindingSource;
        private BarberShopDataSetTableAdapters.AntrianTableAdapter antrianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noantrianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktutungguDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idantrianDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource antrianBindingSource1;
        private System.Windows.Forms.BindingSource antrianBindingSource2;
        private System.Windows.Forms.BindingSource antrianBindingSource3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}