using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Bankamatik
{
    public class PasswordCheck
    {
        public static void Password()
        {          
            int userPass = 123456;
            int userId = 987654;
            int i = 0 ;
            do
            {
                Console.WriteLine("Lütfen Kullanıcı Adını Giriniz: ");
                int userName =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen Şifrenizi Giriniz: ");
                int password = Convert.ToInt32(Console.ReadLine());

                if (password == userPass && userId == userName )
                {
                    Console.WriteLine("Giriş Yapıldı...");
                    i = 3;                   
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Şifreniz ve ya Kullanıcı Adı Hatalı!!!");
                    i++;
                }               
            } while(i < 3);           
            
        }   
    }
}
