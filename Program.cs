using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado;

            Console.WriteLine("Favor de Ingresar Lado: ");
            lado = int.Parse(Console.ReadLine());

            Console.Write("El perimetro del poligono regular es: " + lado * 4);

            Console.ReadKey();
        }
    }
}
