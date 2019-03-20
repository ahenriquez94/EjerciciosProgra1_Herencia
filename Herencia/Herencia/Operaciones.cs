using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Operaciones
    {
        public int a, b, suma, resta, multiplicacion, division;

        public Operaciones()
        {
            a = 0;
            b = 0;
        }

        public Operaciones(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Suma()
        {
            suma = a + b;
            return suma;
        }

        public int Resta()
        {
            resta = a - b;
            return resta;
        }

        public int Multiplicacion()
        {
            multiplicacion = a * b;
            return multiplicacion;
        }

        public void Division()
        {
            if (b==0)
            {
                Console.WriteLine("NO SE PUEDE DIVIDR ENTRE CERO");

            }else if (b>0) {
                division = (a / b);
                Console.WriteLine("La division de los valores es: " + division);
            }
            
            
        }  
    }
}
