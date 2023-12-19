namespace OrnekProje
{
    partial class Form2
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
            panel1 = new Panel();
            lblDurakSayfasi = new Label();
            grpDuraklar = new GroupBox();
            btnTarihKaydet = new Button();
            mtxYaklasanEshot = new MaskedTextBox();
            dtpTarih = new DateTimePicker();
            lblTarih = new Label();
            btnYaklasanEshot = new Button();
            btnDurakEkle = new Button();
            lblYaklasanEshot = new Label();
            mtxDurak = new MaskedTextBox();
            lblDurak = new Label();
            lstDurakYaklasan = new ListBox();
            btnKaydet = new Button();
            btnTemizle2 = new Button();
            panel1.SuspendLayout();
            grpDuraklar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(lblDurakSayfasi);
            panel1.Location = new Point(19, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 107);
            panel1.TabIndex = 0;
            // 
            // lblDurakSayfasi
            // 
            lblDurakSayfasi.AutoSize = true;
            lblDurakSayfasi.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblDurakSayfasi.Location = new Point(328, 30);
            lblDurakSayfasi.Name = "lblDurakSayfasi";
            lblDurakSayfasi.Size = new Size(334, 27);
            lblDurakSayfasi.TabIndex = 2;
            lblDurakSayfasi.Text = "Durağa Yaklaşan Eshotlar";
            // 
            // grpDuraklar
            // 
            grpDuraklar.Controls.Add(btnTarihKaydet);
            grpDuraklar.Controls.Add(mtxYaklasanEshot);
            grpDuraklar.Controls.Add(dtpTarih);
            grpDuraklar.Controls.Add(lblTarih);
            grpDuraklar.Controls.Add(btnYaklasanEshot);
            grpDuraklar.Controls.Add(btnDurakEkle);
            grpDuraklar.Controls.Add(lblYaklasanEshot);
            grpDuraklar.Controls.Add(mtxDurak);
            grpDuraklar.Controls.Add(lblDurak);
            grpDuraklar.Location = new Point(35, 145);
            grpDuraklar.Name = "grpDuraklar";
            grpDuraklar.Size = new Size(424, 572);
            grpDuraklar.TabIndex = 1;
            grpDuraklar.TabStop = false;
            grpDuraklar.Text = "Yaklaşan Eshotlar";
            // 
            // btnTarihKaydet
            // 
            btnTarihKaydet.BackColor = Color.PaleGreen;
            btnTarihKaydet.Location = new Point(192, 435);
            btnTarihKaydet.Name = "btnTarihKaydet";
            btnTarihKaydet.Size = new Size(135, 39);
            btnTarihKaydet.TabIndex = 6;
            btnTarihKaydet.Text = "Tarihi Kaydet";
            btnTarihKaydet.UseVisualStyleBackColor = false;
            btnTarihKaydet.Click += btnTarihKaydet_Click;
            // 
            // mtxYaklasanEshot
            // 
            mtxYaklasanEshot.Location = new Point(212, 201);
            mtxYaklasanEshot.Mask = "000000";
            mtxYaklasanEshot.Name = "mtxYaklasanEshot";
            mtxYaklasanEshot.Size = new Size(125, 32);
            mtxYaklasanEshot.TabIndex = 4;
            mtxYaklasanEshot.ValidatingType = typeof(int);
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(117, 369);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 32);
            dtpTarih.TabIndex = 4;
            dtpTarih.ValueChanged += dtpTarih_ValueChanged;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(16, 377);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(66, 24);
            lblTarih.TabIndex = 5;
            lblTarih.Text = "Tarih : ";
            // 
            // btnYaklasanEshot
            // 
            btnYaklasanEshot.BackColor = Color.SpringGreen;
            btnYaklasanEshot.Location = new Point(223, 272);
            btnYaklasanEshot.Name = "btnYaklasanEshot";
            btnYaklasanEshot.Size = new Size(145, 36);
            btnYaklasanEshot.TabIndex = 5;
            btnYaklasanEshot.Text = "Eshotu Kaydet";
            btnYaklasanEshot.UseVisualStyleBackColor = false;
            btnYaklasanEshot.Click += btnYaklasanEshot_Click;
            // 
            // btnDurakEkle
            // 
            btnDurakEkle.BackColor = Color.Chartreuse;
            btnDurakEkle.Location = new Point(234, 107);
            btnDurakEkle.Name = "btnDurakEkle";
            btnDurakEkle.Size = new Size(123, 33);
            btnDurakEkle.TabIndex = 4;
            btnDurakEkle.Text = "Durak Ekle";
            btnDurakEkle.UseVisualStyleBackColor = false;
            btnDurakEkle.Click += btnDurakEkle_Click;
            // 
            // lblYaklasanEshot
            // 
            lblYaklasanEshot.AutoSize = true;
            lblYaklasanEshot.Location = new Point(50, 209);
            lblYaklasanEshot.Name = "lblYaklasanEshot";
            lblYaklasanEshot.Size = new Size(150, 24);
            lblYaklasanEshot.TabIndex = 4;
            lblYaklasanEshot.Text = "Yaklaşan Eshot : ";
            // 
            // mtxDurak
            // 
            mtxDurak.Location = new Point(212, 51);
            mtxDurak.Mask = "0000000";
            mtxDurak.Name = "mtxDurak";
            mtxDurak.Size = new Size(115, 32);
            mtxDurak.TabIndex = 5;
            mtxDurak.ValidatingType = typeof(int);
            // 
            // lblDurak
            // 
            lblDurak.AutoSize = true;
            lblDurak.Location = new Point(50, 54);
            lblDurak.Name = "lblDurak";
            lblDurak.Size = new Size(102, 24);
            lblDurak.TabIndex = 2;
            lblDurak.Text = "Durak No : ";
            // 
            // lstDurakYaklasan
            // 
            lstDurakYaklasan.FormattingEnabled = true;
            lstDurakYaklasan.ItemHeight = 24;
            lstDurakYaklasan.Location = new Point(486, 199);
            lstDurakYaklasan.Name = "lstDurakYaklasan";
            lstDurakYaklasan.Size = new Size(546, 148);
            lstDurakYaklasan.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.YellowGreen;
            btnKaydet.Location = new Point(715, 459);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 47);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnTemizle2
            // 
            btnTemizle2.BackColor = Color.YellowGreen;
            btnTemizle2.Location = new Point(829, 555);
            btnTemizle2.Name = "btnTemizle2";
            btnTemizle2.Size = new Size(203, 47);
            btnTemizle2.TabIndex = 4;
            btnTemizle2.Text = "Temizle Ve Kaydet";
            btnTemizle2.UseVisualStyleBackColor = false;
            btnTemizle2.Click += btnTemizle2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 729);
            Controls.Add(btnTemizle2);
            Controls.Add(btnKaydet);
            Controls.Add(lstDurakYaklasan);
            Controls.Add(grpDuraklar);
            Controls.Add(panel1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Eshot Sistem ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpDuraklar.ResumeLayout(false);
            grpDuraklar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox grpDuraklar;
        private Label lblDurakSayfasi;
        private Label lblDurak;
        private Button btnDurakEkle;
        private MaskedTextBox mtxDurak;
        private Label lblYaklasanEshot;
        private Button btnYaklasanEshot;
        private MaskedTextBox mtxYaklasanEshot;
        private ListBox lstDurakYaklasan;
        private Button btnKaydet;
        private Button btnTarihKaydet;
        private DateTimePicker dtpTarih;
        private Label lblTarih;
        private Button btnTemizle2;
    }
}