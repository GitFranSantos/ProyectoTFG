using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArrays_5
{
    
    public class Boleto
    {
        private int[] arr = new int [6];
        
        public Boleto()
        {
            bool repetido;
            int nuevoNum;
            for (int i = 0; i < arr.Length; i++)
            {
                do
                {
                    repetido = false;
                    nuevoNum = devRandom();
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j] == nuevoNum)
                        {
                            repetido = true;
                        }
                    }
                } while (repetido);
                arr[i] = nuevoNum;
            }
        }

        public override bool Equals(object? obj)
        {
            bool repe;
            if (obj == null) 
            {
                return false;
            }
            else
            {
                Boleto comparado = (Boleto)obj;
                
                for (int i = 0; i < this.arr.Length; i++)
                {
                    for (int j = 0; j < comparado.getArr().Length; j++)
                    {
                        repe = false;
                        if (this.arr[i] == comparado.getArr()[j])
                        {
                            repe = true;
                        }
                        if (!repe)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        public override string ToString()
        {
            string boleto = "";
            for (int i = 0;i < arr.Length;i++) 
            {
                boleto += this.arr[i] + " ";
            }
            return boleto;  
        }

        public int[] getArr()
        {
            return arr;
        }
        private int devRandom()
        {
            Random num = new Random();
            return num.Next(1, 50);
        }
    }
}
