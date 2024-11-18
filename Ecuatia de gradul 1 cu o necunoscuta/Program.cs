float a, b, x;
Console.Write("a= ");
a = float.Parse(Console.ReadLine());
Console.Write("b= ");
b = float.Parse(Console.ReadLine());

Console.WriteLine($"Ecuatia ta este {a}x + {b} = 0");

if ((a == 0) && (b == 0))
    Console.WriteLine("Idenititate");
else if ((a == 0) && (b != 0))
    Console.WriteLine("Imposibil");
else if ((a != 0) && (b == 0))
    Console.WriteLine($"Radacina ecuatiei tale este 0");
else if ((a != 0) && (b != 0))
{
    x = -b / a;
    Console.WriteLine($"Radacina ecuatiei tale este {x}");
}