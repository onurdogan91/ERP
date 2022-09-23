using FakeData;
using System.Data;

namespace Project1
{
    class Program
    {
        static List<Student> students; = new List<Student>();
            
        static void Main()
        {
            Fill();
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

        private static void Fill()
        {
            int gender;
            int age;

            for (int i = 0; i < 20; i++)
            {
                Student student = new Student();
                student.Name = FakeData.NameData.GetFirstName();
                student.Street = FakeData.PlaceData.GetStreetName();
                gender = FakeData.NumberData.GetNumber(0,2);
                if (gender == 0)
                {
                    student.Gender = 'M';
                }
                else
                {
                    student.Gender = 'F';
                }
                age = FakeData.NumberData.GetNumber(18,28);
                student.BYear = DateTime.Now.AddYears(age * -1);
                student.Id = i;
                student.District = FakeData.PlaceData.GetCountry();
                student.DoorNo = FakeData.NumberData.GetNumber(1, 100);
                student.Surname = FakeData.NameData.GetSurname();
                student.City = FakeData.PlaceData.GetCity();
                student.Salary = FakeData.NumberData.GetNumber(10000, 50000);

                olist.Add(student);
            }
            Print(olist);
        }

        private static void Print(List<Student> olist)
        {
            Console.Clear();
            Console.WriteLine("Id      Name     Surname      Gender");
            Console.WriteLine("====================================");
            foreach (var item in olist)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname + " " + item.Gender);
            }
            TotalPrint2(olist);
            Menu();
        }

        private static void TotalPrint(List<Student> olist)
        {
            int personNumber = 0;
            int maleNumber = 0;
            int femaleNumber = 0;
            int totalSalary = 0;
            int maleTotalSalary = 0;
            int femaleTotalSalary = 0;

            foreach(var item in olist)
            {
                personNumber += 1;
                totalSalary += item.Salary;
                if (item.Gender == 'M')
                {
                    maleNumber++;
                    maleTotalSalary += item.Salary;
                }
                else
                {
                    femaleNumber++;
                    femaleTotalSalary += item.Salary;
                }
            }
            Console.WriteLine(maleNumber);
            Console.WriteLine(femaleNumber);
        }
        private static void TotalPrint2(List<Student> olist)
        {
            int personNumber = 0;
            int maleNumber = 0;
            int femaleNumber = 0;
            int totalSalary = 0;
            int maleTotalSalary = 0;
            int femaleTotalSalary = 0;

            personNumber = olist.Count;
            maleNumber = olist.Where(x=> x.Gender=='M').Count();
            femaleNumber = olist.Where(x => x.Gender == 'F').Count();
            totalSalary = olist.Sum(x => x.Salary);
            maleTotalSalary = olist.Where(x => x.Gender == 'M').Sum(x => x.Salary);
            femaleTotalSalary = olist.Where(x => x.Gender == 'F').Sum(x => x.Salary);

            Console.WriteLine("Total");
            Console.WriteLine("==========");
            Console.WriteLine("Number of Male :" + olist.Where(x => x.Gender == 'M').Count());
            Console.WriteLine("Number of Female :" + olist.Where(x=> x.Gender == 'F').Count());
            Console.WriteLine("Avarage");
            Console.WriteLine("==========");
            Console.WriteLine("Avarage Female Salary :" + olist.Where(x => x.Gender == 'F').Average(x => x.Salary));
        }

        static private Student SelectStudent()
        {
            Console.WriteLine("Id ?");
            int selectId = Convert.ToInt32(Console.ReadLine());
            return olist.Find(x => x.Id == SelectStudent);
        }

        static private Student NewData(Student stu)
        {
            string Name, Surname, City, District, Street;
            char Gender;
            DateTime BDay;
            int doorNo, salary;

            Console.WriteLine("Name = ");
            Name = Console.ReadLine();
            Console.WriteLine("Surname = ");
            Surname = Console.ReadLine();
            Console.WriteLine("Gender (M/F) = ");
            Gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Birthday (mm/dd/year) = ");
            BDay = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("City = ");
            City = Console.ReadLine();
            Console.WriteLine("District = ");
            District = Console.ReadLine();
            Console.WriteLine("Street = ");
            Street = Console.ReadLine();
            Console.WriteLine("Door No =");
            doorNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Salary = ");
            salary = Convert.ToInt32(Console.ReadLine());

            stu.Name = Name;
            stu.Surname = Surname;
            stu.Gender = Gender;
            stu.BYear = BDay;
            stu.City = City;
            stu.District = District;
            stu.Street = Street;
            stu.DoorNo = doorNo;
            stu.Salary = salary;

            return stu;
        }
    }
}