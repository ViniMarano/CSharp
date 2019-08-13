using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressoes
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, z, t;
          
            a = 8 + 14;
            b = 5 - 2;
            c = 4 * 12;
            d = 10 / 2;
            z = Math.Pow(2, 10);
            t = a + b + c + d * z;
            

            Console.WriteLine("-------- Expressões --------");

            Console.WriteLine("Valor da Expressão A: " + a);
           
            Console.WriteLine("Valor da Expressão B: " + b);
            
            Console.WriteLine("Valor da Expressão C: " + c);
           
            Console.WriteLine("Valor da Expressão D: " + d);
            
            Console.WriteLine("Valor da Expressão Z: " + z);
            
            Console.WriteLine("Valor da Expressão T: " + t);
            
            
                                    
            Console.ReadKey();
        }
    }
}
