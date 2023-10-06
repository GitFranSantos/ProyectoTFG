namespace ejercicioColas
{
    internal class Program
    {
        static int EdadRandom()
        {
            Random num = new Random();
            return num.Next(5, 61);
        }
        static int PersonasColaRandom()
        {
            Random num = new Random();
            return num.Next(0, 51);
        }
        static void Main(string[] args)
        {
            Queue<Persona> colaPersonas = new Queue<Persona>();

            int numPersonas = PersonasColaRandom();

            int precioTotal = 0; 

            for (int i = 0; i < numPersonas; i++)
            {
                int nuevaEdad = EdadRandom();
                colaPersonas.Enqueue(new Persona(nuevaEdad));
            }
            Console.WriteLine("El numero de personas que hay en la cola es: " + colaPersonas.Count());
            while(colaPersonas.Count > 0) 
            {
                Persona personaSacada = colaPersonas.Dequeue();
                if(personaSacada.getEdad() >= 5 && personaSacada.getEdad() <= 10)
                {
                    precioTotal += 3;
                }
                if (personaSacada.getEdad() >= 11 || personaSacada.getEdad() <= 17)
                {
                    precioTotal += 5;
                }
                if (personaSacada.getEdad() >= 18)
                {
                    precioTotal += 7;
                }
            }
            Console.WriteLine("El total recaudado es: " + precioTotal);
        }
    }
}