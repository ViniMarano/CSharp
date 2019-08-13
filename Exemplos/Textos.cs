using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textos
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Olá amigos, estou muito feliz por estar aqui com cada um de vocês ! Desejo a todos um ótimo dia. ";
            String palavra = "um";


            // VERIFICANDO O TAMANHO DO TEXTO
                Console.WriteLine("Tamanho do texto: " + texto.Length);
                Console.WriteLine("------------------------------------------");


            // LOCALIZANDO UMA PALAVRA
                Console.WriteLine("Localizando: " + texto.IndexOf(palavra));
                Console.WriteLine("------------------------------------------");
            
            
            // LOCALIZANDO A POSIÇÃO DA ÚLTIMA LETRA
                Console.WriteLine("Localizando: " + texto.LastIndexOf(palavra));
                Console.WriteLine("------------------------------------------");


                String textoDois = "Olá amigos do Adrianinho ! ";
                Console.WriteLine(textoDois);

                String textoAlterado = textoDois.Replace("Adrianinho", "Zézinho");
                Console.WriteLine("------------------------------------------");


                Console.WriteLine(textoAlterado);
                Console.WriteLine(textoDois);
                Console.WriteLine("------------------------------------------");


                String textoTres = "Olá Turma ! Bom dia !";
                Console.WriteLine("Verifica se começa com: " + textoTres.StartsWith("Olá"));
                Console.WriteLine("Verifica se termina com:  " + textoTres.EndsWith("dia !"));
                Console.WriteLine("Verifica existência: " + textoTres.Contains("Turma"));
                Console.WriteLine("------------------------------------------");


                String textoQuatro = "Olá Galerinha de TI... Bom dia para todos. ";
                Console.WriteLine(textoQuatro.ToUpper());
                Console.WriteLine(textoQuatro.ToLower());
                Console.WriteLine("------------------------------------------");


                String textoEspaco = "                         Bom dia Turma MU ! ";

            //REMOVENDO O ESPAÇO EM BRANCO DO COMEÇO
                Console.WriteLine("Início: " + textoEspaco.TrimStart());
                Console.WriteLine("Início: " + textoEspaco.TrimStart().Length);
                Console.WriteLine("------------------------------------------");


            //REMOVENDO O ESPAÇO EM BRANCO DO FINAL
                Console.WriteLine("Início: " + textoEspaco.TrimEnd());
                Console.WriteLine("Início: " + textoEspaco.TrimEnd().Length);
                Console.WriteLine("------------------------------------------");

            //REMOVENDO O ESPAÇO EM BRANCO DOS DOIS LADOS
                Console.WriteLine("Início: " + textoEspaco.Trim());
                Console.WriteLine("Início: " + textoEspaco.Trim().Length);
                Console.WriteLine("------------------------------------------");


                String textoCinco = "Olá a todos ! Desejo um ótimo dia !";

                String frase = textoCinco.Substring(13);
                String palavra1 = textoCinco.Substring(13, 7);

                Console.WriteLine("2º frase: " + frase);
                Console.WriteLine("Palavra: " + palavra1);

            Console.ReadKey();
        }
    }
}
