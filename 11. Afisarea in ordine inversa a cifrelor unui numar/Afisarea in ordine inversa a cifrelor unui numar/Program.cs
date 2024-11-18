using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisarea_in_ordine_inversa_a_cifrelor_unui_numar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti un numar: ");
            n=int.Parse(Console.ReadLine());
            while(n>0)
            {
                Console.Write(n % 10);
                n /= 10;
            }
        }
    }
}
