using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colores =
                new List<string>();
            colores.Add("rojo");
            colores.Add("verde");
            colores.Add("azul");
            colores.Add("negro");
            colores.Add("blanco");

            colores.RemoveAt(1);
            colores.Remove("azul");

            Console.WriteLine("Numero de elementos: " + colores.Count);
            int indiceColor = 1;

            foreach(string color in colores)
            {
                Console.WriteLine("Elemento " + indiceColor.ToString() + ": " + color);
                indiceColor++;
            }

            Console.Read();
        }
    }
}
