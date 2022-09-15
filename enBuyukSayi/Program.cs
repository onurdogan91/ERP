namespace enBuyukSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen a sayisini giriniz : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen b sayisini giriniz : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen c sayisini giriniz : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a > b && a > c)
            {
                Console.WriteLine("En buyuk sayi : " + a);
            }else if(b > c && b > a)
            {
                Console.WriteLine("En buyuk sayi : " + b);
            }
            else { Console.WriteLine("En buyuk sayi : " + c);
            }
        }
    }
}