using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_fave
{
    public partial class Form1 : Form
    {
        struct kamar
        {
            public string nama;
            public Dictionary<string, double> tipe;
            public kamar(string n, double s, double d, double su)
            {
                this.nama = n;
                this.tipe = new Dictionary<string, double>() { { "superior", s }, { "deluxe", d }, { "suite", su } };
            }
        };

        Dictionary<string, kamar> all_kamar = new Dictionary<string, kamar>() {
            {"S001", new kamar("Single bed", 1000000, 900000, 800000)},
            {"D001", new kamar("Double bed", 1200000, 1000000, 900000)},
        };

        public List<RadioButton> tipe_kamar;

        public Dictionary<string, double> fasilitas_tambahan_harga = new Dictionary<string, double>() {
            {"Internet", 200000},
            {"TV Cable", 100000}
        };

        List<RadioButton> tipe_kamar_radio;
        List<CheckBox> fasilitas_tambahan_check;
        private double harga_total;
        public Form1()
        {
            InitializeComponent();
            foreach (KeyValuePair<string, kamar> k in this.all_kamar)
            {
                this.kode_kamar.Items.Add(k.Key);
            }
            this.tipe_kamar = new List<RadioButton>() { this.superior, this.deluxe, this.suite };
            this.tipe_kamar_radio = new List<RadioButton>() {this.superior, this.deluxe, this.suite};
            this.fasilitas_tambahan_check = new List<CheckBox>() {this.Internet, this.tv_cable};
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Kode_kamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.updateHarga();
        }

        public void Tipe_Kamar()
        {

        }
        private void updateHarga()
        {
            double harga = 0, sewa = 0, fth = 0;
            string kk, tk = "", ft;
            try
            {
                kk = this.kode_kamar.SelectedItem.ToString();
                
                foreach (RadioButton rb in this.tipe_kamar_radio)
                {
                    if (rb.Checked)
                    {
                        tk = rb.Text;
                        break;
                    }
                }
                    if ((tk == "")|(kk=="")) { return; }
                Console.WriteLine("Kode kamar: "+kk);
                Console.WriteLine("Tipe kamar: " + tk);
                harga += this.all_kamar[kk].tipe[tk];
                sewa += harga;
                this.jenis_kamar.Text = Convert.ToString(this.all_kamar[kk].nama);
                foreach (CheckBox x in fasilitas_tambahan_check)
                {
                    if (x.Checked)
                    {
                        harga += fasilitas_tambahan_harga[x.Text];
                        fth += fasilitas_tambahan_harga[x.Text];
                    }
                }
                Console.WriteLine(Convert.ToString(harga));
            }
            catch (NullReferenceException e)
            {

            }
            this.biaya_sewa.Text = Convert.ToString(sewa);
            this.fasilitas_tambahan.Text = Convert.ToString(fth);
            this.total_sewa.Text = Convert.ToString(harga);
            this.harga_total = harga;
            
        }
        private void Superior_CheckedChanged(object sender, EventArgs e)
        {
            this.updateHarga();
        }

        private void Deluxe_CheckedChanged(object sender, EventArgs e)
        {
            this.updateHarga();
        }

        private void Suite_CheckedChanged(object sender, EventArgs e)
        {
            this.updateHarga();
        }

        private void Internet_CheckedChanged(object sender, EventArgs e)
        {
            this.updateHarga();
        }

        private void Tv_cable_CheckedChanged(object sender, EventArgs e)
        {
            this.updateHarga();
        }

        private void Bayar_TextChanged(object sender, EventArgs e)
        {
            double bayar = 0;
            try{
                bayar = Convert.ToDouble(this.bayar.Text);
            }
            catch
            {
                this.kembali.Text = "Input bayar salah";
                return;
            }
            double kembali = bayar - this.harga_total;
            if (kembali < 0)
            {
                this.kembali.Text = "Uang anda tidak cukup";
                return;
            }
            this.kembali.Text = Convert.ToString(kembali);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}