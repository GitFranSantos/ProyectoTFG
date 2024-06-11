using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6._1
{
    public class Ciudad
    {

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string CountryCode { get; set; }
        public int Poblacion { get; set; }

        public Ciudad(int id, string nombre, string code, int poblacion) 
        {
            this.ID = id;
            this.Nombre = nombre;
            this.CountryCode = code;
            this.Poblacion = poblacion;
        }
    }
}
