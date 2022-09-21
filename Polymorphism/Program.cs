namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Ayşe";
            ogrenci.Soyad = "Yılmaz";
            ogrenci.Id = 1234;
            Console.WriteLine(ogrenci.Id);
            Console.WriteLine(ogrenci);
        }
    }
}