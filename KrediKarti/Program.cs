namespace KrediKarti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customers customers = new Customers();
            Console.WriteLine("Kart numaranızı giriniz :");
            customers.KrediKartNo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Girdiğiniz değerler" + " " + customers.KrediKartNo);
        }
    }
}