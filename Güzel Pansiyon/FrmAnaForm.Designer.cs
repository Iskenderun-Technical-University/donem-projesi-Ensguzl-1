namespace GÜZEL_OTOMASYON
{
    partial class FrmAnaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            button10 = new Button();
            button12 = new Button();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(40, 85);
            button1.Name = "button1";
            button1.Size = new Size(208, 104);
            button1.TabIndex = 0;
            button1.Text = "Admin Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(302, 85);
            button2.Name = "button2";
            button2.Size = new Size(208, 104);
            button2.TabIndex = 1;
            button2.Text = "Yeni Müşteri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Fuchsia;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(562, 85);
            button3.Name = "button3";
            button3.Size = new Size(208, 104);
            button3.TabIndex = 2;
            button3.Text = "Odalar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(40, 249);
            button4.Name = "button4";
            button4.Size = new Size(208, 104);
            button4.TabIndex = 3;
            button4.Text = "Müşteriler";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(302, 249);
            button5.Name = "button5";
            button5.Size = new Size(208, 104);
            button5.TabIndex = 4;
            button5.Text = "Gelir-Gider Formu";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 192, 192);
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(562, 249);
            button6.Name = "button6";
            button6.Size = new Size(208, 104);
            button6.TabIndex = 5;
            button6.Text = "Stoklar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Blue;
            button9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(49, 408);
            button9.Name = "button9";
            button9.Size = new Size(208, 104);
            button9.TabIndex = 8;
            button9.Text = "Hakkımızda";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Gray;
            button10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(302, 408);
            button10.Name = "button10";
            button10.Size = new Size(208, 104);
            button10.TabIndex = 9;
            button10.Text = "Şifre Güncelle";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Red;
            button12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(562, 408);
            button12.Name = "button12";
            button12.Size = new Size(208, 104);
            button12.TabIndex = 11;
            button12.Text = "Çıkış";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(835, 415);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 12;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(908, 459);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(799, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FrmAnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1151, 604);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button12);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAnaForm";
            Text = "Ana Sayfa";
            Load += FrmAnaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button9;
        private Button button10;
        private Button button12;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
    }
}