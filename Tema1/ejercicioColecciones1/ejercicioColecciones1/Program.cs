using System.Collections;

namespace ejercicioColecciones1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nueNom = "";

            ArrayList nombres = new ArrayList();
            ArrayList longitudes = new ArrayList();

            do
            {
                Console.WriteLine("Dame un nombre");
                nueNom = Console.ReadLine(); 

                if(nueNom != "fin")
                {
                    nombres.Add(nueNom);
                    longitudes.Add(nueNom.Length);
                }
                
            } while (nueNom != "fin");

            foreach (string nom in nombres)
            {
                Console.WriteLine(nom + " " + nom.Length);
            }
        }
    }
}