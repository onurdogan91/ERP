using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public char Gender { get; set; }        
        public DateTime BYear { get; set; }
        public string Street { get; set; }
        public int DoorNo { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int Salary { get; set; }

        public string GetTitle()
        {
            if (Gender == 'M')
            {
                return "Mr " + Name + " " + Surname;
            }
            else
            {
                return " Mrs " + Name + " " + Surname;
            }
        }

        public int GetAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - BYear.Year;
            DateTime BDay = BYear.AddYears(age);
            if (BDay < today)
            {
                age++;
            }
            return age;
        }

        public List<String> GetAdress()
        {
            List<String> adress = new List<String>();
            adress.Add(Street);
            adress.Add(DoorNo.ToString());            
            adress.Add(District + " / " + City);
            return adress;
        }

        public String GetAdress2()
        {
            return $" Şehir {Street}\n No {DoorNo}\n" + $" {District + City}";
        }

        public string[] GetAdress3()
        {
            string[] adress = {Street, DoorNo.ToString(), District, City};
            return adress;
        }
    }
}
