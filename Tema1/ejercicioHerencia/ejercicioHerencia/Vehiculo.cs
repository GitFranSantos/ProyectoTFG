using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerencia
{
    public class Vehiculo
    {
        protected string color;
        private int personas;

        public int Ruedas { get; set; }

        public int MaxPersonas
        {
            get => personas;
            //return personas
            set => personas = value;
            //
        }
    }
}
