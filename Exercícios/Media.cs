using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome; 
            int notaUm, notaDois, notaTres, notaQuatro, media;

            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite a primeira nota: ");
            notaUm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite a segunda nota: ");
            notaDois = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite a terceira nota: ");
            notaTres = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite a quarta nota: ");
            notaQuatro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            media = (notaUm + notaDois + notaTres + notaQuatro) / 4;

            Console.WriteLine();

            Console.WriteLine("O aluno(a) " + nome + ", teve média: " + media);


            

          Console.ReadKey();     
        }
    }
}
