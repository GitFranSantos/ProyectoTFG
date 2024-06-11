namespace ejercicioLinQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PlayList miPlayList = new PlayList();

            miPlayList.Mostrar();
            Console.WriteLine("");


            foreach (Cancion c in miPlayList.busquedaPorTitulo("6"))
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("");

            foreach(Cancion c in miPlayList.DevolverLista("rock"))
            {
                Console.WriteLine(c.ToString());
            }

            miPlayList.listaTitulos("rock").ToString();

            miPlayList.contieneEstilo("pop");

            miPlayList.listaTitulos();





        }
    }
}