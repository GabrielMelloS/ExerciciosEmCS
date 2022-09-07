using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double resultado;

            Console.WriteLine("Insira o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de C: ");
            c = int.Parse(Console.ReadLine());

            resultado = Math.Pow(a, 2) * 5 - c / (b - a % 4);

            Console.WriteLine("O resultado da equação A² * 5 –C / (B –A % 4) é: " + resultado);
            Console.ReadKey();
        }
    }
}
