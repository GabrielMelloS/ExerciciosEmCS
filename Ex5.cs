using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Insira sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade!");
            }
            else
            {
                Console.WriteLine("Você é menor de idade!");
            }
            Console.ReadKey();
        }
    }
}
