
namespace StokKontrolüü
{
    partial class frmÜrünListeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
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
            this.txtÜrünAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(487, 74);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 37);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ürün Satış Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Ürün Alış Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ürün Miktarı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Ürün Adı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Ürün Markası";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(295, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Ürün Kategorisi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(290, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Ürün Barkod No";
            // 
            // ÜrünSatışFiyatıtxt
            // 
            this.ÜrünSatışFiyatıtxt.Location = new System.Drawing.Point(381, 174);
            this.ÜrünSatışFiyatıtxt.Name = "ÜrünSatışFiyatıtxt";
            this.ÜrünSatışFiyatıtxt.ReadOnly = true;
            this.ÜrünSatışFiyatıtxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünSatışFiyatıtxt.TabIndex = 31;
            // 
            // ÜrünKategorisitxt
            // 
            this.ÜrünKategorisitxt.Location = new System.Drawing.Point(381, 44);
            this.ÜrünKategorisitxt.Name = "ÜrünKategorisitxt";
            this.ÜrünKategorisitxt.ReadOnly = true;
            this.ÜrünKategorisitxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünKategorisitxt.TabIndex = 26;
            // 
            // ÜrünAlışFiyatıtxt
            // 
            this.ÜrünAlışFiyatıtxt.Location = new System.Drawing.Point(381, 148);
            this.ÜrünAlışFiyatıtxt.Name = "ÜrünAlışFiyatıtxt";
            this.ÜrünAlışFiyatıtxt.ReadOnly = true;
            this.ÜrünAlışFiyatıtxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünAlışFiyatıtxt.TabIndex = 30;
            // 
            // ÜrünBarkodNotxt
            // 
            this.ÜrünBarkodNotxt.Location = new System.Drawing.Point(381, 18);
            this.ÜrünBarkodNotxt.Name = "ÜrünBarkodNotxt";
            this.ÜrünBarkodNotxt.ReadOnly = true;
            this.ÜrünBarkodNotxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünBarkodNotxt.TabIndex = 24;
            // 
            // ÜrünMiktarıtxt
            // 
            this.ÜrünMiktarıtxt.Location = new System.Drawing.Point(381, 122);
            this.ÜrünMiktarıtxt.Name = "ÜrünMiktarıtxt";
            this.ÜrünMiktarıtxt.ReadOnly = true;
            this.ÜrünMiktarıtxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünMiktarıtxt.TabIndex = 29;
            // 
            // ÜrünMarkasıtxt
            // 
            this.ÜrünMarkasıtxt.Location = new System.Drawing.Point(381, 70);
            this.ÜrünMarkasıtxt.Name = "ÜrünMarkasıtxt";
            this.ÜrünMarkasıtxt.ReadOnly = true;
            this.ÜrünMarkasıtxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünMarkasıtxt.TabIndex = 27;
            // 
            // ÜrünAdıtxt
            // 
            this.ÜrünAdıtxt.Location = new System.Drawing.Point(381, 96);
            this.ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            this.ÜrünAdıtxt.ReadOnly = true;
            this.ÜrünAdıtxt.Size = new System.Drawing.Size(100, 20);
            this.ÜrünAdıtxt.TabIndex = 28;
            // 
            // txtÜrünAra
            // 
            this.txtÜrünAra.Location = new System.Drawing.Point(129, 94);
            this.txtÜrünAra.Name = "txtÜrünAra";
            this.txtÜrünAra.Size = new System.Drawing.Size(100, 20);
            this.txtÜrünAra.TabIndex = 39;
            this.txtÜrünAra.TextChanged += new System.EventHandler(this.txtÜrünAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ürün Arayın";
            // 
            // frmÜrünListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(734, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtÜrünAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ÜrünSatışFiyatıtxt);
            this.Controls.Add(this.ÜrünKategorisitxt);
            this.Controls.Add(this.ÜrünAlışFiyatıtxt);
            this.Controls.Add(this.ÜrünBarkodNotxt);
            this.Controls.Add(this.ÜrünMiktarıtxt);
            this.Controls.Add(this.ÜrünMarkasıtxt);
            this.Controls.Add(this.ÜrünAdıtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmÜrünListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Bölümü";
            this.Load += new System.EventHandler(this.frmÜrünListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ÜrünSatışFiyatıtxt;
        private System.Windows.Forms.TextBox ÜrünKategorisitxt;
        private System.Windows.Forms.TextBox ÜrünAlışFiyatıtxt;
        private System.Windows.Forms.TextBox ÜrünBarkodNotxt;
        private System.Windows.Forms.TextBox ÜrünMiktarıtxt;
        private System.Windows.Forms.TextBox ÜrünMarkasıtxt;
        private System.Windows.Forms.TextBox ÜrünAdıtxt;
        private System.Windows.Forms.TextBox txtÜrünAra;
        private System.Windows.Forms.Label label2;
    }
}