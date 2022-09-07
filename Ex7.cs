using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomea, nomeb;

            Console.WriteLine("Insira um nome: ");
            nomea = (Console.ReadLine());

            Console.WriteLine("Insira outro nome: ");
            nomeb = (Console.ReadLine());

            Console.WriteLine(nomea.ToUpper());
            Console.WriteLine(nomeb.ToUpper());
            Console.WriteLine(nomea.Substring(0,3));
            Console.WriteLine(nomeb.Substring(0,3));
            Console.ReadKey();
        }
    
    }
}
