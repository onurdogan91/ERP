using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace Lesson_150922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            int[] dizi = 
             int[] dizi = { 1, 2, 3};

             for(int i = 0; i < dizi.Length; i++)
             {
                 Console.WriteLine(dizi[i]);
             }
            */

            /* 
            string.Compare(string A, string B);
            b > a = 1
            b = a = 0
            b < a = -1 
            */

            //int c = string.Compare("Onur", "Mahmut");
            //Console.WriteLine(c);

            //iki boyutlu diziler

            /*
            int[,] onur = new int[11, 6];
            onur.Length;
            onur.GetLength(0); satır
            onur.GetLength(1); sütun
            */

            /*
            int[,] sample = new int[10, 30];
            for(int i = 0; i < sample.GetLength(0); i++)
            {
                for(int j = 0; j < sample.GetLength(1); j++)
                {
                    sample[i, j] = i;                    
                }
            }

            for (int i = 0; i < sample.GetLength(0); i++)
            {
                for (int j = 0; j < sample.GetLength(1); j++) 
                {                    
                    Console.Write(sample[i, j]);                    
                }
                Console.WriteLine("");
            }            
            */

            /*
            int[] dizi = { 1, 2, 3 };
            string[] isimler = {"a", "b", "c" };
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(8);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Remove(2); //yazılan indisi değil rakamı siler
            Console.WriteLine(sayilar.Count);

            for(int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            */

            
            int[] sayilar = new int[10];
            Random rand = new Random();
            int sayac = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar [i] = rand.Next(1,200);
                Console.Write(sayilar [i] + "\t");
                if ((sayilar[i]) > 100)
                {
                    sayac++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("sayac : " + sayac);
            
            double ortalama, toplam = 0, sayacB = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < 150)
                {
                    toplam += sayilar[i];
                    sayacB++;
                }                
            }
            ortalama = toplam / sayacB;
            Console.WriteLine("150 den kucuk sayilarin ortalamasi : {0}", ortalama);

            int ciftSayilarSayaci = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if ((sayilar[i]) %2 == 0)
                {
                    ciftSayilarSayaci++;
                }

            }
            Console.WriteLine("Cift sayilarin adedi {0} dir", ciftSayilarSayaci);

            Console.WriteLine("Bir metin giriniz : ");
            string giris = Console.ReadLine();
            foreach(char karakter in giris)
            {
                Console.WriteLine(karakter);
            }
            Console.WriteLine("----------");
            for (int i = giris.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(giris[i]);
            }

        }
    }
}