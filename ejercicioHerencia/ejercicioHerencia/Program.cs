namespace ejercicioHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            Random num2 = new Random();

            /*int[] ar = new int [20];
            

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i]= DevolverRandom(num);
                Console.Write(ar[i]+ " ");

                for (int j = 0;j <= ar[i] - 1; j++)
                {
                    string cad = "";
                    cad += "*";
                    Console.Write(cad);
                }
                Console.WriteLine();
            }*/

            int cont = 0; 
            
            int[] arr = new int[100];

            for (int i = 0;i <= arr.Length;i++)
            {
                arr[i] = DevRandom(num2);

                Console.WriteLine(arr[i]);
            }

        }

        public static int DevolverRandom(Random num)
        {
            return num.Next(1, 51);
        }

        public static int DevRandom(Random num2)
        {
            return num2.Next(1, 11);
        }
    }
}