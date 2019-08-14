using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Carro
    {
        // PROPRIEDADES OU CARACTERÍSTICAS

        public string Marca = "Fiat";
        public int AnoModelo;
        public bool LuzesInternas = false;



        // MÉTODOS OU AÇÕES
        public void abrirPortas()

        {
            // IMAGINE QUE O ALGUÉM IRÁ ABRIR A PORTA
            // DO CARRO E AS LUZES VÃO ACENDER.  
            LuzesInternas = true;
        }

        public void fecharPortas()

        {
            // IMAGINE QUE O PASSAGEIRO FECHOU A PORTA
            // DO CARRO E AS LUZES VÃO APAGAR.
            LuzesInternas = false;
        }

        /* ESSE MÉTODO IRÁ RETORNAR UMA INFORMAÇÃO PARA O USUÁRIO
         * NESTE EXEMPLO, VAMOS IMAGINAR QUE ELE IRÁ LIGAR OS FAROIS
         * MAS EU PRECISO SABER QUAL A INTENSIDADE. */

        public string acenderFarolAutomaticamente()

        {
            return "Médio";

        }



        }
}
