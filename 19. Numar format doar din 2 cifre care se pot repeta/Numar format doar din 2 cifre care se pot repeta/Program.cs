using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numar_format_doar_din_2_cifre_care_se_pot_repeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, numarCifre = 1;
            Console.Write("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            int cifra1 = n % 10;
            int cifra2 = cifra1;

            int copie = n;
            copie /= 10;
            while (copie != 0)
            {
                
                if((copie%10)!=cifra1 && (copie%10)!=cifra2)
                {
                    numarCifre++;
                    cifra2 = copie % 10;
                }
                copie /= 10;
                
            }
            if (numarCifre != 2)
                Console.WriteLine($"Numarul {n} nu este format doar din doua cifre.");
            else Console.WriteLine($"Numarul {n} este format doar din doua cifre, si anume {cifra1} si {cifra2}.");
        }
}
}
