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
            int numero1, numero2, aux;

            Console.WriteLine("Insira um número inteiro: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro número: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Número A: "+numero1+ " Número B: "+numero2);
            aux=numero1;
            numero1=numero2;
            numero2=aux;
            Console.WriteLine("Novo número A: "+numero1+ " Novo número B: "+numero2);

        }
    }
}
