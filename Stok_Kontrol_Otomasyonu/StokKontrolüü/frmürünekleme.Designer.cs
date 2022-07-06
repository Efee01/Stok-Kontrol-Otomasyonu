
namespace StokKontrolüü
{
    partial class frmürünekleme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboÜrünMarkası = new System.Windows.Forms.ComboBox();
            this.comboÜrünKategorisi = new System.Windows.Forms.ComboBox();
            this.txtÜrünSatışFiyatı = new System.Windows.Forms.TextBox();
            this.txtÜrünAlışFiyatı = new System.Windows.Forms.TextBox();
            this.txtÜrünMiktarı = new System.Windows.Forms.TextBox();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.txtÜrünBarkodNo = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMiktari = new System.Windows.Forms.Label();
            this.btnMevcutEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ÜrünSatışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.ÜrünKategorisitxt = new System.Windows.Forms.TextBox();
            this.ÜrünAlışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.ÜrünBarkodNotxt = new System.Windows.Forms.TextBox();
            this.ÜrünMiktarıtxt = new System.Windows.Forms.TextBox();
            this.ÜrünMarkasıtxt = new System.Windows.Forms.TextBox();
            this.ÜrünAdıtxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.btnYeniEkle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboÜrünMarkası);
            this.groupBox1.Controls.Add(this.comboÜrünKategorisi);
            this.groupBox1.Controls.Add(this.txtÜrünSatışFiyatı);
            this.groupBox1.Controls.Add(this.txtÜrünAlışFiyatı);
            this.groupBox1.Controls.Add(this.txtÜrünMiktarı);
            this.groupBox1.Controls.Add(this.txtÜrünAdı);
            this.groupBox1.Controls.Add(this.txtÜrünBarkodNo);
            this.groupBox1.Location = new System.Drawing.Point(21, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün";
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Location = new System.Drawing.Point(226, 76);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(84, 37);
            this.btnYeniEkle.TabIndex = 2;
            this.btnYeniEkle.Text = "Ekle";
            this.btnYeniEkle.UseVisualStyleBackColor = true;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ürün Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ürün Alış Fiyatı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Ürün Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ürün Markası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ürün Kategorisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ürün Barkod No";
            // 
            // comboÜrünMarkası
            // 
            this.comboÜrünMarkası.FormattingEnabled = true;
            this.comboÜrünMarkası.Location = new System.Drawing.Point(120, 71);
            this.comboÜrünMarkası.Name = "comboÜrünMarkası";
            this.comboÜrünMarkası.Size = new System.Drawing.Size(100, 21);
            this.comboÜrünMarkası.TabIndex = 10;
            // 
            // comboÜrünKategorisi
            // 
            this.comboÜrünKategorisi.FormattingEnabled = true;
            this.comboÜrünKategorisi.Location = new System.Drawing.Point(120, 44);
            this.comboÜrünKategorisi.Name = "comboÜrünKategorisi";
            this.comboÜrünKategorisi.Size = new System.Drawing.Size(100, 21);
            this.comboÜrünKategorisi.TabIndex = 9;
            this.comboÜrünKategorisi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtÜrünSatışFiyatı
            // 
            this.txtÜrünSatışFiyatı.Location = new System.Drawing.Point(120, 176);
            this.txtÜrünSatışFiyatı.Name = "txtÜrünSatışFiyatı";
            this.txtÜrünSatışFiyatı.Size = new System.Drawing.Size(100, 20);
            this.txtÜrünSatışFiyatı.TabIndex = 4;
            // 
            // txtÜrünAlışFiyatı
            // 
            this.txtÜrünAlışFiyatı.Location = new System.Drawing.Point(120, 150);
            this.txtÜrünAlışFiyatı.Name = "txtÜrünAlışFiyatı";
            this.txtÜrünAlışFiyatı.Size = new System.Drawing.Size(100, 20);
            this.txtÜrünAlışFiyatı.TabIndex = 3;
            // 
            // txtÜrünMiktarı
            // 
            this.txtÜrünMiktarı.Location = new System.Drawing.Point(120, 124);
            this.txtÜrünMiktarı.Name = "txtÜrünMiktarı";
            this.txtÜrünMiktarı.Size = new System.Drawing.Size(100, 20);
            this.txtÜrünMiktarı.TabIndex = 2;
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(120, 98);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(100, 20);
            this.txtÜrünAdı.TabIndex = 1;
            // 
            // txtÜrünBarkodNo
            // 
            this.txtÜrünBarkodNo.Location = new System.Drawing.Point(120, 18);
            this.txtÜrünBarkodNo.Name = "txtÜrünBarkodNo";
            this.txtÜrünBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txtÜrünBarkodNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Plum;
            this.groupBox2.Controls.Add(this.lblMiktari);
            this.groupBox2.Controls.Add(this.btnMevcutEkle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.ÜrünSatışFiyatıtxt);
            this.groupBox2.Controls.Add(this.ÜrünKategorisitxt);
            this.groupBox2.Controls.Add(this.ÜrünAlışFiyatıtxt);
            this.groupBox2.Controls.Add(this.ÜrünBarkodNotxt);
            this.groupBox2.Controls.Add(this.ÜrünMiktarıtxt);
            this.groupBox2.Controls.Add(this.ÜrünMarkasıtxt);
            this.groupBox2.Controls.Add(this.ÜrünAdıtxt);
            this.groupBox2.Location = new System.Drawing.Point(372, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mevcut Ürün";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.Location = new System.Drawing.Point(71, 203);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(0, 13);
            this.lblMiktari.TabIndex = 17;
            // 
            // btnMevcutEkle
            // 
            this.btnMevcutEkle.Location = new System.Drawing.Point(225, 76);
            this.btnMevcutEkle.Name = "btnMevcutEkle";
            this.btnMevcutEkle.Size = new System.Drawing.Size(84, 37);
            this.btnMevcutEkle.TabIndex = 3;
            this.btnMevcutEkle.Text = "Ekle";
            this.btnMevcutEkle.UseVisualStyleBackColor = true;
            this.btnMevcutEkle.Click += new System.EventHandler(this.btnMevcutEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ürün Satış Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ürün Alış Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ürün Miktarı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ürün Adı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ürün Markası";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Ürün Kategorisi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Ürün Barkod No";
            // 
            // ÜrünSatışFiyatıtxt
            // 
            this.ÜrünSatışFiyatıtxt.Location = new System.Drawing.Point(119, 176);
            this.ÜrünSatışFiyatıtxt.Name = "ÜrünSatışFiyatıtxt";
            this.ÜrünSatışFiyatıtxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünSatışFiyatıtxt.TabIndex = 8;
            // 
            // ÜrünKategorisitxt
            // 
            this.ÜrünKategorisitxt.Location = new System.Drawing.Point(119, 46);
            this.ÜrünKategorisitxt.Name = "ÜrünKategorisitxt";
            this.ÜrünKategorisitxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünKategorisitxt.TabIndex = 3;
            // 
            // ÜrünAlışFiyatıtxt
            // 
            this.ÜrünAlışFiyatıtxt.Location = new System.Drawing.Point(119, 150);
            this.ÜrünAlışFiyatıtxt.Name = "ÜrünAlışFiyatıtxt";
            this.ÜrünAlışFiyatıtxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünAlışFiyatıtxt.TabIndex = 7;
            // 
            // ÜrünBarkodNotxt
            // 
            this.ÜrünBarkodNotxt.Location = new System.Drawing.Point(119, 20);
            this.ÜrünBarkodNotxt.Name = "ÜrünBarkodNotxt";
            this.ÜrünBarkodNotxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünBarkodNotxt.TabIndex = 2;
            this.ÜrünBarkodNotxt.TextChanged += new System.EventHandler(this.ÜrünBarkodNotxt_TextChanged);
            // 
            // ÜrünMiktarıtxt
            // 
            this.ÜrünMiktarıtxt.Location = new System.Drawing.Point(119, 124);
            this.ÜrünMiktarıtxt.Name = "ÜrünMiktarıtxt";
            this.ÜrünMiktarıtxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünMiktarıtxt.TabIndex = 6;
            this.ÜrünMiktarıtxt.TextChanged += new System.EventHandler(this.ÜrünMiktarıtxt_TextChanged);
            // 
            // ÜrünMarkasıtxt
            // 
            this.ÜrünMarkasıtxt.Location = new System.Drawing.Point(119, 72);
            this.ÜrünMarkasıtxt.Name = "ÜrünMarkasıtxt";
            this.ÜrünMarkasıtxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünMarkasıtxt.TabIndex = 4;
            // 
            // ÜrünAdıtxt
            // 
            this.ÜrünAdıtxt.Location = new System.Drawing.Point(119, 98);
            this.ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            this.ÜrünAdıtxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünAdıtxt.TabIndex = 5;
            // 
            // frmürünekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(752, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmürünekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekleme Bölümü";
            this.Load += new System.EventHandler(this.frmürünekleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboÜrünMarkası;
        private System.Windows.Forms.ComboBox comboÜrünKategorisi;
        private System.Windows.Forms.TextBox txtÜrünSatışFiyatı;
        private System.Windows.Forms.TextBox txtÜrünAlışFiyatı;
        private System.Windows.Forms.TextBox txtÜrünMiktarı;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.TextBox txtÜrünBarkodNo;
        private System.Windows.Forms.TextBox ÜrünSatışFiyatıtxt;
        private System.Windows.Forms.TextBox ÜrünKategorisitxt;
        private System.Windows.Forms.TextBox ÜrünAlışFiyatıtxt;
        private System.Windows.Forms.TextBox ÜrünBarkodNotxt;
        private System.Windows.Forms.TextBox ÜrünMiktarıtxt;
        private System.Windows.Forms.TextBox ÜrünMarkasıtxt;
        private System.Windows.Forms.TextBox ÜrünAdıtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnYeniEkle;
        private System.Windows.Forms.Button btnMevcutEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMiktari;
    }
}