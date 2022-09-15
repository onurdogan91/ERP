namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktoriyel Hesaplanacak Sayiyi Girin :");
            int value;
            int result = 1;
            value = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= value; i++)
            {
                result *= i ;                
            }

            Console.WriteLine("Sonuc : " + result);
        }
    }
}