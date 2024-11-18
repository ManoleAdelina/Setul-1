using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extragem_a_k_a_cifra_de_la_sfarsitul_unui_numar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar: ");
            int numar= int.Parse(Console.ReadLine());

            Console.Write("Introduceti valoarea lui k (cifra dorita de la sfarsit): ");
            int k= int.Parse(Console.ReadLine());

            for (int i = 1; i < k; i++)
            {
                numar = numar / 10;
            }
            int cifraDorita = numar % 10;
            Console.WriteLine($"Cifra dorita este {cifraDorita}.");
        }
    }
}
