using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Data;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace Business
{
    public class PersonelBL
    {
        

        public int PersonelEkle(string personelAdi, string personelSifre, string personelYetki)
        {
            DAL dl = new DAL();

            dl.InputParametreEkle("@personel_adi", personelAdi);
            dl.InputParametreEkle("@personel_sifre", personelSifre);
            dl.InputParametreEkle("@personel_yetki", personelYetki);
            int sonuc = dl.EkleSilGuncelle("sp_PersonelEkle", CommandType.StoredProcedure);

            return sonuc;
        }

        public int PersonelSil(int personelNo)
        {
            DAL dl = new DAL();

            dl.InputParametreEkle("@personel_no", personelNo);
            int sonuc = dl.EkleSilGuncelle("sp_PersonelSil", CommandType.StoredProcedure);

            return sonuc;
        }

        public int PersonelGuncelle(int personelNo, string personelAdi, string personelSifre, string personelYetki)
        {
            DAL dl = new DAL();

            dl.InputParametreEkle("@personel_no", personelNo);
            dl.InputParametreEkle("@personel_adi", personelAdi);
            dl.InputParametreEkle("@personel_sifre", personelSifre);
            dl.InputParametreEkle("@personel_yetki", personelYetki);
            int sonuc = dl.EkleSilGuncelle("sp_PersonelGuncelle", CommandType.StoredProcedure);

            return sonuc;
        }

        public List<Personel> PersonelleriGetir()
        {
            DAL dl = new DAL();
            SqlDataReader dr = dl.DRVeriCek("sp_PersonelleriCek", CommandType.StoredProcedure);

            if(dr.HasRows)
            {
                List<Personel> Personeller = new List<Personel>();
                while(dr.Read())
                {
                    Personel personel = new Personel { personelNo = Convert.ToInt32(dr["personel_no"].ToString()), personelAdi = dr["personel_adi"].ToString(), personelSifre = dr["personel_sifre"].ToString(), personelYetki = dr["personel_yetki"].ToString() };

                    Personeller.Add(personel);
                }
                return Personeller;
            }
            return null;
        }

        public string SifreKontrol(int personelNo, string personelSifre)
        {
            string yetki = "";
            DAL dl = new DAL();

            dl.InputParametreEkle("@personel_no", personelNo);
            dl.InputParametreEkle("@personel_sifre", personelSifre);

            SqlDataReader dr = dl.DRVeriCek("sp_SifreKontrol", CommandType.StoredProcedure);

            while (dr.Read())
            {
                yetki = dr["personel_yetki"].ToString();
            }
            return yetki;
        }
    }
}
