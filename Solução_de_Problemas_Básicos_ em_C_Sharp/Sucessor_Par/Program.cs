using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_SucessorPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());


            if (x % 2 == 0)
            {
                x = x + 2;
                Console.WriteLine(x);

            }
            else
            {
                x = x + 1;
                Console.WriteLine(x);

            }      
        }
    }
}
