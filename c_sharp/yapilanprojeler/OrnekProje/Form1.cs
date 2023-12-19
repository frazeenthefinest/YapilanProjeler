using System.Diagnostics.Eventing.Reader;

namespace OrnekProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAdSoyad_Click(object sender, EventArgs e)
        {
            string adsoyad;
            adsoyad = txtBoxAdSoyad.Text;
            //lblAdSoyad.Text = adsoyad;
            lstBilgier.Items.Add(adsoyad);

            btnAdSoyad.Enabled = false;
            

        }

        private void btnTc_Click(object sender, EventArgs e)
        {
            string kimlikno;
            kimlikno = mtxTc.Text;
            //lblTc.Text = kimlikno;
            lstBilgier.Items.Add(kimlikno);

            
            btnTc.Enabled = false;
            

        }

        private void btnYas_Click(object sender, EventArgs e)
        {
            string yas;
            yas = mtxYas.Text;

            lstBilgier.Items.Add(yas);

            
            btnYas.Enabled = false;
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            string mail;
            mail = txtBoxMail.Text;
            lstBilgier.Items.Add(mail);

            
            btnMail.Enabled = false;
           
        }

        private void btnBilgileriKaydet_Click(object sender, EventArgs e)
        {
            //lstBilgier.Items.Add(txtBoxAdSoyad.Text + " " + mtxTc.Text + " " + mtxYas.Text + " " + txtBoxMail.Text);

            if (string.IsNullOrWhiteSpace(txtBoxAdSoyad.Text) || string.IsNullOrWhiteSpace(mtxTc.Text) || string.IsNullOrWhiteSpace(mtxYas.Text) || string.IsNullOrWhiteSpace(txtBoxMail.Text))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.");
                //if eðer 

            }
            else
            {
                //else aksi halde 
                lstBilgier.Items.Add(txtBoxAdSoyad.Text + " " + mtxTc.Text + " " + mtxYas.Text + " " + txtBoxMail.Text);
                MessageBox.Show("Kayýt Baþarýyla Yapýldý");
                // buraya tanýmlamanýn sebebi = eðer kayýt baþarýyla yapýldýysa form2 ye gönder kayýtlarý doldurmadýysa form1 de kal.
                Form2 form2 = new Form2();
                
                form2.Show();
                this.Hide();
            }

            //Form2 form2 = new Form2();
            //form2.Show();
            //this.Hide();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstBilgier.Items.Clear();
            txtBoxAdSoyad.Clear();
            mtxTc.Clear();
            mtxYas.Clear();
            txtBoxMail.Clear();
            
            
            btnAdSoyad.Enabled = true;
            btnTc.Enabled = true;
            btnMail.Enabled = true;
            btnYas.Enabled = true;
            


            MessageBox.Show("Bilgiler Temizlendi." , "Temizleme Ýþlemi" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
