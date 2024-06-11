namespace ejercicioColecciones4
{
    internal class Program
    {
        static double PrecioRandom()
        {
            Random num = new Random();
            double r = num.Next(1000, 50000);
            double s = r / 1000;
            return s;
        }
        static int LongitudCola()
        {
            Random num1 = new Random();
            return num1.Next(1, 9);
        }

        static int CantidadRandom()
        {
            Random num2 = new Random();
            return num2.Next(1, 11);
        }


        static void Main(string[] args)
        {
            Queue<Producto> listaProductos = new Queue<Producto>();

            int cont = 0;   

            int numProductos = LongitudCola();
            
            double precioFinal = 0;

            Console.WriteLine("**********Cantidad******Precio******Total");
            for(int i = 0; i < numProductos; i++)
            {
                int nuevaCantidad = CantidadRandom();
                double nuevoPrecio = PrecioRandom();
                listaProductos.Enqueue(new Producto(nuevaCantidad, nuevoPrecio));
            }

            while(listaProductos.Count > 0)
            {
                Producto productoSacado = listaProductos.Dequeue();
                Console.WriteLine("Producto" + cont + "     " + productoSacado.getCantidad() + "        " + productoSacado.getPrecio() + "      " + productoSacado.precioFinal());
                cont++;
                precioFinal += productoSacado.precioFinal();
            }
            Console.WriteLine("Precio Final:                     " + precioFinal);
        }
    }
}