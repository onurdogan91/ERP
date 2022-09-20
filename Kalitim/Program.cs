namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            o.Ad = "Safiye";
            o.Bolum = "Makine Müh";
            o.Soyad = "Kaya";
            o.Cins = 'K';
            o.Id = 1;
            o.DogumTarih = Convert.ToDateTime("01/01/1996");
            o.Adres.Cadde = "Ayvansaray Caddesi";
            o.Adres.Ilce = "Kadıköy";
            o.Adres.Sehir = "Istanbul";
            o.Adres.Sokak = "Balat Sokak";
            o.Adres.Kapino = 7;

            //Console.WriteLine(o.Cins);
            foreach (var item in o.GetAdres())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(o.GetAge());
            Console.WriteLine(o.KayitTarihi);

        }
    }
}