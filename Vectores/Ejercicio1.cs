using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arrglos.Vectores
{
    internal class Ejercicio1
    {
        public int[] vectorAleatorio(int rango)
        {
            Random random = new Random();
            int[] numeros = new int[rango];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(5, 101);
            }
            return numeros;
        }
    }
}
