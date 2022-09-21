using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik
{
    public class Account
    {                              
        public static void account()
        {
            int balance = 10000;
            int i = 0;
            do
            {                
                int withdraw = 0;
                withdraw = Convert.ToInt32(Console.ReadLine());

                if (withdraw <= balance)
                {
                    balance -= withdraw;
                    Console.WriteLine("Güncel Bakiyeniz : " + balance);
                    i = 1 ;
                }
                else if(balance < withdraw)
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
    }
}
