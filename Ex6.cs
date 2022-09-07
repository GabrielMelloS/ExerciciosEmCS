using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double reais, cotacao;

            Console.WriteLine("Insira o valor em Reais: ");
            reais = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da Cotação do Dólar: ");
            cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor em Dólares é: " + reais * cotacao);
            Console.ReadKey();
        }
    }
}
