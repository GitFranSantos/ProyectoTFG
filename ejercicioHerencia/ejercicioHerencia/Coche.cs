using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerencia
{
    public class Coche : Vehiculo //coche hereda de vehiculo
    {
        private int velocidad;
        private int cilindrada;

        public int Cubicaje 
        {  
            get => cilindrada; 
            set => cilindrada = value; 
        }

        public void setVelicidad(int velocidad)
        {
            this.velocidad = velocidad;
        }

        public int getVelocidad()
        {
            return this.velocidad;
        }
    }
}
