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
            int num;

            Console.WriteLine("Insira um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("O quadrado de {0} é {1} ", num, Math.Pow(num, 2));
            Console.ReadKey();
        }
    }
}
