using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Data
{
    class Connection
    {
        SqlConnection baglanti;

        public SqlConnection BaglantiKablosu
        {
            get
            {
                if(baglanti != null)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    return baglanti;
                }
                else
                {
                    baglanti = new SqlConnection(Provider());
                    if(baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    return baglanti;
                }
            }
            set
            {
                baglanti = value;
            }
        }
        static private string Provider()
        {
            return ConfigurationManager.AppSettings["BaglantiCumlesi"];
        }
    }
}
