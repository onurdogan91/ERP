using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class Customers
    {
        public static void Check()
        {
            int i = 1;
            do
            {
                Console.WriteLine("Kredi kartı numarası giriniz : ");
                string CardNo;
                CardNo = Console.ReadLine();
                
                if (CardNo.Length == 16)
                {
                    Console.WriteLine(CardNo.Substring(CardNo.Length-4));
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Tekrar giriş yapınız!!!");
                    i = 0;
                }
            } while (i == 0);
        }
        
        public static bool NumberCheck()
        {
            foreach (c)
        }
    }
}
