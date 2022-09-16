namespace kareUcgenDaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangi islemi yapmak istersiniz :");
            Console.WriteLine("1 - Kare Alanı, 2 - Ucgen Alanı, 3 - Daire Alanı");
            int select = Convert.ToInt32(Console.ReadLine());
            int calc = select;
            switch (calc)
            {
                case 1: Console.WriteLine("Karenin Alanı Icın Kenar Uzunlugu Giriniz : ");
                    double kare = Convert.ToInt32(Console.ReadLine());
                    double kAlan = kare * kare;
                    Console.WriteLine("Karenin Alani : " + kAlan);
                    break;
                case 2: Console.WriteLine("Ucgen Alanı Icın Yukseklik Giriniz : ");
                    double ucgenH = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ucgen Alanı Icın Taban Uzunlugu Giriniz : ");
                    double ucgenT = Convert.ToInt32(Console.ReadLine());
                    double uAlan = (ucgenH * ucgenT) / 2;
                    Console.WriteLine("Ucgenin Alani : " + uAlan);
                    break;
                case 3: Console.WriteLine("Dairenin Alanı Icın Yarıcap Giriniz : ");
                    double daire = Convert.ToInt32(Console.ReadLine());
                    double kDaire = (Math.PI * (daire * daire));
                    Console.WriteLine("Dairenin Alani : " + kDaire);
                    break;
                default: Console.WriteLine("Yanlis Giris Yaptınız!!!");
                    break;                    
            }
        }
    }
}