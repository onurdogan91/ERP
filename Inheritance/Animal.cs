using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public int weight;
        public string name;
        public int length;
        public string GetAnimalProperties()
        {
            return string.Format("Name:{0} Length:{1} Weight:{2}" , name, weight, length);
        }
    }
}
