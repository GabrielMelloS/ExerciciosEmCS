using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int W, X, Y, Z;

            Console.WriteLine("Insira W: ");
            W = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira X: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira Y: ");
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira Z: ");
            Z = int.Parse(Console.ReadLine());
            Console.WriteLine("Número A: {0}", (((X >= Y) && (Z <=X)) || ((X == W) && (Y == Z)) || (!(X != W))));
            

        }
    }
}
