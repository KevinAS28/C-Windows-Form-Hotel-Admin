namespace hotel_fave
{
    partial class Form1
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
            this.nama_penyewa = new System.Windows.Forms.TextBox();
            this.kode_kamar = new System.Windows.Forms.ComboBox();
            this.jenis_kamar = new System.Windows.Forms.TextBox();
            this.superior = new System.Windows.Forms.RadioButton();
            this.deluxe = new System.Windows.Forms.RadioButton();
            this.suite = new System.Windows.Forms.RadioButton();
            this.Internet = new System.Windows.Forms.CheckBox();
            this.tv_cable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.biaya_sewa = new System.Windows.Forms.TextBox();
            this.fasilitas_tambahan = new System.Windows.Forms.TextBox();
            this.total_sewa = new System.Windows.Forms.TextBox();
            this.bayar = new System.Windows.Forms.TextBox();
            this.kembali = new System.Windows.Forms.TextBox();
            this.keluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nama_penyewa
            // 
            this.nama_penyewa.Location = new System.Drawing.Point(141, 46);
            this.nama_penyewa.Name = "nama_penyewa";
            this.nama_penyewa.Size = new System.Drawing.Size(100, 20);
            this.nama_penyewa.TabIndex = 0;
            // 
            // kode_kamar
            // 
            this.kode_kamar.FormattingEnabled = true;
            this.kode_kamar.Location = new System.Drawing.Point(141, 90);
            this.kode_kamar.Name = "kode_kamar";
            this.kode_kamar.Size = new System.Drawing.Size(121, 21);
            this.kode_kamar.TabIndex = 1;
            this.kode_kamar.SelectedIndexChanged += new System.EventHandler(this.Kode_kamar_SelectedIndexChanged);
            // 
            // jenis_kamar
            // 
            this.jenis_kamar.Location = new System.Drawing.Point(141, 134);
            this.jenis_kamar.Name = "jenis_kamar";
            this.jenis_kamar.Size = new System.Drawing.Size(121, 20);
            this.jenis_kamar.TabIndex = 2;
            // 
            // superior
            // 
            this.superior.AutoSize = true;
            this.superior.Location = new System.Drawing.Point(141, 184);
            this.superior.Name = "superior";
            this.superior.Size = new System.Drawing.Size(62, 17);
            this.superior.TabIndex = 3;
            this.superior.TabStop = true;
            this.superior.Text = "superior";
            this.superior.UseVisualStyleBackColor = true;
            this.superior.CheckedChanged += new System.EventHandler(this.Superior_CheckedChanged);
            // 
            // deluxe
            // 
            this.deluxe.AutoSize = true;
            this.deluxe.Location = new System.Drawing.Point(141, 207);
            this.deluxe.Name = "deluxe";
            this.deluxe.Size = new System.Drawing.Size(56, 17);
            this.deluxe.TabIndex = 4;
            this.deluxe.TabStop = true;
            this.deluxe.Text = "deluxe";
            this.deluxe.UseVisualStyleBackColor = true;
            this.deluxe.CheckedChanged += new System.EventHandler(this.Deluxe_CheckedChanged);
            // 
            // suite
            // 
            this.suite.AutoSize = true;
            this.suite.Location = new System.Drawing.Point(141, 230);
            this.suite.Name = "suite";
            this.suite.Size = new System.Drawing.Size(47, 17);
            this.suite.TabIndex = 5;
            this.suite.TabStop = true;
            this.suite.Text = "suite";
            this.suite.UseVisualStyleBackColor = true;
            this.suite.CheckedChanged += new System.EventHandler(this.Suite_CheckedChanged);
            // 
            // Internet
            // 
            this.Internet.AutoSize = true;
            this.Internet.Location = new System.Drawing.Point(41, 55);
            this.Internet.Name = "Internet";
            this.Internet.Size = new System.Drawing.Size(62, 17);
            this.Internet.TabIndex = 6;
            this.Internet.Text = "Internet";
            this.Internet.UseVisualStyleBackColor = true;
            this.Internet.CheckedChanged += new System.EventHandler(this.Internet_CheckedChanged);
            // 
            // tv_cable
            // 
            this.tv_cable.AutoSize = true;
            this.tv_cable.Location = new System.Drawing.Point(153, 55);
            this.tv_cable.Name = "tv_cable";
            this.tv_cable.Size = new System.Drawing.Size(70, 17);
            this.tv_cable.TabIndex = 7;
            this.tv_cable.Text = "TV Cable";
            this.tv_cable.UseVisualStyleBackColor = true;
            this.tv_cable.CheckedChanged += new System.EventHandler(this.Tv_cable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tv_cable);
            this.groupBox1.Controls.Add(this.Internet);
            this.groupBox1.Location = new System.Drawing.Point(141, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fasilitas Tambahan";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // biaya_sewa
            // 
            this.biaya_sewa.Location = new System.Drawing.Point(543, 46);
            this.biaya_sewa.Name = "biaya_sewa";
            this.biaya_sewa.Size = new System.Drawing.Size(100, 20);
            this.biaya_sewa.TabIndex = 9;
            // 
            // fasilitas_tambahan
            // 
            this.fasilitas_tambahan.Location = new System.Drawing.Point(543, 91);
            this.fasilitas_tambahan.Name = "fasilitas_tambahan";
            this.fasilitas_tambahan.Size = new System.Drawing.Size(151, 20);
            this.fasilitas_tambahan.TabIndex = 10;
            // 
            // total_sewa
            // 
            this.total_sewa.Location = new System.Drawing.Point(543, 134);
            this.total_sewa.Name = "total_sewa";
            this.total_sewa.Size = new System.Drawing.Size(151, 20);
            this.total_sewa.TabIndex = 11;
            // 
            // bayar
            // 
            this.bayar.Location = new System.Drawing.Point(543, 227);
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(151, 20);
            this.bayar.TabIndex = 12;
            this.bayar.TextChanged += new System.EventHandler(this.Bayar_TextChanged);
            // 
            // kembali
            // 
            this.kembali.Location = new System.Drawing.Point(543, 264);
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(151, 20);
            this.kembali.TabIndex = 13;
            // 
            // keluar
            // 
            this.keluar.Location = new System.Drawing.Point(585, 357);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(75, 23);
            this.keluar.TabIndex = 14;
            this.keluar.Text = "keluar";
            this.keluar.UseVisualStyleBackColor = true;
            this.keluar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nama Penyewa";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kode Kamar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Jenis Kamar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Biaya Sewa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fasilitas Tambahan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total Sewa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Bayar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Kembali";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.kembali);
            this.Controls.Add(this.bayar);
            this.Controls.Add(this.total_sewa);
            this.Controls.Add(this.fasilitas_tambahan);
            this.Controls.Add(this.biaya_sewa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.suite);
            this.Controls.Add(this.deluxe);
            this.Controls.Add(this.superior);
            this.Controls.Add(this.jenis_kamar);
            this.Controls.Add(this.kode_kamar);
            this.Controls.Add(this.nama_penyewa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nama_penyewa;
        private System.Windows.Forms.ComboBox kode_kamar;
        private System.Windows.Forms.TextBox jenis_kamar;
        private System.Windows.Forms.RadioButton superior;
        private System.Windows.Forms.RadioButton deluxe;
        private System.Windows.Forms.RadioButton suite;
        private System.Windows.Forms.CheckBox Internet;
        private System.Windows.Forms.CheckBox tv_cable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox biaya_sewa;
        private System.Windows.Forms.TextBox fasilitas_tambahan;
        private System.Windows.Forms.TextBox total_sewa;
        private System.Windows.Forms.TextBox bayar;
        private System.Windows.Forms.TextBox kembali;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

