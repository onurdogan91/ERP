using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Temel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Adres Adres { get; set; }
        private char _Cins;
        public char Cins { 
            get
            {return _Cins;} 
            set{
                if(value == 'E')
                    {
                    _Cins = value;
                        Console.WriteLine ($"Sayın Bay {Ad} {Soyad}");
                    }
                    else if(value == 'K') 
                    {
                    _Cins = value;
                        Console.WriteLine($"Sayın Bayan {Ad} {Soyad}");
                    }
                else {
                    _Cins = value;
                    Console.WriteLine("Yanlış Değer");
                     }
                } 
        }
        public DateTime DogumTarih { get; set; }

        public Temel()        
        {
            Adres = new Adres();
        }

        //public string GetTitle()
        //{
        //    if (Cins == 'E')
        //    {
        //        return $"Sayın Bay {Ad} {Soyad}";
        //    }
        //    else
        //    {
        //        return $"Sayın Bayan {Ad} {Soyad}";
        //    }
        //    Char cinsiyet = Cins;
        //    Console.WriteLine(Cins);
        //    return Cins;
        //}

        public List<string> GetAdres()
        {
            List<string> adres = new List<string>();
            adres.Add(Adres.Cadde);
            adres.Add(Adres.Sokak);
            adres.Add(Adres.Kapino.ToString());
            adres.Add($"{Adres.Ilce}/{Adres.Sehir}");
            return adres;
        }
        public int GetAge()
        {
            DateTime today = DateTime.Now;
            int yas = today.Year - DogumTarih.Year;
            DateTime DogumGunu = DogumTarih.AddYears(yas);
            if(DogumGunu < today)
            {
                yas++;
            }
            return yas;
        }
    }
}
