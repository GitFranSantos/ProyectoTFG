using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLinQ1
{
    public class Cancion
    {
        public string TituloCancion { get; set; }
        public string TipoMusica { get; set; }
        public Cancion(string tituloCancion, string tipoMusica)
        {
            this.TituloCancion = tituloCancion;
            this.TipoMusica = tipoMusica;
        }
        public override string ToString()
        {
            string resultado = "La Cancion " + this.TituloCancion + " es musica " + this.TipoMusica;
            return resultado;
        }
    }
}
