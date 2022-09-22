using FakeData;
using System.Data;

namespace Project1
{
    class Program
    {
        static List<Student> students; = new List<Student>();
            ////start:
            //Student student = new Student();
            //FakeData.NameData.GetFirstName();
            //Console.WriteLine("Name : " + FakeData.NameData.GetFirstName());
            //Console.WriteLine("Surname : " + FakeData.NameData.GetSurname() );
            //Console.WriteLine("Age : " + FakeData.NumberData.GetNumber(18, 28));
            ////goto start;
        static void Main()
        {
            Doldur();
        }
        private static void Menu()
        {
            Console.WriteLine("1 - All Datas");
            Console.WriteLine("2 - View Details");
            Console.WriteLine("3 - New Student");
            Console.WriteLine("4 - Remove");
            Console.WriteLine("5 - Update ");
            Console.WriteLine("6 - Search");
            Console.WriteLine("7 - Sorting by Name(A-Z");
            Console.WriteLine("8 - Sorting by Name(Z-A");
            int select = Convert.ToInt32(Console.ReadLine());
            if (select == 1)
            {
                Print(students);
            }
            else if(select == 2)
            {
                Details();
            }
            else if (select == 3)
            {
                Entry();
            }
            else if(select == 4)
            {
                Remove();
            }
            else if (select == 5)
            {
                Update();
            }
            else if (select == 6)
            {
                Search();
            }
            else if(select == 7)
            {
                SortingAZ();
            }
            else if( select == 8)
            {
                SortingZA();
            }
            else
            {
                Console.WriteLine("Wrong Choice");
            }
            Menu();
        }
        private static void SortingZA()
        {
            var ylist = students.OrderByDescending(x => x.Name).ToList();
        }
    }
}