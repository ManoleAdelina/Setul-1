int a, b;
Console.Write("a= ");
a = int.Parse(Console.ReadLine());
Console.Write("b= ");
b = int.Parse(Console.ReadLine());
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine($"Acum a este {a} si b este {b}.");
