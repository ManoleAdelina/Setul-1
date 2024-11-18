using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Ordonarea_a_3_numere_in_mod_crescator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numar1, numar2, numar3;
            Console.Write("Introduceti primul numar: ");
            numar1=int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar: ");
            numar2 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al treilea numar: ");
            numar3 = int.Parse(Console.ReadLine());

            int primul, alDoilea, alTreilea;
            primul = Math.Min(numar1, numar2);
            primul= Math.Min(primul, numar3);
            alTreilea = Math.Max(numar1, numar2);
            alTreilea=Math.Max(alTreilea, numar3);
            alDoilea = numar1 + numar2 + numar3 - primul - alTreilea;

            Console.WriteLine($"Ordinea crescatoarea a numerelor este {primul}, {alDoilea}, {alTreilea}");
        }
    }
}
