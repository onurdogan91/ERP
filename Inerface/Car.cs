using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inerface
{
    internal class Car : IVehicle
    {
        public void Brake(int Speed)
        {
            throw new NotImplementedException();
        }

        public int GasLevel()
        {
            throw new NotImplementedException();
        }

        public void Move(int Speed)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
