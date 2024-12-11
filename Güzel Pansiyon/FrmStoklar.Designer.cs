namespace GÜZEL_OTOMASYON
{
    partial class FrmStoklar
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
            groupBox1 = new GroupBox();
            BtnKaydet1 = new Button();
            TxtCerezler = new TextBox();
            label1 = new Label();
            Txtİcecekler = new TextBox();
            label2 = new Label();
            TxtGıdalar = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            BtnKaydet2 = new Button();
            Txtİnternet = new TextBox();
            label6 = new Label();
            TxtSu = new TextBox();
            label5 = new Label();
            TxtElektrik = new TextBox();
            label4 = new Label();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(-2, 265);
            listView1.Name = "listView1";
            listView1.Size = new Size(434, 186);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Gıdalar";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İçecekler";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Çerezler";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnKaydet1);
            groupBox1.Controls.Add(TxtCerezler);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Txtİcecekler);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtGıdalar);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(-2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 264);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mutfak";
            // 
            // BtnKaydet1
            // 
            BtnKaydet1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKaydet1.Location = new Point(144, 166);
            BtnKaydet1.Name = "BtnKaydet1";
            BtnKaydet1.Size = new Size(140, 49);
            BtnKaydet1.TabIndex = 22;
            BtnKaydet1.Text = "Kaydet";
            BtnKaydet1.UseVisualStyleBackColor = true;
            BtnKaydet1.Click += BtnKaydet1_Click;
            // 
            // TxtCerezler
            // 
            TxtCerezler.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCerezler.Location = new Point(144, 118);
            TxtCerezler.Name = "TxtCerezler";
            TxtCerezler.Size = new Size(260, 31);
            TxtCerezler.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 16;
            label1.Text = "Gıda Tutarı:";
            // 
            // Txtİcecekler
            // 
            Txtİcecekler.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Txtİcecekler.Location = new Point(144, 70);
            Txtİcecekler.Name = "Txtİcecekler";
            Txtİcecekler.Size = new Size(260, 31);
            Txtİcecekler.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 73);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 17;
            label2.Text = "İçecek Tutarı:";
            // 
            // TxtGıdalar
            // 
            TxtGıdalar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtGıdalar.Location = new Point(144, 21);
            TxtGıdalar.Name = "TxtGıdalar";
            TxtGıdalar.Size = new Size(260, 31);
            TxtGıdalar.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 118);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 18;
            label3.Text = "Çerezler:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnKaydet2);
            groupBox2.Controls.Add(Txtİnternet);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TxtSu);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TxtElektrik);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(477, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 264);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Faturalar";
            // 
            // BtnKaydet2
            // 
            BtnKaydet2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKaydet2.Location = new Point(118, 166);
            BtnKaydet2.Name = "BtnKaydet2";
            BtnKaydet2.Size = new Size(140, 49);
            BtnKaydet2.TabIndex = 23;
            BtnKaydet2.Text = "Kaydet";
            BtnKaydet2.UseVisualStyleBackColor = true;
            BtnKaydet2.Click += BtnKaydet2_Click;
            // 
            // Txtİnternet
            // 
            Txtİnternet.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Txtİnternet.Location = new Point(118, 120);
            Txtİnternet.Name = "Txtİnternet";
            Txtİnternet.Size = new Size(260, 31);
            Txtİnternet.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(34, 23);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 17;
            label6.Text = "Elektrik:";
            // 
            // TxtSu
            // 
            TxtSu.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSu.Location = new Point(118, 72);
            TxtSu.Name = "TxtSu";
            TxtSu.Size = new Size(260, 31);
            TxtSu.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(74, 75);
            label5.Name = "label5";
            label5.Size = new Size(37, 25);
            label5.TabIndex = 18;
            label5.Text = "Su:";
            // 
            // TxtElektrik
            // 
            TxtElektrik.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtElektrik.Location = new Point(118, 23);
            TxtElektrik.Name = "TxtElektrik";
            TxtElektrik.Size = new Size(260, 31);
            TxtElektrik.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 120);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 19;
            label4.Text = "İnternet:";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Location = new Point(477, 265);
            listView2.Name = "listView2";
            listView2.Size = new Size(430, 186);
            listView2.TabIndex = 17;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Elektrik";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Su";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "İnternet";
            // 
            // FrmStoklar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(925, 448);
            Controls.Add(listView2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmStoklar";
            Text = "Mutfak & Faturalar";
            Load += FrmStoklar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox groupBox1;
        private Button BtnKaydet1;
        private TextBox TxtCerezler;
        private Label label1;
        private TextBox Txtİcecekler;
        private Label label2;
        private TextBox TxtGıdalar;
        private Label label3;
        private GroupBox groupBox2;
        private Button BtnKaydet2;
        private TextBox Txtİnternet;
        private Label label6;
        private TextBox TxtSu;
        private Label label5;
        private TextBox TxtElektrik;
        private Label label4;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}