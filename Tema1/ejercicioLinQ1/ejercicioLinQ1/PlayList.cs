using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLinQ1
{
    public class PlayList
    {

        private int numeroCanciones;
        private int indiceTipoCancion;
        private string estiloCancion;
        private int numeroTitulo = 1;
        private string tituloCancion;



        private List<Cancion> cancionesLista = new List<Cancion>();
        private EstilosMusica estilos = new EstilosMusica();
        public PlayList()
        {
            estilos.Añadir(estilos.GetNumeroElementos() + 1001, "pop");
            estilos.Añadir(estilos.GetNumeroElementos() + 1001, "rock");
            estilos.Añadir(estilos.GetNumeroElementos() + 1001, "clasico");
            estilos.Añadir(estilos.GetNumeroElementos() + 1001, "reggaeton");
            Random aleatorio = new Random();
            numeroCanciones = aleatorio.Next(10, 21);



            for (int i = 1; i <= numeroCanciones; i++)
            {
                indiceTipoCancion = aleatorio.Next(1001, estilos.GetNumeroElementos() + 1001);
                estiloCancion = estilos.Consultar(indiceTipoCancion);
                tituloCancion = "Titulo " + numeroTitulo;
                Cancion c = new Cancion(tituloCancion, estiloCancion);

                numeroTitulo++;
                cancionesLista.Add(c);
            }
        }

        public void Mostrar()
        {
            foreach (Cancion miCancion in cancionesLista)
            {
                Console.WriteLine(miCancion.ToString());
            }
        }
        public List<Cancion> DevolverLista(string estilo)
        {
            /*List<Cancion> listaDevolver = new List<Cancion>();
            foreach(Cancion miCancion in listaDevolver)
            {
                if(miCancion.TipoMusica == estilo)
                {
                    listaDevolver.Add(miCancion);
                }
            }
            return listaDevolver;*/

            //otra forma (Programacion Funcional)
            return cancionesLista.Where(x=>x.TipoMusica==estilo).ToList();
        }

        public List<Cancion> busquedaPorTitulo(string tit)
        {
            return cancionesLista.Where(titulo => titulo.TituloCancion.Contains(tit)).ToList();
        }
        public List<String> listaTitulos()
        {
            return cancionesLista.Select(titulo => titulo.TituloCancion).ToList<string>();   
        }

        public List<String> listaTitulos(string estilo)
        {
            return cancionesLista.Where(titulo => titulo.TituloCancion.Contains(estilo)).ToList().Select(titulo => titulo.TituloCancion).ToList<string>();
        }

        public bool contieneEstilo(string estilo)
        {
            return cancionesLista.Any(x => x.TipoMusica == estilo);
        }
    }
}
