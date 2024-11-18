using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Un_numar_se_imparte_la_k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, k;
            Console.WriteLine("Numarul este: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Numarul la care a se divida este: ");
            k = int.Parse(Console.ReadLine());
            if (a % k == 0)
                Console.WriteLine($"Numarul se divide la {k}.");
            else
                Console.WriteLine($"Numarul nu se divide la {k}.");
        }
    }
}
