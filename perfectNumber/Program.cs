using System;

namespace perfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n, i, toplam;
            double min = 2, max = 99999999;

            for(i = min;i <= max; i++)
            {
                n = 1;
                toplam = 0;
                while(n < i)
                {
                    if(i % n == 0)
                        toplam += n;
                    n++;
                }
                if (toplam == i)
                    Console.WriteLine(i);
            }
        }
    }
}