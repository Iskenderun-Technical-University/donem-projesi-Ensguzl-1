namespace GÜZEL_OTOMASYON
{
    partial class FrmGelirGider
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
            label1 = new Label();
            LblKasadakiToplamtutar = new Label();
            label2 = new Label();
            LblPersonelMaas = new Label();
            label4 = new Label();
            LblAlınanUrunToplam1 = new Label();
            label6 = new Label();
            LblFaturalar1 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label9 = new Label();
            LblSonuc = new Label();
            label11 = new Label();
            LblAlınanUrunToplam2 = new Label();
            LblAlınanUrunToplam3 = new Label();
            LblFaturalar2 = new Label();
            LblFaturalar3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 35);
            label1.Name = "label1";
            label1.Size = new Size(220, 28);
            label1.TabIndex = 0;
            label1.Text = "Kasadaki Toplam Tutar:";
            // 
            // LblKasadakiToplamtutar
            // 
            LblKasadakiToplamtutar.AutoSize = true;
            LblKasadakiToplamtutar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblKasadakiToplamtutar.Location = new Point(260, 35);
            LblKasadakiToplamtutar.Name = "LblKasadakiToplamtutar";
            LblKasadakiToplamtutar.Size = new Size(34, 28);
            LblKasadakiToplamtutar.TabIndex = 1;
            LblKasadakiToplamtutar.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(79, 87);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 2;
            label2.Text = "Personel Maaşları:";
            // 
            // LblPersonelMaas
            // 
            LblPersonelMaas.AutoSize = true;
            LblPersonelMaas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblPersonelMaas.Location = new Point(260, 87);
            LblPersonelMaas.Name = "LblPersonelMaas";
            LblPersonelMaas.Size = new Size(34, 28);
            LblPersonelMaas.TabIndex = 3;
            LblPersonelMaas.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(242, 28);
            label4.TabIndex = 4;
            label4.Text = "Alınan Ürünlerin Toplamı:";
            // 
            // LblAlınanUrunToplam1
            // 
            LblAlınanUrunToplam1.AutoSize = true;
            LblAlınanUrunToplam1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblAlınanUrunToplam1.Location = new Point(260, 141);
            LblAlınanUrunToplam1.Name = "LblAlınanUrunToplam1";
            LblAlınanUrunToplam1.Size = new Size(34, 28);
            LblAlınanUrunToplam1.TabIndex = 5;
            LblAlınanUrunToplam1.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(159, 190);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 6;
            label6.Text = "Faturalar:";
            // 
            // LblFaturalar1
            // 
            LblFaturalar1.AutoSize = true;
            LblFaturalar1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFaturalar1.Location = new Point(260, 190);
            LblFaturalar1.Name = "LblFaturalar1";
            LblFaturalar1.Size = new Size(34, 28);
            LblFaturalar1.TabIndex = 7;
            LblFaturalar1.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(497, 35);
            label8.Name = "label8";
            label8.Size = new Size(151, 28);
            label8.TabIndex = 8;
            label8.Text = "Personel Sayısı:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(654, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 30);
            textBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(654, 173);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 10;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(181, 342);
            label9.Name = "label9";
            label9.Size = new Size(73, 28);
            label9.TabIndex = 11;
            label9.Text = "Sonuç:";
            // 
            // LblSonuc
            // 
            LblSonuc.AutoSize = true;
            LblSonuc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblSonuc.Location = new Point(260, 342);
            LblSonuc.Name = "LblSonuc";
            LblSonuc.Size = new Size(34, 28);
            LblSonuc.TabIndex = 12;
            LblSonuc.Text = "00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(9, 282);
            label11.Name = "label11";
            label11.Size = new Size(1036, 28);
            label11.TabIndex = 13;
            label11.Text = "--------------------------------------------------------------------------------------------------------------------------------";
            // 
            // LblAlınanUrunToplam2
            // 
            LblAlınanUrunToplam2.AutoSize = true;
            LblAlınanUrunToplam2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblAlınanUrunToplam2.Location = new Point(316, 141);
            LblAlınanUrunToplam2.Name = "LblAlınanUrunToplam2";
            LblAlınanUrunToplam2.Size = new Size(34, 28);
            LblAlınanUrunToplam2.TabIndex = 14;
            LblAlınanUrunToplam2.Text = "00";
            // 
            // LblAlınanUrunToplam3
            // 
            LblAlınanUrunToplam3.AutoSize = true;
            LblAlınanUrunToplam3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblAlınanUrunToplam3.Location = new Point(373, 141);
            LblAlınanUrunToplam3.Name = "LblAlınanUrunToplam3";
            LblAlınanUrunToplam3.Size = new Size(34, 28);
            LblAlınanUrunToplam3.TabIndex = 15;
            LblAlınanUrunToplam3.Text = "00";
            // 
            // LblFaturalar2
            // 
            LblFaturalar2.AutoSize = true;
            LblFaturalar2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFaturalar2.Location = new Point(316, 190);
            LblFaturalar2.Name = "LblFaturalar2";
            LblFaturalar2.Size = new Size(34, 28);
            LblFaturalar2.TabIndex = 16;
            LblFaturalar2.Text = "00";
            // 
            // LblFaturalar3
            // 
            LblFaturalar3.AutoSize = true;
            LblFaturalar3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFaturalar3.Location = new Point(373, 190);
            LblFaturalar3.Name = "LblFaturalar3";
            LblFaturalar3.Size = new Size(34, 28);
            LblFaturalar3.TabIndex = 17;
            LblFaturalar3.Text = "00";
            // 
            // FrmGelirGider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1057, 571);
            Controls.Add(LblFaturalar3);
            Controls.Add(LblFaturalar2);
            Controls.Add(LblAlınanUrunToplam3);
            Controls.Add(LblAlınanUrunToplam2);
            Controls.Add(label11);
            Controls.Add(LblSonuc);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(LblFaturalar1);
            Controls.Add(label6);
            Controls.Add(LblAlınanUrunToplam1);
            Controls.Add(label4);
            Controls.Add(LblPersonelMaas);
            Controls.Add(label2);
            Controls.Add(LblKasadakiToplamtutar);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGelirGider";
            Text = "Gelir-Gider";
            Load += FrmGelirGider_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblKasadakiToplamtutar;
        private Label label2;
        private Label LblPersonelMaas;
        private Label label4;
        private Label LblAlınanUrunToplam1;
        private Label label6;
        private Label LblFaturalar1;
        private Label label8;
        private TextBox textBox1;
        private Button button1;
        private Label label9;
        private Label LblSonuc;
        private Label label11;
        private Label LblAlınanUrunToplam2;
        private Label LblAlınanUrunToplam3;
        private Label LblFaturalar2;
        private Label LblFaturalar3;
    }
}