using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrle_Estrutural
{
    class Program
    {
        static void Main(string[] args)
        {
            int palpite = 0;
            Random random = new Random();
            int numeroSecreto = random.Next(1,16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int contadorTentativas = 0;

                 while (tentativasRestantes > 0 && !numeroEncontrado)
                 {
                    Console.Write("Digite o seu Palpite: ");
                    palpite = Convert.ToInt32(Console.ReadLine());

                    contadorTentativas++;
                    tentativasRestantes--;


                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número Encontrado em {0} tentativas !", contadorTentativas);
                    Console.BackgroundColor = corAnterior;
                }

                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor, tente novamente...");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }

                else
                {
                    Console.WriteLine("Maior, tente novamente...");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }


                }
                    Console.ReadKey();
        }
    }
}
