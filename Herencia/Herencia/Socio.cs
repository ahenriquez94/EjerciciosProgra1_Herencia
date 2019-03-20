using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Socio
    {
        private String nombre;
        private int antiguedad;

        public Socio()
        {
            setNombre("Jorge Quinteros");
            antiguedad = 15;
        }

        public Socio(String nombre, int antiguedad)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre(String nombre)
        {
            return this.nombre;
        }

        public void setAntiguedad(int antiguedad)
        {
            this.antiguedad = antiguedad;
        }

        public int getAntiguedad(int antiguedad)
        {
            return this.antiguedad;
        }

    }
}
