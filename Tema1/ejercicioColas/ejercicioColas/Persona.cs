using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioColas
{
    public class Persona
    {
        private int edad;

        public Persona(int edad)
        {
            this.edad = edad;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
    }
}
