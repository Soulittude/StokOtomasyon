using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Data;
using System.Data;
using Entity;
using System.Data.SqlClient;

namespace Business
{
    public class UrunBL
    {
        public int UrunEkle(string urunAdi, int urunStok)
        {
            DAL dl = new DAL();

            dl.InputParametreEkle("@urun_adi", urunAdi);
            dl.InputParametreEkle("@urun_stok", urunStok);
            int sonuc = dl.EkleSilGuncelle("sp_UrunEkle", CommandType.StoredProcedure);
            
            return sonuc;
        }

        public int UrunSil(int urunNo)
        {
            DAL dl = new DAL();

            dl.InputParametreEkle("@urun_no", urunNo);
            int sonuc = dl.EkleSilGuncelle("sp_UrunSil", CommandType.StoredProcedure);

            return sonuc;
        }

        public int UrunGuncelle(int urunNo, string urunAdi, int urunStok)
        {
            DAL dl = new DAL();

            dl.InputParametreEkle("@urun_no", urunNo);
            dl.InputParametreEkle("@urun_adi", urunAdi);
            dl.InputParametreEkle("@urun_stok", urunStok);
            int sonuc = dl.EkleSilGuncelle("sp_UrunGuncelle", CommandType.StoredProcedure);

            return sonuc;
        }

        public List<Urun> UrunleriGetir()
        {
            DAL dl = new DAL();

            SqlDataReader dr = dl.DRVeriCek("sp_UrunleriCek", CommandType.StoredProcedure);

            if (dr.HasRows)
            {
                List<Urun> Urunler = new List<Urun>();
                while (dr.Read())
                {
                    Urun urun = new Urun { urunNo = Convert.ToInt32(dr["urun_no"].ToString()), urunAdi = dr["urun_adi"].ToString(), urunStok = Convert.ToInt32(dr["urun_stok"].ToString()) };

                    Urunler.Add(urun);
                }
                return Urunler;
            }
            return null;
        }
    }
}
