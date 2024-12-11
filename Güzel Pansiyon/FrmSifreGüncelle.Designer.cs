namespace GÜZEL_OTOMASYON
{
    partial class FrmSifreGüncelle
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
            BtnGiris = new Button();
            TxtSifre = new TextBox();
            TxtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnGiris
            // 
            BtnGiris.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGiris.Location = new Point(249, 199);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(114, 43);
            BtnGiris.TabIndex = 9;
            BtnGiris.Text = "Güncelle";
            BtnGiris.UseVisualStyleBackColor = true;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = Color.FromArgb(255, 255, 192);
            TxtSifre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSifre.Location = new Point(249, 140);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(216, 34);
            TxtSifre.TabIndex = 8;
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.BackColor = Color.FromArgb(255, 255, 192);
            TxtKullaniciAdi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtKullaniciAdi.Location = new Point(249, 96);
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(216, 34);
            TxtKullaniciAdi.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(182, 140);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 6;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 92);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı:";
            // 
            // FrmSifreGüncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(672, 322);
            Controls.Add(BtnGiris);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSifreGüncelle";
            Text = "FrmSifreGüncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGiris;
        private TextBox TxtSifre;
        private TextBox TxtKullaniciAdi;
        private Label label2;
        private Label label1;
    }
}