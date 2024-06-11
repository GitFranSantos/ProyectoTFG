using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6._1
{
    public class Pais
    {
        public string CodigoPais {set; get;}
        public string Nombre { set; get;}
        public string Continente { set; get;}
        public decimal SurfaceArea { set; get;}
        public int Poblacion {  set; get;}  
        public decimal LifeExpecting { set; get;}

        public Pais(string c, string n, string con, decimal a, int pob, decimal lifeExpecting)
        {
            this.CodigoPais = c;
            this.Nombre = n;
            this.Continente = con;
            this.SurfaceArea = a;
            this.Poblacion = pob;
            this.LifeExpecting = lifeExpecting;
        }

        public override string ToString()
        {
            return $"{CodigoPais}  {Nombre}";
        }
    }
}
