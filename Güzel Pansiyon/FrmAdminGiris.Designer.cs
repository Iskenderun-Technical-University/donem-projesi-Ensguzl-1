namespace GÜZEL_OTOMASYON
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            label2 = new Label();
            TxtKullaniciAdi = new TextBox();
            TxtSifre = new TextBox();
            BtnGiris = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(82, 193);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(158, 241);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            label2.Click += label2_Click;
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.BackColor = Color.FromArgb(255, 255, 192);
            TxtKullaniciAdi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtKullaniciAdi.Location = new Point(225, 197);
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(216, 34);
            TxtKullaniciAdi.TabIndex = 2;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = Color.FromArgb(255, 255, 192);
            TxtSifre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSifre.Location = new Point(225, 241);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(216, 34);
            TxtSifre.TabIndex = 3;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // BtnGiris
            // 
            BtnGiris.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGiris.Location = new Point(225, 300);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(114, 43);
            BtnGiris.TabIndex = 4;
            BtnGiris.Text = "Giriş";
            BtnGiris.UseVisualStyleBackColor = true;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(522, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(466, 35);
            label3.TabIndex = 6;
            label3.Text = "Güzel Pansiyon Hoşgeldiniz";
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(983, 464);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(BtnGiris);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdminGiris";
            Text = "Admin Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private Label label2;
        private TextBox TxtKullaniciAdi;
        private TextBox TxtSifre;
        private Button BtnGiris;
        private PictureBox pictureBox1;
        private Label label3;
    }
}