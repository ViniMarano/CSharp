using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regiões
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double preco;
            

            Console.WriteLine("Códigos de Origem ");
            Console.WriteLine("");
            Console.WriteLine("01 - Sul");
            Console.WriteLine("02 - Norte");
            Console.WriteLine("03 - Leste");
            Console.WriteLine("04 - Oeste");
            Console.WriteLine("05 ou 06 - Nordeste");
            Console.WriteLine("07, 08 ou 09 - Sudeste");
            Console.WriteLine("10 até 20 - Centro Oeste");
            Console.WriteLine("21 até 30 - Noroeste");
            Console.WriteLine("");

            Console.WriteLine("Informe o Código do Produto: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Preço do Produto: ");
            preco = Double.Parse(Console.ReadLine());

            if (codigo == 01)
            {
                Console.WriteLine("O Produto é da região SUL e tem o preço de R$" + preco);
            }


            else if (codigo == 02)
            {
                Console.WriteLine("O Produto é da região NORTE e tem o preço de R$" + preco);
            }


            else if (codigo == 03)
            {
                Console.WriteLine("O Produto é da região LESTE e tem o preço de R$" + preco);
            }


            else if (codigo == 04)
            {
                Console.WriteLine("O Produto é da região OESTE e tem o preço de R$" + preco);
            }


            else if (codigo == 05 | codigo == 06 )
            {
                Console.WriteLine("O Produto é da região NORDESTE e tem o preço de R$" + preco);
            }


            else if (codigo >= 07 && codigo <= 9)
            {
                Console.WriteLine("O Produto é da região SUDESTE e tem o preço de R$" + preco);
            }


            else if (codigo >= 10 && codigo <= 20)
            {
                Console.WriteLine("O Produto é da região CENTRO OESTE e tem o preço de R$" + preco);
            }


            else if (codigo > 20 && codigo < 31)
            {
                Console.WriteLine("O Produto é da região NOROESTE e tem o preço de R$" + preco);
            }


            else if (codigo >= 31)
            {
                Console.WriteLine("Região Não Encontrada. Digite Novamente.");
            }


            Console.Clear();
                                                      
            
            Console.ReadKey();
            }
    }
}
