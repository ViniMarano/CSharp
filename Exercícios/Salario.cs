using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeProf;
            double QntdHoras, ValorHora;


            Console.Write("Digite o nome do Professor: ");
            nomeProf = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite a quantidade de horas trabalhadas por dia: ");
            QntdHoras = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite o valor da hora aula: ");
            ValorHora = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("O professor " + nomeProf + ", Recebe R$ " + (QntdHoras * ValorHora) + " por dia");

            
                                
           
            Console.ReadKey();
        }
    }
}
