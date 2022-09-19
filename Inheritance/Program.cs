namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat() { weight = 3, name = "Mırmır" };
            cat.length = 3;
            cat.runSpeed = 20;
            cat.sound = "Meow";

            Bird bird = new Bird();
            bird.weight = 3;
            bird.name = "Faruk";
            bird.length = 10;
            bird.flySpeed = 40;
            bird.flyDistance = 1000;


            Console.WriteLine(cat.GetProperties());
            Console.WriteLine("----------");
            Console.WriteLine(bird.GetProperties());
        }
    }
}