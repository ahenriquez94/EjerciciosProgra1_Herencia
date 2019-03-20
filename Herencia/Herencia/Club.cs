using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Club : Socio
    {
        public void imprimir()
        {
            Console.WriteLine("El cliente con mayor antiguedad es: "+getNombre("")+" con años de antiguedad: "+ getAntiguedad(10));
        }
    }
}
