using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencia_iJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i += 2)
            {
                for (int I = i, j = 7; j >= 5; j -= 1)    //escreva seu código nos espaços em branco
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }
        }
    }
}
