namespace Barber
{
    partial class BookingForm
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
            this.pembookinganBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barberShopDataSet = new Barber.BarberShopDataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pembookinganBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pembookinganBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pembookinganBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pembookinganDataGridView = new System.Windows.Forms.DataGridView();
            this.idbookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktubookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noantrianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTkgCukurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pembookinganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pembookinganTableAdapter = new Barber.BarberShopDataSetTableAdapters.PembookinganTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pembookinganBindingSource1, "Nama_pelanggan", true));
            this.textBox1.Location = new System.Drawing.Point(38, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 22);
            this.textBox1.TabIndex = 0;
            // 
            // pembookinganBindingSource1
            // 
            this.pembookinganBindingSource1.DataMember = "Pembookingan";
            this.pembookinganBindingSource1.DataSource = this.barberShopDataSet;
            // 
            // barberShopDataSet
            // 
            this.barberShopDataSet.DataSetName = "BarberShopDataSet";
            this.barberShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pembookinganBindingSource2, "No_telp", true));
            this.textBox2.Location = new System.Drawing.Point(38, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 22);
            this.textBox2.TabIndex = 1;
            // 
            // pembookinganBindingSource2
            // 
            this.pembookinganBindingSource2.DataMember = "Pembookingan";
            this.pembookinganBindingSource2.DataSource = this.barberShopDataSet;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pembookinganBindingSource3, "Waktu_booking", true));
            this.textBox3.Location = new System.Drawing.Point(38, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 22);
            this.textBox3.TabIndex = 2;
            // 
            // pembookinganBindingSource3
            // 
            this.pembookinganBindingSource3.DataMember = "Pembookingan";
            this.pembookinganBindingSource3.DataSource = this.barberShopDataSet;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pembookinganBindingSource4, "No_antrian", true));
            this.textBox4.Location = new System.Drawing.Point(38, 211);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 22);
            this.textBox4.TabIndex = 3;
            // 
            // pembookinganBindingSource4
            // 
            this.pembookinganBindingSource4.DataMember = "Pembookingan";
            this.pembookinganBindingSource4.DataSource = this.barberShopDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nomor Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Waktu Booking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nomor Antrian";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Update_Click);
            // 
            // pembookinganDataGridView
            // 
            this.pembookinganDataGridView.AutoGenerateColumns = false;
            this.pembookinganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pembookinganDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbookingDataGridViewTextBoxColumn,
            this.namapelangganDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn,
            this.waktubookingDataGridViewTextBoxColumn,
            this.noantrianDataGridViewTextBoxColumn,
            this.idPelangganDataGridViewTextBoxColumn,
            this.idTkgCukurDataGridViewTextBoxColumn});
            this.pembookinganDataGridView.DataSource = this.pembookinganBindingSource;
            this.pembookinganDataGridView.Location = new System.Drawing.Point(312, 41);
            this.pembookinganDataGridView.Name = "pembookinganDataGridView";
            this.pembookinganDataGridView.RowHeadersWidth = 51;
            this.pembookinganDataGridView.RowTemplate.Height = 24;
            this.pembookinganDataGridView.Size = new System.Drawing.Size(488, 150);
            this.pembookinganDataGridView.TabIndex = 11;
            // 
            // idbookingDataGridViewTextBoxColumn
            // 
            this.idbookingDataGridViewTextBoxColumn.DataPropertyName = "Id_booking";
            this.idbookingDataGridViewTextBoxColumn.HeaderText = "Id_booking";
            this.idbookingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbookingDataGridViewTextBoxColumn.Name = "idbookingDataGridViewTextBoxColumn";
            this.idbookingDataGridViewTextBoxColumn.Width = 125;
            // 
            // namapelangganDataGridViewTextBoxColumn
            // 
            this.namapelangganDataGridViewTextBoxColumn.DataPropertyName = "Nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.HeaderText = "Nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namapelangganDataGridViewTextBoxColumn.Name = "namapelangganDataGridViewTextBoxColumn";
            this.namapelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // notelpDataGridViewTextBoxColumn
            // 
            this.notelpDataGridViewTextBoxColumn.DataPropertyName = "No_telp";
            this.notelpDataGridViewTextBoxColumn.HeaderText = "No_telp";
            this.notelpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notelpDataGridViewTextBoxColumn.Name = "notelpDataGridViewTextBoxColumn";
            this.notelpDataGridViewTextBoxColumn.Width = 125;
            // 
            // waktubookingDataGridViewTextBoxColumn
            // 
            this.waktubookingDataGridViewTextBoxColumn.DataPropertyName = "Waktu_booking";
            this.waktubookingDataGridViewTextBoxColumn.HeaderText = "Waktu_booking";
            this.waktubookingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.waktubookingDataGridViewTextBoxColumn.Name = "waktubookingDataGridViewTextBoxColumn";
            this.waktubookingDataGridViewTextBoxColumn.Width = 125;
            // 
            // noantrianDataGridViewTextBoxColumn
            // 
            this.noantrianDataGridViewTextBoxColumn.DataPropertyName = "No_antrian";
            this.noantrianDataGridViewTextBoxColumn.HeaderText = "No_antrian";
            this.noantrianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noantrianDataGridViewTextBoxColumn.Name = "noantrianDataGridViewTextBoxColumn";
            this.noantrianDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPelangganDataGridViewTextBoxColumn
            // 
            this.idPelangganDataGridViewTextBoxColumn.DataPropertyName = "idPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.HeaderText = "idPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPelangganDataGridViewTextBoxColumn.Name = "idPelangganDataGridViewTextBoxColumn";
            this.idPelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // idTkgCukurDataGridViewTextBoxColumn
            // 
            this.idTkgCukurDataGridViewTextBoxColumn.DataPropertyName = "Id_TkgCukur";
            this.idTkgCukurDataGridViewTextBoxColumn.HeaderText = "Id_TkgCukur";
            this.idTkgCukurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTkgCukurDataGridViewTextBoxColumn.Name = "idTkgCukurDataGridViewTextBoxColumn";
            this.idTkgCukurDataGridViewTextBoxColumn.Width = 125;
            // 
            // pembookinganBindingSource
            // 
            this.pembookinganBindingSource.DataMember = "Pembookingan";
            this.pembookinganBindingSource.DataSource = this.barberShopDataSet;
            // 
            // pembookinganTableAdapter
            // 
            this.pembookinganTableAdapter.ClearBeforeFill = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pembookinganDataGridView);
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
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView pembookinganDataGridView;
        private BarberShopDataSet barberShopDataSet;
        private System.Windows.Forms.BindingSource pembookinganBindingSource;
        private BarberShopDataSetTableAdapters.PembookinganTableAdapter pembookinganTableAdapter;
        private System.Windows.Forms.BindingSource pembookinganBindingSource1;
        private System.Windows.Forms.BindingSource pembookinganBindingSource2;
        private System.Windows.Forms.BindingSource pembookinganBindingSource3;
        private System.Windows.Forms.BindingSource pembookinganBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktubookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noantrianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTkgCukurDataGridViewTextBoxColumn;
    }
}