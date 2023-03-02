using Proyecto_Arrglos.Vectores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Arrglos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ejercicio2 e2 = new Ejercicio2();
            e2.OrdenarCadena();
        }
    }

}
