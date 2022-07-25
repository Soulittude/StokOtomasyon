using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Urun
    {
        public int urunNo { get; set; }
        public string urunAdi { get; set; }
        public int urunStok { get; set; }

        public Urun() { }

        public Urun(int urunNo, string urunAdi, int urunStok)
        {
            this.urunNo = urunNo;
            this.urunAdi = urunAdi;
            this.urunStok = urunStok;
        }
    }
}
