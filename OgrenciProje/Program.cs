using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace OgrenciListesi
{
    internal class Program
    {
        static List<Ogrenci> olist = new List<Ogrenci>();

        static void Main()
        {
            Doldur();
        }

        private static void Menu()
        {
            Console.WriteLine("1-Tüm Veriler");
            Console.WriteLine("2-Detay Görüntüle");
            Console.WriteLine("3-Yeni Öğrenci");
            Console.WriteLine("4-Silme");
            Console.WriteLine("5-Güncelleme");
            Console.WriteLine("6-Arama");
            Console.WriteLine("7-İsme Göre Sıralama (A-Z)");
            Console.WriteLine("8-İsme Göre Sıralama (Z-A)");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Yaz(olist);
            }
            else if (secim == 2)
            {
                Detay();
            }
            else if (secim == 3)
            {
                Giris();
            }
            else if (secim == 4)
            {
                Sil();
            }
            else if (secim == 5)
            {
                Guncel();
            }
            else if (secim == 6)
            {
                Ara();
            }
            else if (secim == 7)
            {
                SiralaAZ();
            }
            else if (secim == 8)
            {
                SiralaZA();
            }
            else
            {
                Console.WriteLine("Yanlış Seçim");
            }
            Menu();
        }

        private static void SiralaZA()
        {
            var yolist = olist.OrderByDescending(x => x.Ad).ToList();
            Yaz(yolist);
        }

        private static void SiralaAZ()
        {
            var yolist = olist.OrderBy(x => x.Ad).ToList();
            Yaz(yolist);
        }

        private static void Ara()
        {
            Console.WriteLine("Aramak istediğiniz isim");
            string ara = Console.ReadLine();
            var yolist = olist.Where(x => x.Ad.Contains(ara) || x.Soyad.Contains(ara)).ToList();
            Yaz(yolist);
        }

        private static void Guncel()
        {
            Ogrenci guncelOgr = OgrenciSec();

            YeniVeriler(guncelOgr);

            Yaz(olist);
        }

        private static void Sil()
        {
            Ogrenci secOgr = OgrenciSec();
            olist.Remove(secOgr);
            Yaz(olist);
        }

        private static void Giris()
        {
            Ogrenci yeniOgrenci = new Ogrenci();
            yeniOgrenci = YeniVeriler(yeniOgrenci);
            yeniOgrenci.Id = olist.Max(x => x.Id) + 1;
            olist.Add(yeniOgrenci);
            Yaz(olist);
        }

        private static void Detay()
        {
            Ogrenci secilenOgrenci = OgrenciSec();
            Console.WriteLine(secilenOgrenci.GetTitle() + " (" + secilenOgrenci.GetAge() + ")");
            foreach (var item in secilenOgrenci.GetAdres())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Şehir :" + secilenOgrenci.Sehir);
        }

        private static void Doldur()
        {
            int cns;
            int yas;
            for (int i = 0; i <= 20; i++)
            {
                Ogrenci o = new Ogrenci();
                o.Ad = FakeData.NameData.GetFirstName();
                o.Cadde = FakeData.PlaceData.GetStreetName();
                cns = FakeData.NumberData.GetNumber(0, 2);
                if (cns == 0)
                {
                    o.Cins = 'E';
                }
                else
                {
                    o.Cins = 'K';
                }
                yas = FakeData.NumberData.GetNumber(18, 28);
                o.DogumTarih = DateTime.Now.AddYears(yas * -1);
                o.Id = i;
                o.Ilce = FakeData.PlaceData.GetCounty();
                o.KapiNo = FakeData.NumberData.GetNumber(1, 100);
                o.Soyad = FakeData.NameData.GetSurname();
                o.Sehir = FakeData.PlaceData.GetCity();
                o.Maas = FakeData.NumberData.GetNumber(750, 1000);
                olist.Add(o);

            }
            Yaz(olist);
        }

        private static void Yaz(List<Ogrenci> olist)
        {
            Console.Clear();
            Console.WriteLine("Id   Ad   Soyad  Cinsiyet");
            Console.WriteLine("=================");
            foreach (var item in olist)
            {
                Console.WriteLine(item.Id + " " + item.Ad + " " + item.Soyad + " " + item.Cins);
            }
            ToplamYaz2(olist);
            Menu();
        }

        public static void ToplamYaz(List<Ogrenci> olist)
        {
            int kisiSayi = 0;
            int erkekSayi = 0;
            int kadinSayi = 0;
            int maasToplam = 0;
            int erkekMaasToplam = 0;
            int kadinMaasToplam = 0;
            foreach (var item in olist)
            {
                kisiSayi += 1;
                maasToplam += item.Maas;
                if (item.Cins == 'E')
                {
                    erkekSayi++;
                    erkekMaasToplam += item.Maas;
                }
                else
                {
                    kadinSayi++;
                    kadinMaasToplam += item.Maas;
                }
            }
            Console.WriteLine(erkekSayi);
            Console.WriteLine(kadinSayi);
        }

        private static void ToplamYaz2(List<Ogrenci> olist)
        {
            Console.WriteLine("Toplamlar");
            Console.WriteLine("==========");
            Console.WriteLine("Erkek Sayısı :" + olist.Where(x => x.Cins == 'E').Count());
            Console.WriteLine("Kadın Sayısı :" + olist.Where(x => x.Cins == 'K').Count());
            Console.WriteLine("Ortalamalar");
            Console.WriteLine("============");
            if (olist.Where(x => x.Cins == 'K').Count() != 0)
            {
                Console.WriteLine("Ortalama Kadın Maaşı :" + olist.Where(x => x.Cins == 'K').Average(x => x.Maas));
            }
            else if (olist.Where(x => x.Cins == 'E').Count() != 0)
            {
                Console.WriteLine("Ortalama Erkek Maaşı :" + olist.Where(x => x.Cins == 'E').Average(x => x.Maas));
            }


        }

        private static Ogrenci OgrenciSec()
        {
            Console.WriteLine("Id ?");
            int secilenId = Convert.ToInt32(Console.ReadLine());
            return olist.Find(x => x.Id == secilenId);
        }

        private static Ogrenci YeniVeriler(Ogrenci ogr)
        {
            string Isim, Soyisim, Seh, Ilc, Cad;
            char Cins;
            DateTime DogumT;
            int kNo, m;

            Console.WriteLine("Ad = ");
            Isim = Console.ReadLine();
            Console.WriteLine("Soyad = ");
            Soyisim = Console.ReadLine();
            Console.WriteLine("Cinsiyet (E / K) = ");
            Cins = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Doğum Tarihi (ay/gün/yıl) = ");
            DogumT = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Şehir = ");
            Seh = Console.ReadLine();
            Console.WriteLine("İlçe = ");
            Ilc = Console.ReadLine();
            Console.WriteLine("Cadde = ");
            Cad = Console.ReadLine();
            Console.WriteLine("Kapı No = ");
            kNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maaş = ");
            m = Convert.ToInt32(Console.ReadLine());

            ogr.Ad = Isim;
            ogr.Soyad = Soyisim;
            ogr.Cins = Cins;
            ogr.DogumTarih = DogumT;
            ogr.Sehir = Seh;
            ogr.Ilce = Ilc;
            ogr.Cadde = Cad;
            ogr.KapiNo = kNo;
            ogr.Maas = m;

            return ogr;

        }


    }
}