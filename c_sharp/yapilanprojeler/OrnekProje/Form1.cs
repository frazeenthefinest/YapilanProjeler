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
                MessageBox.Show("L�tfen t�m alanlar� doldurun.");
                //if e�er 

            }
            else
            {
                //else aksi halde 
                lstBilgier.Items.Add(txtBoxAdSoyad.Text + " " + mtxTc.Text + " " + mtxYas.Text + " " + txtBoxMail.Text);
                MessageBox.Show("Kay�t Ba�ar�yla Yap�ld�");
                // buraya tan�mlaman�n sebebi = e�er kay�t ba�ar�yla yap�ld�ysa form2 ye g�nder kay�tlar� doldurmad�ysa form1 de kal.
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
            


            MessageBox.Show("Bilgiler Temizlendi." , "Temizleme ��lemi" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
