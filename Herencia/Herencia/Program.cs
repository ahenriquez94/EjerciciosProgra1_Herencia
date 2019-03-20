using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Club obj1 = new Club();
            //obj1.imprimir();

            //Empleado obj2 = new Empleado("Jorge Luis",5000);
            //obj2.capturar();
            //obj2.imprimir();

            Operaciones obj3 = new Operaciones(10, 2);
            Console.WriteLine("La suma de los valores es: "+obj3.Suma());
            Console.WriteLine("La resta de los valores es: "+obj3.Resta());
            Console.WriteLine("La multiplicacion de los valores es: "+obj3.Multiplicacion());
            obj3.Division();


            Console.ReadKey();
        }
    }
}
