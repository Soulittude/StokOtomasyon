using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DAL
    {
        private SqlCommand SorguYaz(string Sorgu, CommandType SorguTipi)
        {
            Connection c = new Connection();
            SqlCommand cmd = c.BaglantiKablosu.CreateCommand();
            cmd.CommandText = Sorgu;
            cmd.CommandType = SorguTipi;
            return cmd;
        }

        List<SqlParameter> Parametreler = new List<SqlParameter>();

        public void InputParametreEkle(string ParametreAdi, object ParametreDegeri)
        {
            SqlParameter parametre = new SqlParameter();
            parametre.ParameterName = ParametreAdi;
            parametre.Value = ParametreDegeri;
            Parametreler.Add(parametre);
        }

        public void OutputParametreEkle(string ParametreAdi, object ParametreDegeri)
        {
            SqlParameter parametre = new SqlParameter();
            parametre.ParameterName = ParametreAdi;
            parametre.Value = ParametreDegeri;
            parametre.Direction = ParameterDirection.Output;
            Parametreler.Add(parametre);
        }

        private void ParametreleriSorguyaEkle(SqlCommand CommandNesnesi)
        {
            CommandNesnesi.Parameters.AddRange(Parametreler.ToArray());
        }

        public object ParametreDegeriniGetir(string ParametreAdi)
        {
            foreach(var item in Parametreler)
            {
                if(item.ParameterName == ParametreAdi)
                {
                    return item.Value.ToString();
                }
            }
            return null;
        }
        
        public int EkleSilGuncelle(string Sorgu, CommandType SorguTipi)
        {
            try
            {
                SqlCommand cmd = SorguYaz(Sorgu, SorguTipi);
                ParametreleriSorguyaEkle(cmd);
                int sonuc = cmd.ExecuteNonQuery();

                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Connection.Dispose();
                cmd.Dispose();

                return sonuc;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public object IlkSatirIlkSutun(string Sorgu, CommandType SorguTipi)
        {
            try
            {
                SqlCommand cmd = SorguYaz(Sorgu, SorguTipi);
                ParametreleriSorguyaEkle(cmd);
                object Sonuc = cmd.ExecuteScalar();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Connection.Dispose();
                cmd.Dispose();

                return Sonuc;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public SqlDataReader DRVeriCek(string Sorgu, CommandType SorguTipi)
        {
            SqlCommand cmd = SorguYaz(Sorgu, SorguTipi);
            ParametreleriSorguyaEkle(cmd);

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return dr;
        }

        public DataTable DTVeriCek(string Sorgu, CommandType SorguTipi)
        {
            try
            {
                SqlDataReader dr = DRVeriCek(Sorgu, SorguTipi);

                DataTable dt = new DataTable();
                dt.Load(dr);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
