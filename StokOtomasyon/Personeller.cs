using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Business;
using Entity;

namespace StokOtomasyon
{
    public partial class FormPersoneller : Form
    {
        PersonelBL PersonelIslemleri = new PersonelBL();
        public FormPersoneller()
        {
            InitializeComponent();
        }

        private void FormPersoneller_Load(object sender, EventArgs e)
        {
            PersonelleriGetir();
            dgv_personeller.ReadOnly = true;
        }

        void PersonelleriGetir()
        {
            dgv_personeller.DataSource = null;
            List<Personel> Personeller = PersonelIslemleri.PersonelleriGetir();
            dgv_personeller.DataSource = Personeller;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int Sonuc = PersonelIslemleri.PersonelEkle(tb_personelAdi.Text, tb_personelSifre.Text, tb_personelYetki.Text);
            PersonelleriGetir();
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(tb_personelNo.Text);
            int Sonuc = PersonelIslemleri.PersonelSil(no);
            PersonelleriGetir();
        }

        private void dgv_personeller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow seciliSatir = this.dgv_personeller.Rows[e.RowIndex];

            string personelNo = seciliSatir.Cells[0].Value + string.Empty;
            string personelAdi = seciliSatir.Cells[1].Value + string.Empty;
            string personelSifre = seciliSatir.Cells[2].Value + string.Empty;
            string personelYetki = seciliSatir.Cells[3].Value + string.Empty;

            tb_personelNo.Text = personelNo;
            tb_personelAdi.Text = personelAdi;
            tb_personelSifre.Text = personelSifre;
            tb_personelYetki.Text = personelYetki;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int Sonuc = PersonelIslemleri.PersonelGuncelle(Convert.ToInt32(tb_personelNo.Text), tb_personelAdi.Text, tb_personelSifre.Text, tb_personelYetki.Text);
            PersonelleriGetir();
        }
    }
}
