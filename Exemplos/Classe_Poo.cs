using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            // FORMA 01

                Carro carro;
                carro = new Carro();

            // FORMA 02

                Carro carroDois = new Carro();
            
            // TRABALHANDO COM PROPRIEDADES
                Console.WriteLine("Marca: " + carro.Marca);

                carro.Marca = "Ford";
                Console.WriteLine("Marca: " + carro.Marca);

            // TRABALHANDO COM MÉTODOS

                Console.WriteLine("Luzes Internas: " + carro.LuzesInternas);
                carro.abrirPortas();
                Console.WriteLine("Quando Abrir as Portas: " + carro.LuzesInternas);
                carro.fecharPortas();
                Console.WriteLine("Quando Fechar as Portas: " + carro.LuzesInternas);


                string statusFarol = carro.acenderFarolAutomaticamente();
                Console.WriteLine("Status do Farol: " + statusFarol);




            Console.ReadKey();
        }
    }
}
