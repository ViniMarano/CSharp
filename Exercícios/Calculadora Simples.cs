using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("-----------------------");
            Console.Write("Calculadora Simples");
            Console.Write("-----------------------");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Digite o Primeiro Valor: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Segundo Valor: ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();

            Console.WriteLine("A soma dos valores é igual a " + (a + b));
            Console.WriteLine("A subtração dos valores é igual a " + (a - b));
            Console.WriteLine("A multiplicação dos valores é igual a " + (a * b));
            Console.WriteLine("A divisão dos valores é igual a " + (a / b));


                                                                                                       
            Console.ReadKey();
        }
    }
}
