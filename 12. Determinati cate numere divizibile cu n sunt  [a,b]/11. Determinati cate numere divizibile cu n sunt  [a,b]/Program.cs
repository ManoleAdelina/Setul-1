using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinati_cate_numere_divizibile_cu_n_sunt___a_b_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, n, count=0;
            Console.WriteLine("Introduceti valorile pentru intervalul [a,b]");
            Console.Write("a= ");
            a=int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti numarul n cu care sa se divida numerele din [{a},{b}]");
            n=int.Parse(Console.ReadLine());
            for(int i=a;i<=b;i++)
            {
                if (i % n == 0)
                    count++;
            }
            Console.WriteLine($"{count} numere sunt divizibile cu {n} din intervalul [{a},{b}]");
        }
    }
}
