using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Animal
    {
        public int weight;
        public string name;
        public int length;
        public int energy;
        public string GetAnimalProperties()
        {
            return string.Format("Name:{0} Length:{1} Weight:{2}", name, weight, length);
        }
        public abstract void Move();
        //Abstract Metot. Animaldam türeyen diğer classlarda move metodu olmak zorunda ve metodu çağıran kişinin metodu doldurması gerekir. Burada metodun gövdesi yoktur, işlem yapılamaz. Her hayvan tipi için farklılık gösterir.
        
        public virtual void Sleep()
            //Bunu da isteyen kullanabilir ya da ezebilir.
        {            
            energy += 5;
        }          
    }
}
