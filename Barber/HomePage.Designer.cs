namespace Barber
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Pembookingan = new System.Windows.Forms.Button();
            this.Pelanggan = new System.Windows.Forms.Button();
            this.TukangCukur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "BARBERSHOP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(248, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Antrian";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pembookingan
            // 
            this.Pembookingan.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pembookingan.Location = new System.Drawing.Point(248, 213);
            this.Pembookingan.Name = "Pembookingan";
            this.Pembookingan.Size = new System.Drawing.Size(300, 59);
            this.Pembookingan.TabIndex = 2;
            this.Pembookingan.Text = "Pembookingan";
            this.Pembookingan.UseVisualStyleBackColor = true;
            this.Pembookingan.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pelanggan
            // 
            this.Pelanggan.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pelanggan.Location = new System.Drawing.Point(248, 278);
            this.Pelanggan.Name = "Pelanggan";
            this.Pelanggan.Size = new System.Drawing.Size(300, 59);
            this.Pelanggan.TabIndex = 3;
            this.Pelanggan.Text = "Pelanggan";
            this.Pelanggan.UseVisualStyleBackColor = true;
            this.Pelanggan.Click += new System.EventHandler(this.button3_Click);
            // 
            // TukangCukur
            // 
            this.TukangCukur.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TukangCukur.Location = new System.Drawing.Point(248, 343);
            this.TukangCukur.Name = "TukangCukur";
            this.TukangCukur.Size = new System.Drawing.Size(300, 59);
            this.TukangCukur.TabIndex = 4;
            this.TukangCukur.Text = "Tukang Cukur";
            this.TukangCukur.UseVisualStyleBackColor = true;
            this.TukangCukur.Click += new System.EventHandler(this.button4_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TukangCukur);
            this.Controls.Add(this.Pelanggan);
            this.Controls.Add(this.Pembookingan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Pembookingan;
        private System.Windows.Forms.Button Pelanggan;
        private System.Windows.Forms.Button TukangCukur;
    }
}

