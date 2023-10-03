using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioColecciones2
{
    public class Persona
    {
        private string nombre;
        private string longitud;

        public Persona(string nombre)
        {
            this.nombre = nombre;
            this.longitud = nombre.Length;
        }

        public string Nombre
        {
            get => nombre;  
            set => nombre = value;  
        }

        public string Longitud
        {
            get => longitud;    
            set => longitud = value;    
        }

    }
}
