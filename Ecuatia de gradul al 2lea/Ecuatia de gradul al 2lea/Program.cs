using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuatia_de_gradul_al_2lea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, x1, x2, d;

            Console.Write("a= ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c= ");
            c = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                if ((b == 0) && (c != 0))
                    Console.WriteLine("Imposibil.");
                else if ((b != 0) && (c == 0))
                    Console.WriteLine("Exista o singura radacina 0.");
                else
                {
                    x1 = -c / b;
                    Console.WriteLine($"Exista o singura radacina {x1}.");
                }
            }
            else if ((a == 0) && (b == 0) && (c == 0))
                Console.WriteLine("Identitate.");
            else
            {
                d = b * b - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine("Radacinile sunt complexe");
                }
                else if (d == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    Console.WriteLine($"Exista o singura radacina reala {x1}.");
                }
                else
                {
                    x1 = (float)((-b - Math.Sqrt(d)) / (2 * a));
                    x2 = (float)((-b + Math.Sqrt(d)) / (2 * a));
                    Console.WriteLine($"Radacinile reale ale ecuatiei sunt {x1}, {x2}.");
                }
            }


        }
    }
}
