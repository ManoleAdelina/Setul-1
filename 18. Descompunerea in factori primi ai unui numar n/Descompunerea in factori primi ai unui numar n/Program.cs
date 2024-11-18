using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descompunerea_in_factori_primi_ai_unui_numar_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, putere = 0; ;
            Console.Write("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        putere++;
                        n /= i;

                    }
                    Console.Write($"{i}^{putere} * ");
                }
                putere = 0;
            }
        }
    }
}
