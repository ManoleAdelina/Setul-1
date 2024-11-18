using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisarea_unei_fractii_in_format_zecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fractie ();
        }
        private static void fractie()
        {
            int m = 13;
            int n = 30;
            double d;

            d = (double)m / n;
            Console.WriteLine(d);

            double fract = d - Math.Truncate(d);

            int maxDecimal = 6;
            while (maxDecimal > 0 && fract != 0)
            {
                // fract = 0.43
                int cifraZecimala;
                cifraZecimala = (int)Math.Truncate(fract * 10);
                Console.WriteLine($"{cifraZecimala} ");


                fract = fract * 10 - Math.Truncate(fract * 10);


                maxDecimal--;
            }
        }
    }
}
