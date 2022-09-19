using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat : Animal
    {
        public int runSpeed;
        public string sound;
        public string GetProperties()
        {
            string animalProperties = base.GetAnimalProperties();
            string catProperties = String.Format("RunSpeed:{0} Sound:{1}", runSpeed, sound);
            return animalProperties + " " + catProperties;
        }

    }
}
