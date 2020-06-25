using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class operaciones : MarshalByRefObject
    {
        public double sumar(double int1, double int2)
        {
            return int1 + int2;
        }
        public double restar(double int1, double int2)
        {
            return int1 - int2;
        }
        public double multiplicar(double int1, double int2)
        {
            return int1 * int2;

        }
        public double dividir(double int1, double int2)
        {
            return int1 / int2;
        }

    }
}
