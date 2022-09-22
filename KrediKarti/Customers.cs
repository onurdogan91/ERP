using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKarti
{
    public class Customers
    {

        private string _KrediKartNo;

        public string KrediKartNo
        {
            get 
            { 
                return "************" + _KrediKartNo.Substring(_KrediKartNo.Length - 4); 
            }
            set 
            { 
                bool kontrol = false;
                if (value.Length == 16)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);
                        if (sayiMi)
                        {

                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("Geçerli bir bilgi giriniz!!!");
                    }
                    else
                    {
                        _KrediKartNo = value;                        
                    }
                }
                else
                {
                    Console.WriteLine("Hane sayisi yanlış!!!;");
                }
            }
        }
    }
}
