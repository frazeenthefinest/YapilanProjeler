using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrnekProje
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            int değişken=2;
            InitializeComponent();
        }

        private void btnDurakEkle_Click(object sender, EventArgs e)
        {
            string durakekle;
            durakekle = mtxDurak.Text;
            lblDurak.Text = durakekle;

            btnDurakEkle.Enabled = false;

        }

        private void btnYaklasanEshot_Click(object sender, EventArgs e)
        {
            string yaklasaneshot;
            yaklasaneshot = mtxYaklasanEshot.Text;
            lblYaklasanEshot.Text = yaklasaneshot;


            btnYaklasanEshot.Enabled = false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //lstDurakYaklasan.Items.Add(mtxDurak.Text + " " +mtxYaklasanEshot.Text);
            //MessageBox.Show("Kaydedildi Yaklaşan Eshotu Görüntüleyebilirsiniz.");

            if (string.IsNullOrWhiteSpace(mtxDurak.Text) || string.IsNullOrWhiteSpace(mtxYaklasanEshot.Text) || string.IsNullOrWhiteSpace(dtpTarih.Text))

            {
                MessageBox.Show("Lütfen Durak Numaranızı Veya Yaklaşan Eshot Numarasını Kontrol Ediniz.");

            }
            else
            {
                lstDurakYaklasan.Items.Add("Durak : " + mtxDurak.Text + " Yaklaşan Eshot : " + mtxYaklasanEshot.Text + " Tarih :" + dtpTarih.Text);
                MessageBox.Show("Kaydedildi Yaklaşan Eshotu Görüntüleyebilirsiniz.");

            }
        }

        private void btnTarihKaydet_Click(object sender, EventArgs e)
        {
            string tarih;
            tarih = dtpTarih.Text;
            lblTarih.Text = tarih;


            btnTarihKaydet.Enabled = false;

        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            btnDurakEkle.Enabled = true;
            btnYaklasanEshot.Enabled = true;
            btnTarihKaydet.Enabled = true;
            //dtpTarih.Enabled = true;

            lstDurakYaklasan.Items.Clear();
            mtxDurak.Clear();
            mtxYaklasanEshot.Clear();

        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            //dtpTarih.Enabled = false;
        }
    }
}
