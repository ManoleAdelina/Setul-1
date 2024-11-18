int n, d,divizor=0;

Console.Write("Introduceti un numar: ");
n=int.Parse(Console.ReadLine());

if (n == 0 || n == 1)
    Console.WriteLine("Numarul introdus nu este prim");
else if (n == 2 || n == 3)
    Console.WriteLine("Numarul introdus este prim.");
else 
{
    for (d = 2; d * d < n; d++)
        if (n % d == 0)
            divizor++;
    if(divizor==0)
        Console.WriteLine("Numarul introdus este prim.");
    else Console.WriteLine("Numarul introdus nu este prim");
}