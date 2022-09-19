namespace studentInformationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not Bilgisi Girmek İstediğiniz Öğrenci Ad ve Soyadını Giriniz: ");
            String x = Console.ReadLine();
            Console.WriteLine("Ders Adini Giriniz: ");
            String y = Console.ReadLine();
            Console.WriteLine("Ders Kodu Giriniz: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vize Notu Giriniz: ");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vize Notu Giriniz: ");
            int w = Convert.ToInt32(Console.ReadLine());



            Student s1234 = new Student();
            s1234.NameSurname = x;
            s1234.LessonName = y;
            s1234.LessonCode = z;
            s1234.ScoreVize = q;
            s1234.ScoreFinal = w;

            Console.WriteLine(s1234.GetProperties());
            Console.WriteLine("Gecme Durumu : " + s1234.Calculations());
            

        }
    }
}