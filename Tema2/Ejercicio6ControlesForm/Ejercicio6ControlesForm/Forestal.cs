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
            return Nombre + " " + Apellido1;
        }


    }
}
