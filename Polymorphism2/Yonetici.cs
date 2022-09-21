using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    class Yonetici : Calisan
    {
        private double _departmanKar;
        public double DepartmanKar
        {
            get { return _departmanKar; }
            set { _departmanKar = value; }
        }

        public override void ZamYap(double zamMiktar)
        {
            if (DepartmanKar > 50000)
            {
                zamMiktar += 2000;
            }
            base.ZamYap(zamMiktar);
        }
    }
}
