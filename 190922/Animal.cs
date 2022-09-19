using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190922
{
    public class Animal
    {
        public Animal()
        {
            weight = -1;
            name = "undefined";
            gender = 2;
        }
        public int weight;
        public string name;
        public int gender;
        //0-F 1-M

        public string GetAnimalProperties()
        {
            //return "Weight : " + weight + "Name: " + name + "Gender : " + gender;
            return String.Format("Weight:{0} Name:{1} Gender:{2}", weight,name,gender);
        }

    }
}
