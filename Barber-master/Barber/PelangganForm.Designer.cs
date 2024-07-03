namespace Barber
{
    partial class PelangganForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pelangganDataGridView = new System.Windows.Forms.DataGridView();
            this.barberShopDataSet = new Barber.BarberShopDataSet();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelangganTableAdapter = new Barber.BarberShopDataSetTableAdapters.PelangganTableAdapter();
            this.namapelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelangganBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pelangganBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pelangganBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pelangganDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pelangganBindingSource1, "Nama_pelanggan", true));
            this.textBox1.Location = new System.Drawing.Point(32, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pelangganBindingSource2, "No_telp", true));
            this.textBox2.Location = new System.Drawing.Point(32, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pelangganBindingSource3, "idPelanggan", true));
            this.textBox3.Location = new System.Drawing.Point(32, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 22);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nomor Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id Pelanggan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Update_Click);
            // 
            // pelangganDataGridView
            // 
            this.pelangganDataGridView.AutoGenerateColumns = false;
            this.pelangganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pelangganDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namapelangganDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn,
            this.idPelangganDataGridViewTextBoxColumn});
            this.pelangganDataGridView.DataSource = this.pelangganBindingSource;
            this.pelangganDataGridView.Location = new System.Drawing.Point(343, 74);
            this.pelangganDataGridView.Name = "pelangganDataGridView";
            this.pelangganDataGridView.RowHeadersWidth = 51;
            this.pelangganDataGridView.RowTemplate.Height = 24;
            this.pelangganDataGridView.Size = new System.Drawing.Size(427, 113);
            this.pelangganDataGridView.TabIndex = 9;
            // 
            // barberShopDataSet
            // 
            this.barberShopDataSet.DataSetName = "BarberShopDataSet";
            this.barberShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataMember = "Pelanggan";
            this.pelangganBindingSource.DataSource = this.barberShopDataSet;
            // 
            // pelangganTableAdapter
            // 
            this.pelangganTableAdapter.ClearBeforeFill = true;
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
            // idPelangganDataGridViewTextBoxColumn
            // 
            this.idPelangganDataGridViewTextBoxColumn.DataPropertyName = "idPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.HeaderText = "idPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPelangganDataGridViewTextBoxColumn.Name = "idPelangganDataGridViewTextBoxColumn";
            this.idPelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // pelangganBindingSource1
            // 
            this.pelangganBindingSource1.DataMember = "Pelanggan";
            this.pelangganBindingSource1.DataSource = this.barberShopDataSet;
            // 
            // pelangganBindingSource2
            // 
            this.pelangganBindingSource2.DataMember = "Pelanggan";
            this.pelangganBindingSource2.DataSource = this.barberShopDataSet;
            // 
            // pelangganBindingSource3
            // 
            this.pelangganBindingSource3.DataMember = "Pelanggan";
            this.pelangganBindingSource3.DataSource = this.barberShopDataSet;
            // 
            // PelangganForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pelangganDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "PelangganForm";
            this.Text = "PelangganForm";
            this.Load += new System.EventHandler(this.PelangganForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pelangganDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView pelangganDataGridView;
        private BarberShopDataSet barberShopDataSet;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private BarberShopDataSetTableAdapters.PelangganTableAdapter pelangganTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pelangganBindingSource1;
        private System.Windows.Forms.BindingSource pelangganBindingSource2;
        private System.Windows.Forms.BindingSource pelangganBindingSource3;
    }
}