
using Spr_pierw_kwadrat;

int a, b, c = 0;

QuadraticEquation qe = new QuadraticEquation();

Console.WriteLine("Podaj \"a\":");
a = int.Parse(Console.ReadLine());

while (a == 0)
{
    Console.WriteLine("Współczynnik \"a\" nie może być równy 0");
    Console.WriteLine("Podaj wartość \"a\" ponownie:");
    a = int.Parse(Console.ReadLine());
}


Console.WriteLine("Podaj \"b\":");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj \"c\":");
c = int.Parse(Console.ReadLine());

Console.WriteLine("\n");
qe.calculationOfDeltaZeros(a, b, c);
