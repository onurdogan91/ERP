namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fakulteler f = new Fakulteler(); //get set olursa newlemek lazım.

            Fakulteler f;

            f.Id = 1;
            f.FakulteAd = "Güzel Sanatlar";
            Console.WriteLine(f.FakulteAd);
        }
    }
}