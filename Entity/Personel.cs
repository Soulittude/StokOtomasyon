using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Personel
    {
        public int personelNo { get; set; }
        public string personelAdi { get; set; }
        public string personelSifre { get; set; }
        public string personelYetki { get; set; }

        public Personel() { }

        public Personel(int personelNo, string personelAdi, string personelSifre, string personelYetki)
        {
            this.personelNo = personelNo;
            this.personelAdi = personelAdi;
            this.personelSifre = personelSifre;
            this.personelYetki = personelYetki;
        }
    }
}
