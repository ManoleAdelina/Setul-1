using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cautare_binara__numar_intre_1_si_1024_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int st = 1, dr = 1024,mij;
            string raspuns;
            Console.WriteLine("Voi incerca sa ghicesc la ce numarul din intervalul 1 is 1024 te gandesti tu. Raspunde la intrebari cu da sau nu.");
            while(st<=dr)
            {
                mij = (st + dr) / 2;
                Console.WriteLine($"Numarul tau este {mij}?");
                raspuns= Console.ReadLine();
                if (raspuns == "nu")
                {
                    Console.WriteLine($"Numarul tau este mai mare decat {mij}?");
                    raspuns = Console.ReadLine();
                    if (raspuns == "da")
                        st = mij + 1;
                    else dr = mij - 1;

                }
                else
                {
                    Console.WriteLine("Ti-am gasit numarul!");
                    st = dr + 1;
                }
            }
        }
    }
}
