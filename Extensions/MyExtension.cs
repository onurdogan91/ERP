using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class MyExtension
    {
        public static string IlkHarfBuyuk(this String txt)
        {
            return txt.Substring(0,1).ToUpper() + txt.Substring(1).ToLower();
        }

        public static int ToJulian (this DateTime d)
        {
            int yil = d.Year * 1000;
            int gun = d.DayOfYear;
            yil = yil + gun;
            return yil;
        }

        public static DateTime ToDate (this string x)
        {
            int jDate = Convert.ToInt32 (x);
            int day = jDate % 1000;
            int year = (jDate - day) / 1000;
            var date1 = new DateTime(year, 1, 1);
            var result = date1.AddDays(day-1);
            return date1;
        }


    }
}
