namespace _190922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.name = ("MirMir");
            cat.weight = 4;
            cat.gender = 1;
            Console.WriteLine(cat.GetAnimalProperties());

            Animal bird = new Animal();
            bird.name = ("Faruk");
            bird.weight = 1;
            bird.gender = 1;
            Console.WriteLine(bird.GetAnimalProperties());

            Animal dog = new Animal();
            dog.name = ("Karabas");
            Console.WriteLine(dog.GetAnimalProperties());
        }
    }
}