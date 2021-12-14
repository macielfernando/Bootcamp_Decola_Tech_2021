using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencia_S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, S = 0;
            for (double num = 1; num <= 100; num++)
            {
                c = 1 / num;  
                S = S + c;
            }
            var x = Math.Round(S, 2);
            Console.WriteLine(x);

        }
    }
}
