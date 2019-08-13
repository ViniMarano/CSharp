using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preco_Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            double litros, preco;
            const double  combustivel = 3.85;

            Console.Write("A gasolina está custando R$3.85, quantos litros deseja abastecer ? ");
            litros = Convert.ToInt32(Console.ReadLine());

            preco = combustivel * litros;


            Console.WriteLine();


            Console.WriteLine("Você irá gastar R$" + preco + " para abastecer o carro com " + litros + "L de combustível.");


               
            Console.ReadKey();
        }
    }
}
