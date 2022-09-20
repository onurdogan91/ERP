using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public int flySpeed;
        public int flyDistance;//bird için farklı özellikler

        public string GetProperties()
        {
            string animalProperties = base.GetAnimalProperties();
            string birdProperties = String.Format("FlySpeed:{0} FlyDistance:{1}", flySpeed, flyDistance);
            return animalProperties + " " + birdProperties;
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
