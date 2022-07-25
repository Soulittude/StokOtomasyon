
namespace StokOtomasyon
{
    partial class FormPersoneller
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
            this.label_personelAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_personelYetki = new System.Windows.Forms.TextBox();
            this.tb_personelAdi = new System.Windows.Forms.TextBox();
            this.tb_personelSifre = new System.Windows.Forms.TextBox();
            this.dgv_personeller = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_personelNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personeller)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(572, 142);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(572, 171);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(572, 200);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 3;
            this.btn_guncelle.Text = "Guncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(572, 229);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_yenile.TabIndex = 4;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // label_personelAdi
            // 
            this.label_personelAdi.AutoSize = true;
            this.label_personelAdi.Location = new System.Drawing.Point(485, 58);
            this.label_personelAdi.Name = "label_personelAdi";
            this.label_personelAdi.Size = new System.Drawing.Size(72, 13);
            this.label_personelAdi.TabIndex = 5;
            this.label_personelAdi.Text = "Personel Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Personel Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Personel Yetki :";
            // 
            // tb_personelYetki
            // 
            this.tb_personelYetki.Location = new System.Drawing.Point(572, 107);
            this.tb_personelYetki.Name = "tb_personelYetki";
            this.tb_personelYetki.Size = new System.Drawing.Size(100, 20);
            this.tb_personelYetki.TabIndex = 8;
            // 
            // tb_personelAdi
            // 
            this.tb_personelAdi.Location = new System.Drawing.Point(572, 55);
            this.tb_personelAdi.Name = "tb_personelAdi";
            this.tb_personelAdi.Size = new System.Drawing.Size(100, 20);
            this.tb_personelAdi.TabIndex = 9;
            // 
            // tb_personelSifre
            // 
            this.tb_personelSifre.Location = new System.Drawing.Point(572, 81);
            this.tb_personelSifre.Name = "tb_personelSifre";
            this.tb_personelSifre.Size = new System.Drawing.Size(100, 20);
            this.tb_personelSifre.TabIndex = 10;
            // 
            // dgv_personeller
            // 
            this.dgv_personeller.AllowUserToOrderColumns = true;
            this.dgv_personeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_personeller.Location = new System.Drawing.Point(12, 10);
            this.dgv_personeller.MultiSelect = false;
            this.dgv_personeller.Name = "dgv_personeller";
            this.dgv_personeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_personeller.Size = new System.Drawing.Size(464, 256);
            this.dgv_personeller.TabIndex = 11;
            this.dgv_personeller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_personeller_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Personel No :";
            // 
            // tb_personelNo
            // 
            this.tb_personelNo.Location = new System.Drawing.Point(572, 29);
            this.tb_personelNo.Name = "tb_personelNo";
            this.tb_personelNo.ReadOnly = true;
            this.tb_personelNo.Size = new System.Drawing.Size(100, 20);
            this.tb_personelNo.TabIndex = 12;
            // 
            // FormPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_personelNo);
            this.Controls.Add(this.dgv_personeller);
            this.Controls.Add(this.tb_personelSifre);
            this.Controls.Add(this.tb_personelAdi);
            this.Controls.Add(this.tb_personelYetki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_personelAdi);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormPersoneller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.FormPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personeller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Label label_personelAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_personelYetki;
        private System.Windows.Forms.TextBox tb_personelAdi;
        private System.Windows.Forms.TextBox tb_personelSifre;
        private System.Windows.Forms.DataGridView dgv_personeller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_personelNo;
    }
}