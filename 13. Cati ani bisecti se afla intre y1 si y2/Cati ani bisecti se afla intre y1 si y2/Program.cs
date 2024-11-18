using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cati_ani_bisecti_se_afla_intre_y1_si_y2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y1, y2, count=0;
            Console.WriteLine("Introduceti intervalul de ani [y1,y2],");
            Console.Write("y1= ");
            y1=int.Parse(Console.ReadLine());
            Console.Write("y2= ");
            y2 =int.Parse(Console.ReadLine());
            for(int i=y1;i<=y2;i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                    count++;
            }
            Console.WriteLine($"In intervalul de ani [{y1},{y2}] se afle {count} de ani bisecti.");
        }
    }
}
