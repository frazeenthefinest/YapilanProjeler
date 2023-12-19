namespace OrnekProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAdSoyad = new Label();
            btnAdSoyad = new Button();
            txtBoxAdSoyad = new TextBox();
            btnYas = new Button();
            lblSistem = new Label();
            btnMail = new Button();
            lblYas = new Label();
            btnTc = new Button();
            lblMail = new Label();
            pnlLogin = new Panel();
            grpKayıt = new GroupBox();
            txtBoxMail = new TextBox();
            mtxYas = new MaskedTextBox();
            mtxTc = new MaskedTextBox();
            lblTc = new Label();
            lstBilgier = new ListBox();
            btnBilgileriKaydet = new Button();
            btnTemizle = new Button();
            pnlLogin.SuspendLayout();
            grpKayıt.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAdSoyad.Location = new Point(56, 45);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(104, 24);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Ad Soyad : ";
            // 
            // btnAdSoyad
            // 
            btnAdSoyad.BackColor = Color.Lime;
            btnAdSoyad.Location = new Point(219, 95);
            btnAdSoyad.Name = "btnAdSoyad";
            btnAdSoyad.Size = new Size(135, 29);
            btnAdSoyad.TabIndex = 1;
            btnAdSoyad.Text = "Ad Soyad Kaydet";
            btnAdSoyad.UseVisualStyleBackColor = false;
            btnAdSoyad.Click += btnAdSoyad_Click;
            // 
            // txtBoxAdSoyad
            // 
            txtBoxAdSoyad.Location = new Point(166, 42);
            txtBoxAdSoyad.Name = "txtBoxAdSoyad";
            txtBoxAdSoyad.Size = new Size(188, 27);
            txtBoxAdSoyad.TabIndex = 2;
            // 
            // btnYas
            // 
            btnYas.BackColor = Color.Lime;
            btnYas.Location = new Point(260, 324);
            btnYas.Name = "btnYas";
            btnYas.Size = new Size(94, 29);
            btnYas.TabIndex = 5;
            btnYas.Text = "Yaş Kaydet";
            btnYas.UseVisualStyleBackColor = false;
            btnYas.Click += btnYas_Click;
            // 
            // lblSistem
            // 
            lblSistem.AutoSize = true;
            lblSistem.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblSistem.Location = new Point(296, 43);
            lblSistem.Name = "lblSistem";
            lblSistem.Size = new Size(520, 27);
            lblSistem.TabIndex = 4;
            lblSistem.Text = "Durağa Yaklaşan Otobüsler Sistemi Login";
            // 
            // btnMail
            // 
            btnMail.BackColor = Color.Lime;
            btnMail.Location = new Point(239, 442);
            btnMail.Name = "btnMail";
            btnMail.Size = new Size(115, 29);
            btnMail.TabIndex = 7;
            btnMail.Text = "Mail Kaydet";
            btnMail.UseVisualStyleBackColor = false;
            btnMail.Click += btnMail_Click;
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblYas.Location = new Point(108, 272);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(52, 24);
            lblYas.TabIndex = 6;
            lblYas.Text = "Yaş : ";
            // 
            // btnTc
            // 
            btnTc.BackColor = Color.Lime;
            btnTc.Location = new Point(216, 208);
            btnTc.Name = "btnTc";
            btnTc.Size = new Size(138, 29);
            btnTc.TabIndex = 9;
            btnTc.Text = "Kimlik No Kaydet";
            btnTc.UseVisualStyleBackColor = false;
            btnTc.Click += btnTc_Click;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMail.Location = new Point(101, 394);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(59, 24);
            lblMail.TabIndex = 8;
            lblMail.Text = "Mail : ";
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.MistyRose;
            pnlLogin.Controls.Add(lblSistem);
            pnlLogin.Location = new Point(12, 12);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(1162, 125);
            pnlLogin.TabIndex = 10;
            // 
            // grpKayıt
            // 
            grpKayıt.Controls.Add(txtBoxMail);
            grpKayıt.Controls.Add(mtxYas);
            grpKayıt.Controls.Add(mtxTc);
            grpKayıt.Controls.Add(btnMail);
            grpKayıt.Controls.Add(lblTc);
            grpKayıt.Controls.Add(txtBoxAdSoyad);
            grpKayıt.Controls.Add(lblMail);
            grpKayıt.Controls.Add(lblAdSoyad);
            grpKayıt.Controls.Add(btnYas);
            grpKayıt.Controls.Add(btnAdSoyad);
            grpKayıt.Controls.Add(lblYas);
            grpKayıt.Controls.Add(btnTc);
            grpKayıt.Location = new Point(12, 143);
            grpKayıt.Name = "grpKayıt";
            grpKayıt.Size = new Size(417, 477);
            grpKayıt.TabIndex = 12;
            grpKayıt.TabStop = false;
            grpKayıt.Text = "Kayıt Olma İşlemi";
            // 
            // txtBoxMail
            // 
            txtBoxMail.Location = new Point(166, 394);
            txtBoxMail.Name = "txtBoxMail";
            txtBoxMail.Size = new Size(188, 27);
            txtBoxMail.TabIndex = 13;
            // 
            // mtxYas
            // 
            mtxYas.Location = new Point(175, 269);
            mtxYas.Mask = "00";
            mtxYas.Name = "mtxYas";
            mtxYas.Size = new Size(179, 27);
            mtxYas.TabIndex = 13;
            mtxYas.ValidatingType = typeof(int);
            // 
            // mtxTc
            // 
            mtxTc.Location = new Point(175, 153);
            mtxTc.Mask = "00000000000";
            mtxTc.Name = "mtxTc";
            mtxTc.Size = new Size(179, 27);
            mtxTc.TabIndex = 14;
            mtxTc.ValidatingType = typeof(int);
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTc.Location = new Point(54, 156);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(106, 24);
            lblTc.TabIndex = 13;
            lblTc.Text = "Kimlik No : ";
            // 
            // lstBilgier
            // 
            lstBilgier.FormattingEnabled = true;
            lstBilgier.Location = new Point(467, 172);
            lstBilgier.Name = "lstBilgier";
            lstBilgier.Size = new Size(646, 284);
            lstBilgier.TabIndex = 13;
            // 
            // btnBilgileriKaydet
            // 
            btnBilgileriKaydet.BackColor = Color.LawnGreen;
            btnBilgileriKaydet.Location = new Point(726, 486);
            btnBilgileriKaydet.Name = "btnBilgileriKaydet";
            btnBilgileriKaydet.Size = new Size(140, 29);
            btnBilgileriKaydet.TabIndex = 14;
            btnBilgileriKaydet.Text = "Bilgileri Kaydet ";
            btnBilgileriKaydet.UseVisualStyleBackColor = false;
            btnBilgileriKaydet.Click += btnBilgileriKaydet_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.LawnGreen;
            btnTemizle.Location = new Point(973, 554);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(140, 36);
            btnTemizle.TabIndex = 15;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 622);
            Controls.Add(btnTemizle);
            Controls.Add(btnBilgileriKaydet);
            Controls.Add(lstBilgier);
            Controls.Add(grpKayıt);
            Controls.Add(pnlLogin);
            Name = "Form1";
            Text = "Login";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            grpKayıt.ResumeLayout(false);
            grpKayıt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAdSoyad;
        private Button btnAdSoyad;
        private TextBox txtBoxAdSoyad;
        private Button btnYas;
        private Label lblSistem;
        private Button btnMail;
        private Label lblYas;
        private Button btnTc;
        private Label lblMail;
        private Panel pnlLogin;
        private GroupBox grpKayıt;
        private Label lblTc;
        private MaskedTextBox mtxTc;
        private MaskedTextBox mtxYas;
        private TextBox txtBoxMail;
        private ListBox lstBilgier;
        private Button btnBilgileriKaydet;
        private Button btnTemizle;
    }
}
