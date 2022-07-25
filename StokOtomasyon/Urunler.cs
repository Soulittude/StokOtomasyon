using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Entity;
using Business;

namespace StokOtomasyon
{
    public partial class FormUrunler : Form
    {
        UrunBL UrunIslemleri = new UrunBL();

        public FormUrunler(string isim)
        {
            InitializeComponent();
            label_no.Text = isim;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int Sonuc = UrunIslemleri.UrunEkle(tb_urunAdi.Text, Convert.ToInt32(tb_urunStok.Text));
            UrunleriGetir();
        }

        private void FormUrunler_Load(object sender, EventArgs e)
        {
            dgv_urunler.ReadOnly = true;
            dgv_urunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UrunleriGetir();
        }

        void UrunleriGetir()
        {
            List<Urun> Urunler = UrunIslemleri.UrunleriGetir();
            dgv_urunler.DataSource = Urunler;
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(tb_urunNo.Text);
            int Sonuc = UrunIslemleri.UrunSil(no);
            UrunleriGetir();
        }

        private void dgv_urunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow seciliSatir = this.dgv_urunler.Rows[e.RowIndex];

            string urunNo = seciliSatir.Cells[0].Value + string.Empty;
            string urunAdi = seciliSatir.Cells[1].Value + string.Empty;
            string urunStok = seciliSatir.Cells[2].Value + string.Empty;

            tb_urunNo.Text = urunNo;
            tb_urunAdi.Text = urunAdi;
            tb_urunStok.Text = urunStok;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int Sonuc = UrunIslemleri.UrunGuncelle(Convert.ToInt32(tb_urunNo.Text), tb_urunAdi.Text, Convert.ToInt32(tb_urunStok.Text));
            UrunleriGetir();
        }
    }
}
