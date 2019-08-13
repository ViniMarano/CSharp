using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int numUm, numDois;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o primeiro número: ");
            numUm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numDois = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("O nome informado foi: " + nome);
            Console.WriteLine("O resultado da operação é de: " + (numUm + numDois));
            Console.WriteLine("Resultado da soma, " + numUm + " + " + numDois + ", é de: " + (numUm + numDois));








            Console.ReadKey();
        }
    }
}
