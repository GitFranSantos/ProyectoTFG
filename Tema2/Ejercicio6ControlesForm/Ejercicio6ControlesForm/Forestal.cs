using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6ControlesForm
{
    public class Forestal
    {
        public string Nombre { get; set; }  
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return Apellido1 + " " + Nombre;
        }
        /*
        public Forestal(string nombre , string apellido1, string apellido2, string telefono)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Telefono = telefono;
        }
        */
    }
}
