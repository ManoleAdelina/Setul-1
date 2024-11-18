using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace An_bisect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Anul este: ");
            y=int.Parse(Console.ReadLine());
            if (((y % 4) == 0 && (y % 100) != 0) || (y % 400) == 0)
                Console.WriteLine("E an bisect");
            else
                Console.WriteLine("Nu e an bisect");

                    
        }
    }
}
