using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cmmdc_si_cmmmc_cu_algoritmul_lui_Euclid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Introduceti doua numere pentru a afla cel mai mare divizor comun respectiv cel mai mic multiplu comun al lor.");
            Console.Write("n= ");
            n=int.Parse(Console.ReadLine());
            Console.Write("m= ");
            m =int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Cel mai mare divizor comun dintre {n} si {m} este {Cel_mai_mare_divizor_comun(n, m)}.");
            
            Console.WriteLine($"Cel mai mic multiplu comun dintre {n} si {m} este {Cel_mai_mic_multiplu_comun(n, m)}.");

        }

        static int Cel_mai_mare_divizor_comun(int n, int m )
        {
            int r;
            while(m>0)
            {
                r = n % m;
                n = m;
                m = r;

            }
            return n;
        }
        static int Cel_mai_mic_multiplu_comun(int a, int b)
        {
            int c, d;
            c = a;
            d = b;
            while (c != d)
            {
                if (c < d)
                    c = c + a;
                if (d < c)
                    d = d + b;

            }
            return c;
        }
    }
}
