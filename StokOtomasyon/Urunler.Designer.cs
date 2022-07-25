
namespace StokOtomasyon
{
    partial class FormUrunler
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.label_no = new System.Windows.Forms.Label();
            this.label_urunAdi = new System.Windows.Forms.Label();
            this.label_urunStok = new System.Windows.Forms.Label();
            this.tb_urunAdi = new System.Windows.Forms.TextBox();
            this.tb_urunStok = new System.Windows.Forms.TextBox();
            this.dgv_urunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_urunNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(368, 111);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(475, 111);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(368, 140);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 3;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(475, 140);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_yenile.TabIndex = 4;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Location = new System.Drawing.Point(435, 13);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(19, 13);
            this.label_no.TabIndex = 5;
            this.label_no.Text = "no";
            // 
            // label_urunAdi
            // 
            this.label_urunAdi.AutoSize = true;
            this.label_urunAdi.Location = new System.Drawing.Point(365, 62);
            this.label_urunAdi.Name = "label_urunAdi";
            this.label_urunAdi.Size = new System.Drawing.Size(54, 13);
            this.label_urunAdi.TabIndex = 6;
            this.label_urunAdi.Text = "Ürün Adı :";
            // 
            // label_urunStok
            // 
            this.label_urunStok.AutoSize = true;
            this.label_urunStok.Location = new System.Drawing.Point(365, 88);
            this.label_urunStok.Name = "label_urunStok";
            this.label_urunStok.Size = new System.Drawing.Size(67, 13);
            this.label_urunStok.TabIndex = 7;
            this.label_urunStok.Text = "Ürün Stoğu :";
            // 
            // tb_urunAdi
            // 
            this.tb_urunAdi.Location = new System.Drawing.Point(438, 59);
            this.tb_urunAdi.Name = "tb_urunAdi";
            this.tb_urunAdi.Size = new System.Drawing.Size(100, 20);
            this.tb_urunAdi.TabIndex = 8;
            // 
            // tb_urunStok
            // 
            this.tb_urunStok.Location = new System.Drawing.Point(438, 85);
            this.tb_urunStok.Name = "tb_urunStok";
            this.tb_urunStok.Size = new System.Drawing.Size(100, 20);
            this.tb_urunStok.TabIndex = 9;
            // 
            // dgv_urunler
            // 
            this.dgv_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunler.Location = new System.Drawing.Point(12, 13);
            this.dgv_urunler.MultiSelect = false;
            this.dgv_urunler.Name = "dgv_urunler";
            this.dgv_urunler.ReadOnly = true;
            this.dgv_urunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_urunler.Size = new System.Drawing.Size(347, 150);
            this.dgv_urunler.TabIndex = 10;
            this.dgv_urunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_urunler_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Personel No :";
            // 
            // tb_urunNo
            // 
            this.tb_urunNo.Location = new System.Drawing.Point(438, 33);
            this.tb_urunNo.Name = "tb_urunNo";
            this.tb_urunNo.ReadOnly = true;
            this.tb_urunNo.Size = new System.Drawing.Size(100, 20);
            this.tb_urunNo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ürün No :";
            // 
            // FormUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 177);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_urunNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_urunler);
            this.Controls.Add(this.tb_urunStok);
            this.Controls.Add(this.tb_urunAdi);
            this.Controls.Add(this.label_urunStok);
            this.Controls.Add(this.label_urunAdi);
            this.Controls.Add(this.label_no);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormUrunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.FormUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Label label_no;
        private System.Windows.Forms.Label label_urunAdi;
        private System.Windows.Forms.Label label_urunStok;
        private System.Windows.Forms.TextBox tb_urunAdi;
        private System.Windows.Forms.TextBox tb_urunStok;
        private System.Windows.Forms.DataGridView dgv_urunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_urunNo;
        private System.Windows.Forms.Label label2;
    }
}