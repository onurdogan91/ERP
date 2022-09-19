namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.a = 3;
            rectangle.b = 4;

            Console.WriteLine(rectangle.CalculateArea());
        }
    }
}