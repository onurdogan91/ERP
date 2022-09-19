using System.Security.Claims;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Xml.Linq;
using System.Security.AccessControl;

namespace Lesson_160922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do - while dongusu

            /*
            int i = 5;
            do
            {
                Console.WriteLine(i);
                i++;
                
            } while (i < 4);
            Console.WriteLine();
            */

            /*
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }while (i < 11);
            */
            /*            
            int sayac = 0;
            do
            {
                Console.WriteLine("Kullanıcı Adını Giriniz :");
                string userName = Console.ReadLine();
                string uName = "admin";
                Console.WriteLine("Şire Giriniz : ");
                string password = Console.ReadLine();
                string pass = "admin";               

                if (userName == uName && password == pass)
                {
                    Console.WriteLine("Hosgeldiniz");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı Adınızı ve ya Sifrenizi Konrol ediniz!!!");                    
                }
                sayac++;
            } while (sayac < 3);

            do
            {
                Console.WriteLine("Sayi 1 ");

            } while (true);
            */

            //foreach dongusu
            /*
            string[] lessons = { "html", "css", "js", "php" };

            foreach(string lesson in lessons)
            {
                Console.WriteLine(lesson);
            }
            */

            /*
            int[] notlar = { 100, 50, 85, 90, 25, 45, 37, 75, 87 };
            foreach(int not in notlar)
            {
                if (not <= 50)
                {
                    Console.WriteLine(not + "\tNotunuz Kotu!!!");                                       
                }
                else
                {
                    Console.WriteLine(not + "\tNotunuz Iyı...");                                     
                }
            }
            */

            //continue

            /*
            for (int i = 0; i < 7 ; i++)
            {
                if (i == 4)
                {                    
                    continue;
                }
                Console.WriteLine(i);
            }
            */

            /*
            int i = 10;

            while (i>0)
            {
                i--;
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);  
            }
            */


            string isKod;
            int s1 = 0;
            int s2 = 0;
           


        }
    }
}