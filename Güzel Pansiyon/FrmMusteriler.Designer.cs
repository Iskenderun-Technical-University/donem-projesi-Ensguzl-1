namespace GÜZEL_OTOMASYON
{
    partial class FrmMusteriler
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            BtnVerileriGoster = new Button();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnAra = new Button();
            DtpcikisTarihi = new DateTimePicker();
            DtpGirisTarihi = new DateTimePicker();
            MskTxtTelefon = new MaskedTextBox();
            TxtUcret = new TextBox();
            TxtOdaNo = new TextBox();
            TxtKimlikNo = new TextBox();
            TxtMail = new TextBox();
            comboBox1 = new ComboBox();
            TxtSoyadi = new TextBox();
            TxtAdi = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label1 = new Label();
            label2 = new Label();
            label8 = new Label();
            label3 = new Label();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            BtnTemizle = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Location = new Point(1, 378);
            listView1.Name = "listView1";
            listView1.Size = new Size(1090, 199);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cinsiyet";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mail";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TC";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "OdaNo";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ücret";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Giriş Tarihi";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Çıkış Tarihi";
            // 
            // BtnVerileriGoster
            // 
            BtnVerileriGoster.BackColor = Color.Lime;
            BtnVerileriGoster.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerileriGoster.Location = new Point(930, 6);
            BtnVerileriGoster.Name = "BtnVerileriGoster";
            BtnVerileriGoster.Size = new Size(161, 57);
            BtnVerileriGoster.TabIndex = 1;
            BtnVerileriGoster.Text = "Verileri Göster";
            BtnVerileriGoster.UseVisualStyleBackColor = false;
            BtnVerileriGoster.Click += button1_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.Lime;
            BtnGuncelle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(930, 69);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(161, 56);
            BtnGuncelle.TabIndex = 2;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.Lime;
            BtnSil.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSil.Location = new Point(930, 128);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(161, 55);
            BtnSil.TabIndex = 3;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnAra
            // 
            BtnAra.BackColor = Color.Lime;
            BtnAra.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAra.Location = new Point(930, 253);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(161, 57);
            BtnAra.TabIndex = 4;
            BtnAra.Text = "Ara";
            BtnAra.UseVisualStyleBackColor = false;
            BtnAra.Click += BtnAra_Click;
            // 
            // DtpcikisTarihi
            // 
            DtpcikisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DtpcikisTarihi.Location = new Point(592, 167);
            DtpcikisTarihi.Name = "DtpcikisTarihi";
            DtpcikisTarihi.Size = new Size(238, 27);
            DtpcikisTarihi.TabIndex = 40;
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DtpGirisTarihi.Location = new Point(592, 121);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(238, 27);
            DtpGirisTarihi.TabIndex = 39;
            // 
            // MskTxtTelefon
            // 
            MskTxtTelefon.BackColor = Color.FromArgb(255, 255, 192);
            MskTxtTelefon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            MskTxtTelefon.Location = new Point(169, 137);
            MskTxtTelefon.Mask = "(999) 000-0000";
            MskTxtTelefon.Name = "MskTxtTelefon";
            MskTxtTelefon.Size = new Size(238, 30);
            MskTxtTelefon.TabIndex = 38;
            // 
            // TxtUcret
            // 
            TxtUcret.BackColor = Color.FromArgb(255, 255, 192);
            TxtUcret.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtUcret.Location = new Point(592, 69);
            TxtUcret.Name = "TxtUcret";
            TxtUcret.Size = new Size(238, 30);
            TxtUcret.TabIndex = 37;
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.BackColor = Color.FromArgb(255, 255, 192);
            TxtOdaNo.Enabled = false;
            TxtOdaNo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtOdaNo.Location = new Point(592, 19);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(238, 30);
            TxtOdaNo.TabIndex = 36;
            // 
            // TxtKimlikNo
            // 
            TxtKimlikNo.BackColor = Color.FromArgb(255, 255, 192);
            TxtKimlikNo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtKimlikNo.Location = new Point(169, 220);
            TxtKimlikNo.MaxLength = 11;
            TxtKimlikNo.Name = "TxtKimlikNo";
            TxtKimlikNo.Size = new Size(238, 30);
            TxtKimlikNo.TabIndex = 35;
            // 
            // TxtMail
            // 
            TxtMail.BackColor = Color.FromArgb(255, 255, 192);
            TxtMail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtMail.Location = new Point(169, 177);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(238, 30);
            TxtMail.TabIndex = 34;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 255, 192);
            comboBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bay ", "Bayan" });
            comboBox1.Location = new Point(169, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 31);
            comboBox1.TabIndex = 33;
            // 
            // TxtSoyadi
            // 
            TxtSoyadi.BackColor = Color.FromArgb(255, 255, 192);
            TxtSoyadi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSoyadi.Location = new Point(169, 50);
            TxtSoyadi.Name = "TxtSoyadi";
            TxtSoyadi.Size = new Size(238, 30);
            TxtSoyadi.TabIndex = 32;
            // 
            // TxtAdi
            // 
            TxtAdi.BackColor = Color.FromArgb(255, 255, 192);
            TxtAdi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TxtAdi.Location = new Point(169, 14);
            TxtAdi.Name = "TxtAdi";
            TxtAdi.Size = new Size(238, 30);
            TxtAdi.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(475, 121);
            label9.Name = "label9";
            label9.Size = new Size(111, 28);
            label9.TabIndex = 29;
            label9.Text = "Giriş Tarihi:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(473, 166);
            label10.Name = "label10";
            label10.Size = new Size(113, 28);
            label10.TabIndex = 30;
            label10.Text = "Çıkış Tarihi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 10);
            label1.Name = "label1";
            label1.Size = new Size(47, 28);
            label1.TabIndex = 21;
            label1.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 48);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 22;
            label2.Text = "Soyadı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(521, 67);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 28;
            label8.Text = "Ücret:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(75, 90);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 23;
            label3.Text = "Cinsiyet:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(440, 17);
            label7.Name = "label7";
            label7.Size = new Size(146, 28);
            label7.TabIndex = 27;
            label7.Text = "Oda Numarası:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(79, 134);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 24;
            label4.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 218);
            label6.Name = "label6";
            label6.Size = new Size(143, 28);
            label6.TabIndex = 26;
            label6.Text = "T.C. Kimlik No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(108, 175);
            label5.Name = "label5";
            label5.Size = new Size(55, 28);
            label5.TabIndex = 25;
            label5.Text = "Mail:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(693, 325);
            label11.Name = "label11";
            label11.Size = new Size(0, 28);
            label11.TabIndex = 41;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(853, 327);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 30);
            textBox1.TabIndex = 43;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(800, 327);
            label12.Name = "label12";
            label12.Size = new Size(47, 28);
            label12.TabIndex = 42;
            label12.Text = "Adı:";
            label12.Click += label12_Click;
            // 
            // BtnTemizle
            // 
            BtnTemizle.BackColor = Color.Lime;
            BtnTemizle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTemizle.Location = new Point(930, 189);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(161, 57);
            BtnTemizle.TabIndex = 44;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = false;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // FrmMusteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1092, 578);
            Controls.Add(BtnTemizle);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(DtpcikisTarihi);
            Controls.Add(DtpGirisTarihi);
            Controls.Add(MskTxtTelefon);
            Controls.Add(TxtUcret);
            Controls.Add(TxtOdaNo);
            Controls.Add(TxtKimlikNo);
            Controls.Add(TxtMail);
            Controls.Add(comboBox1);
            Controls.Add(TxtSoyadi);
            Controls.Add(TxtAdi);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BtnAra);
            Controls.Add(BtnSil);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnVerileriGoster);
            Controls.Add(listView1);
            Name = "FrmMusteriler";
            Text = " Müşteri Bilgileri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button BtnVerileriGoster;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnAra;
        private DateTimePicker DtpcikisTarihi;
        private DateTimePicker DtpGirisTarihi;
        private MaskedTextBox MskTxtTelefon;
        private TextBox TxtUcret;
        private TextBox TxtOdaNo;
        private TextBox TxtKimlikNo;
        private TextBox TxtMail;
        private ComboBox comboBox1;
        private TextBox TxtSoyadi;
        private TextBox TxtAdi;
        private Label label9;
        private Label label10;
        private Label label1;
        private Label label2;
        private Label label8;
        private Label label3;
        private Label label7;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label11;
        private TextBox textBox1;
        private Label label12;
        private Button BtnTemizle;
    }
}