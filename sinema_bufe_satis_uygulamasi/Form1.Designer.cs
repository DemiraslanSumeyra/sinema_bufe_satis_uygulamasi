namespace sinema_bufe_satis_uygulamasi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_misir = new System.Windows.Forms.TextBox();
            this.txt_su = new System.Windows.Forms.TextBox();
            this.txt_cay = new System.Windows.Forms.TextBox();
            this.txt_bilet = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_misir_fiyat = new System.Windows.Forms.Label();
            this.lbl_su_fiyat = new System.Windows.Forms.Label();
            this.lbl_cay_fiyat = new System.Windows.Forms.Label();
            this.lbl_bilet_fiyat = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.btn_Hesapla = new System.Windows.Forms.Button();
            this.lbl_kasa_toplam = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.txt_bilet);
            this.groupBox1.Controls.Add(this.txt_cay);
            this.groupBox1.Controls.Add(this.txt_su);
            this.groupBox1.Controls.Add(this.txt_misir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(28, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Miktarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mısır:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Su:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Çay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bilet:";
            // 
            // txt_misir
            // 
            this.txt_misir.Location = new System.Drawing.Point(80, 67);
            this.txt_misir.Name = "txt_misir";
            this.txt_misir.Size = new System.Drawing.Size(100, 26);
            this.txt_misir.TabIndex = 1;
            // 
            // txt_su
            // 
            this.txt_su.Location = new System.Drawing.Point(80, 99);
            this.txt_su.Name = "txt_su";
            this.txt_su.Size = new System.Drawing.Size(100, 26);
            this.txt_su.TabIndex = 1;
            // 
            // txt_cay
            // 
            this.txt_cay.Location = new System.Drawing.Point(80, 134);
            this.txt_cay.Name = "txt_cay";
            this.txt_cay.Size = new System.Drawing.Size(100, 26);
            this.txt_cay.TabIndex = 1;
            // 
            // txt_bilet
            // 
            this.txt_bilet.Location = new System.Drawing.Point(79, 171);
            this.txt_bilet.Name = "txt_bilet";
            this.txt_bilet.Size = new System.Drawing.Size(100, 26);
            this.txt_bilet.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl_bilet_fiyat);
            this.groupBox2.Controls.Add(this.lbl_cay_fiyat);
            this.groupBox2.Controls.Add(this.lbl_su_fiyat);
            this.groupBox2.Controls.Add(this.lbl_misir_fiyat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(283, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Tablosu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mısır:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Su:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(37, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Çay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(30, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bilet:";
            // 
            // lbl_misir_fiyat
            // 
            this.lbl_misir_fiyat.AutoSize = true;
            this.lbl_misir_fiyat.Location = new System.Drawing.Point(85, 70);
            this.lbl_misir_fiyat.Name = "lbl_misir_fiyat";
            this.lbl_misir_fiyat.Size = new System.Drawing.Size(43, 22);
            this.lbl_misir_fiyat.TabIndex = 0;
            this.lbl_misir_fiyat.Text = "4 TL";
            // 
            // lbl_su_fiyat
            // 
            this.lbl_su_fiyat.AutoSize = true;
            this.lbl_su_fiyat.Location = new System.Drawing.Point(85, 102);
            this.lbl_su_fiyat.Name = "lbl_su_fiyat";
            this.lbl_su_fiyat.Size = new System.Drawing.Size(43, 22);
            this.lbl_su_fiyat.TabIndex = 0;
            this.lbl_su_fiyat.Text = "1 TL";
            // 
            // lbl_cay_fiyat
            // 
            this.lbl_cay_fiyat.AutoSize = true;
            this.lbl_cay_fiyat.Location = new System.Drawing.Point(85, 137);
            this.lbl_cay_fiyat.Name = "lbl_cay_fiyat";
            this.lbl_cay_fiyat.Size = new System.Drawing.Size(43, 22);
            this.lbl_cay_fiyat.TabIndex = 0;
            this.lbl_cay_fiyat.Text = "2 TL";
            // 
            // lbl_bilet_fiyat
            // 
            this.lbl_bilet_fiyat.AutoSize = true;
            this.lbl_bilet_fiyat.Location = new System.Drawing.Point(85, 171);
            this.lbl_bilet_fiyat.Name = "lbl_bilet_fiyat";
            this.lbl_bilet_fiyat.Size = new System.Drawing.Size(43, 22);
            this.lbl_bilet_fiyat.TabIndex = 0;
            this.lbl_bilet_fiyat.Text = "8 TL";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.btn_Temizle);
            this.groupBox3.Controls.Add(this.btn_Hesapla);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbl_kasa_toplam);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lbl_toplam);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(512, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 262);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(36, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Toplam: ";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Location = new System.Drawing.Point(117, 71);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(52, 22);
            this.lbl_toplam.TabIndex = 0;
            this.lbl_toplam.Text = "00 TL";
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.Location = new System.Drawing.Point(41, 102);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(118, 35);
            this.btn_Hesapla.TabIndex = 1;
            this.btn_Hesapla.Text = "Hesapla";
            this.btn_Hesapla.UseVisualStyleBackColor = true;
            this.btn_Hesapla.Click += new System.EventHandler(this.btn_Hesapla_Click);
            // 
            // lbl_kasa_toplam
            // 
            this.lbl_kasa_toplam.AutoSize = true;
            this.lbl_kasa_toplam.Location = new System.Drawing.Point(107, 192);
            this.lbl_kasa_toplam.Name = "lbl_kasa_toplam";
            this.lbl_kasa_toplam.Size = new System.Drawing.Size(52, 22);
            this.lbl_kasa_toplam.TabIndex = 0;
            this.lbl_kasa_toplam.Text = "00 TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(26, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kasa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(444, 47);
            this.label9.TabIndex = 3;
            this.label9.Text = "Sinema  ~ Büfe Satış Paneli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(40, 143);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(118, 34);
            this.btn_Temizle.TabIndex = 2;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Büfe Sinema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_bilet;
        private System.Windows.Forms.TextBox txt_cay;
        private System.Windows.Forms.TextBox txt_su;
        private System.Windows.Forms.TextBox txt_misir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_bilet_fiyat;
        private System.Windows.Forms.Label lbl_cay_fiyat;
        private System.Windows.Forms.Label lbl_su_fiyat;
        private System.Windows.Forms.Label lbl_misir_fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Hesapla;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_kasa_toplam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Temizle;
    }
}

