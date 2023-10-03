namespace EjercicioArrays_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boleto[] arrBol = new Boleto[100];

            bool repetido;
            Boleto nuevoBoleto;

            for(int i = 0; i < arrBol.Length; i++)
            {
                do
                {
                    repetido = false;
                    nuevoBoleto = new Boleto();

                    for (int j = 0; j < arrBol.Length; j++)
                    {
                        if (nuevoBoleto.Equals(arrBol[j]))
                        {
                            repetido = true;
                        }
                    }
                } while(repetido);
                arrBol[i] = nuevoBoleto;
                Console.WriteLine(nuevoBoleto.ToString());
            }
        }
    }
}