namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "sAFiye";
            DateTime bugun = DateTime.Now;

            string s = "2022003";

            Console.WriteLine(s.ToDate());
            Console.WriteLine(bugun.ToJulian());
            Console.WriteLine(ad.IlkHarfBuyuk());
        }
    }
}