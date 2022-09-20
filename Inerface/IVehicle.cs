using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inerface
{
    public interface IVehicle
        //Şablon classlar olarak bilinir ve türetildiği yerde zorunlu metodlar oluşur.
    {
        void Run();

        void Stop();

        void Move(int Speed);

        void Brake(int Speed);

        int GasLevel();
        //Metodların gövdesi yoktur ancak standart hale getirilmesi için Interface tanımlanır.
    }
}
