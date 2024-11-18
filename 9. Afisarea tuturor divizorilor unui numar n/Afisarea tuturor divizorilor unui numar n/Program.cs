using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisarea_tuturor_divizorilor_unui_numar_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Divizorii numarului n sunt:");
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine($"{n}");
        }
    }
    }

