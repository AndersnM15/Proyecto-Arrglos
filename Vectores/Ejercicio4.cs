using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arrglos.Vectores
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];

            Array.Sort(vector);


            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = i;
                Console.WriteLine(vector[i]);
            }
        }
    }
}
