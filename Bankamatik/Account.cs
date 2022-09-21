using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik
{
    public class Account : Program
    {
        
        public static void withdraw()
        {
            Program program = new Program();
            int i = 0;
            do
            {                
                int withdraw = 0;
                withdraw = Convert.ToInt32(Console.ReadLine());

                if (withdraw <= program.balance )
                {
                    program.balance -= withdraw;
                    Console.WriteLine("Güncel Bakiyeniz : " + program.balance);
                    i = 1 ;
                }
                else if(program.balance < withdraw)
                {
                    Console.WriteLine("Bakiyeniz Yetersiz!!!");
                    i = 1;
                }
                else
                {
                    i = 1;
                }

            } while (i == 0);
            
        }
        
        public static void investment()
        {

        }
    }
}
