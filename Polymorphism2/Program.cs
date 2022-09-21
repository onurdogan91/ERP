namespace Polymorphism2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.CalisanAd = "Bill Gates";
            yonetici.CalisanMaas = 8500;
            yonetici.DepartmanKar = 55000;

            Console.WriteLine("Yönetici Adı: {0} Maaş: {1} Departman Karı: {2}", yonetici.CalisanAd.ToString(), yonetici.CalisanMaas.ToString(), yonetici.DepartmanKar.ToString() );

            yonetici.ZamYap(1500);
            Console.WriteLine("Zamlı Maaş : {0}", yonetici.CalisanMaas);
        }
    }
}