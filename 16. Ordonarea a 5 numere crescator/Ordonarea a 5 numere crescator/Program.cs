using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordonarea_a_5_numere_crescator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numar1, numar2, numar3, numar4, numar5;
            Console.WriteLine("Numar1: ");
            numar1=int.Parse(Console.ReadLine());
            Console.WriteLine("Numar2: ");
            numar2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numar3: ");
            numar3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numar4: ");
            numar4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numar5: ");
            numar5 = int.Parse(Console.ReadLine());
            int primul, alDoilea, alTreilea, alPatrulea, alCincilea;
           
            primul = numar1;

            if (numar2 < primul)
                primul = numar2;
            if(numar3<primul)
                primul = numar3;
            if (numar4 < primul)
                primul = numar4;
            if (numar5 < primul)
                primul = numar5;

            alDoilea = int.MaxValue;
            if (numar1 > primul && numar1 < alDoilea)
                alDoilea = numar1;
            if (numar2 > primul && numar2 < alDoilea)
                alDoilea = numar2;
            if (numar3 > primul && numar3 < alDoilea)
                alDoilea = numar3;
            if (numar4 > primul && numar4 < alDoilea)
                alDoilea = numar4;
            if (numar5 > primul && numar5 < alDoilea)
                alDoilea = numar5;
            
            alTreilea = int.MaxValue;
            if (numar1 > alDoilea && numar1 < alTreilea)
                alTreilea = numar1;
            if (numar2 > alDoilea && numar2 < alTreilea)
                alTreilea = numar2;
            if (numar3 > alDoilea && numar3 < alTreilea)
                alTreilea = numar3;
            if (numar4 > alDoilea && numar4 < alTreilea)
                alTreilea = numar4;
            if (numar5 > alDoilea && numar5 < alTreilea)
                alTreilea = numar5;

            alPatrulea = int.MaxValue;
            if (numar1 > alTreilea && numar1 < alPatrulea)
                alPatrulea = numar1;
            if (numar2 > alTreilea && numar2 < alPatrulea)
                alPatrulea = numar2;
            if (numar3 > alTreilea && numar3 < alPatrulea)
                alPatrulea = numar3;
            if (numar4 > alTreilea && numar4 < alPatrulea)
                alPatrulea = numar4;
            if (numar5 > alTreilea && numar5 < alPatrulea)
                alPatrulea = numar1;

            alCincilea = int.MaxValue;
            if (numar1 > alPatrulea)//nu mai are sens sa fie mai mic ca el insusi
                alCincilea = numar1;
            if (numar2 > alPatrulea)
                alCincilea = numar2;
            if (numar3 > alPatrulea)
                alCincilea = numar3;
            if (numar4 > alPatrulea)
                alCincilea = numar4;
            if (numar5 > alPatrulea)
                alCincilea = numar5;

            Console.WriteLine($"Ordinea crescatoarea este {primul},{alDoilea},{alTreilea},{alPatrulea},{alCincilea}. ");





        }
    }
}
