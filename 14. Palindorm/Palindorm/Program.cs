
int numar, oglindit,copie;
Console.WriteLine("Numarul este:");
numar=int.Parse(Console.ReadLine());
oglindit = 0;
copie = numar;
while(numar!=0)
{
    oglindit = oglindit * 10 + numar % 10;
    numar /= 10;

}
if (oglindit == copie)
    Console.WriteLine("Numarul este palindrom.");
else Console.WriteLine("Numarul nu este palindrom.");