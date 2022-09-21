using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik
{
    public class Menu
    {
        public static void menu()
        {
            Console.WriteLine("Hoşgeldiniz");
            int y = 0;
            

            do
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz ; ");

                Console.WriteLine("1 - Para Çekme");
                Console.WriteLine("2 - Para Yatırma");
                Console.WriteLine("3 - Bakiye Sorgula");
                Console.WriteLine("4 - Çıkış");
                Account account = new Account();
                int i = Convert.ToInt32(Console.ReadLine());
                
                Console.Clear();
                

                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("Çekmek istediğiniz tutarı giriniz :");
                            Account.withdraw();
                            y = 1;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz :");
                            y = 1;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Bakiyeniz : ");
                            y = 1;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Güle güle...");
                            y = 0;
                            break;
                            
                        }
                    default:
                        {
                            Console.WriteLine("Yanlış Giriş Yaptınız!!!");
                            y = 1;
                            break;
                            
                        }
                }                
            } while (y == 1);
            
        }
    }
}
