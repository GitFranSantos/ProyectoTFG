namespace ejercicioPilas
{
    internal class Program
    {
        static int CodigoRandom()
        {
            Random num = new Random();
            return num.Next(1, 10);
        }

        static int IndiceRandom()
        {
            Random num = new Random();  
            return num.Next(0, 3);
        }
        static void Main(string[] args)
        {
            Stack<Informe> pilaInformes = new Stack<Informe>();

            for (int i = 0; i < 10; i++) 
            {
                int nuevoCodigo = CodigoRandom();
                int nuevoIndice = IndiceRandom();

                pilaInformes.Push(new Informe(nuevoCodigo, nuevoIndice));
            }

            Console.WriteLine("");

            for (int i = 0; i < 3; i++)
            {
                Informe informeSacado = pilaInformes.Pop();
                Console.WriteLine(informeSacado.ToString());
            }

            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                int nuevoCodigo = CodigoRandom();
                int nuevoIndice = IndiceRandom();

                pilaInformes.Push(new Informe(nuevoCodigo, nuevoIndice));
            }

            Console.WriteLine("");

            while (pilaInformes.Count > 0)
            {
                Informe informeSacado = pilaInformes.Pop();
                Console.WriteLine(informeSacado.ToString());
            }
        }
    }
}