using System;

double a, b;

Console.WriteLine("use point coordinates (a, b):");
Console.Write("a = ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
b = Convert.ToDouble(Console.ReadLine());

if (-2 <= a && a <= 2 && -3 <= b && b <= 0)
{
    Console.WriteLine("The point ({0}; {1}) belongs to the shaded area.", a, b);
}
else
{
    Console.WriteLine("The point ({0}; {1}) does not belong to the shaded area.", a, b);
}

