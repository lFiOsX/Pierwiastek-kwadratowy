int a, b, c = 0;

a = int.Parse(Console.ReadLine());

while (a == 0)
{
    Console.WriteLine("Współczynnik \"a\" nie może być równy 0");
    Console.WriteLine("Podaj wartość \"a\" ponownie:");
    a = int.Parse(Console.ReadLine());
}

b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

Console.WriteLine("\n");