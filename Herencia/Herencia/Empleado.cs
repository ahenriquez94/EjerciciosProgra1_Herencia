using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Empleado
    {
        public String nombre;
        public double sueldo;

        public Empleado()
        {
            nombre = "";
            sueldo =0;
        }

        public Empleado(String nombre, double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public void capturar()
        {
            Console.WriteLine("Por favor ingrese su sueldo: ");
            sueldo = double.Parse(Console.ReadLine());
            if (sueldo>3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos");
            }
        }

        public void imprimir()
        {
            Console.WriteLine("El nombre del empleado es: "+nombre+" Y su sueldo corresponde a: "+sueldo);
        }


    }
}
