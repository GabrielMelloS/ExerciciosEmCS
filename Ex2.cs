using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Insira um número inteiro: ");
            num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("O dobro de {0} é {1}", num, num * 2);
            Console.ReadKey();

        }
    }
}
