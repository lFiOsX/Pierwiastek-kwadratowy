﻿
using Pierwiastek_kwadratowy;


QuadraticEquation qe = new QuadraticEquation();


Console.WriteLine("\t\tOBLICZANIE MIEJSC ZEROWYCH PIERWIASTKA KWADRATOWEGO\t\t\n\n");

Console.WriteLine("Wzór: ax^2 + bx + c = 0\n");
Console.WriteLine("Podaj \"a\":");
qe.a = int.Parse(Console.ReadLine());


// Współczynnik a nie może równać się zero, gdy sie równa to powtórz.
while (qe.a == 0)
{
    Console.WriteLine("Współczynnik \"a\" nie może być równy 0");
    Console.WriteLine("Podaj wartość \"a\" ponownie:");
    qe.a = int.Parse(Console.ReadLine());
}


Console.WriteLine("Podaj \"b\":");
qe.b = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj \"c\":");
qe.c = int.Parse(Console.ReadLine());

Console.WriteLine("\n");



// obliczenie i zaprezentowanie wyników
qe.calcDeltaZeros(qe.a, qe.b, qe.c);