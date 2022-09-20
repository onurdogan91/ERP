using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Ogrenci : Temel
    {
        public string Bolum { get; set; }

        public DateTime KayitTarihi { get; set; }

        public Ogrenci()
        {
            KayitTarihi = DateTime.Now;
            
        }
    }
}
