using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLinQ8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> listaAlumnos = new List<Alumno>()
             {
             new Alumno("Eva",20,6.0),
             new Alumno("Ana",22,7.0),
             new Alumno("Rosa",22,4.0),
             new Alumno("Ot",20,3.0),
             new Alumno("Iu",30,6.8),
             new Alumno("Pep",32,5.9),
             new Alumno("Laia",30,2.3),
             new Alumno("Quim",32,1.7),
             };

            //Alumnos mayores de 30 aprobados
            List<Alumno> ejercicio1 = listaAlumnos.Where(x => x.Nota >= 5 && x.Edad >= 30).ToList();

            //Alumnos con notable
            List<Alumno> ejercicio2 = listaAlumnos.Where(x => x.Nota >= 7).ToList();

            //Lista notas double
            List<double> ejercicio3 = listaAlumnos.Select(x => x.Nota).ToList<double>();

            //Lista edades de enteros
            List<int> ejercicio4 = listaAlumnos.Select(x => x.Edad).ToList<int>();

            //Lista de nombres con mas de 25 y suspensos
            List<string> ejercicio5 = listaAlumnos.Where(x => x.Edad < 25 && x.Nota < 5).Select(x => x.Nombre).ToList<string>();

            //Hay alumnos con mas de un 8?
            Console.WriteLine(listaAlumnos.Any(x => x.Nota > 8));

            //Hay alumnos con menos de un dos
            Console.WriteLine(listaAlumnos.Any(x => x.Nota < 2));

            //La nota media
            double notaMedia = listaAlumnos.Average(x => x.Nota);
            Console.WriteLine(notaMedia);

            //Edad mas alta
            int edadMax = listaAlumnos.Max(x => x.Edad);
            Console.WriteLine(edadMax);

            //Alumno con la nota mas alta
            Alumno ejercicio10 = listaAlumnos.OrderByDescending(x => x.Nota).First();
            Console.WriteLine(ejercicio10.ToString());

            //Alumnos con menos edad
            List<Alumno> ejercicio11 = listaAlumnos.Where(x => x.Edad == listaAlumnos.Min(x => x.Edad)).ToList<Alumno>();
            foreach(Alumno a in ejercicio11)
            {
                Console.WriteLine(a.ToString());
            }
        } 
    }
}