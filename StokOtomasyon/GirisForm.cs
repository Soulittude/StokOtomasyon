using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Business;

namespace StokOtomasyon
{
    public partial class GirisForm : Form
    {
        PersonelBL personel = new PersonelBL();
        UrunBL urun = new UrunBL();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Here Entry point run landing form of your application
            Application.Run(new GirisForm());
        }

        public GirisForm()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(tb_no.Text);
            string sifre = tb_pw.Text;

            string sonuc = personel.SifreKontrol(no, sifre);

            if(sonuc == "admin")
            {
                MessageBox.Show(sonuc + " yetkisi ile giriş yapılıyor.");

                FormPersoneller fp = new FormPersoneller();
                FormUrunler fu = new FormUrunler(tb_no.Text);

                fp.ShowDialog();
                fu.ShowDialog();
            }
            else if(sonuc == "personel")
            {
                MessageBox.Show(sonuc + " yetkisi ile giriş yapılıyor.");

                FormUrunler fu = new FormUrunler(tb_no.Text);
                fu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Personel numarası veya şifresi yanlış.");
            }
        }
    }
}
