
// 1,2,1 = 0
// 1,1,-6 = 25
// 1,0,1 =  -4


using Spr_pierw_kwadrat;

int a, b, c = 0;

QuadraticEquation qe = new QuadraticEquation();

Console.WriteLine("\t\tOBLICZANIE MIEJSC ZEROWYCH PIERWIASTKA KWADRATOWEGO\t\t\n\n");

Console.WriteLine("Wzór: ax^2 + bx + c = 0\n");
Console.WriteLine("Podaj \"a\":");
a = int.Parse(Console.ReadLine());

// Współczynnik a nie może równać się zero, gdy sie równa to powtórz.
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



// obliczenie i zaprezentowanie wyników
qe.calcDeltaZeros(a, b, c);