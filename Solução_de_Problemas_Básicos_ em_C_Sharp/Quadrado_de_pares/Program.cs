using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado_de_Pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                if (x % 2 == 0)
                {
                    double resultado = Math.Pow(x, 2);
                    Console.WriteLine($"{x}^2 = {resultado}");


                }

            }
        }
    }
}
