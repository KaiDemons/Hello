using System;

double a, b;

Console.WriteLine("Введите координаты точки (a, b):");
Console.Write("a = ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
b = Convert.ToDouble(Console.ReadLine());

// Проверка принадлежности точки заштрихованной области
if (-2 <= a && a <= 2 && -3 <= b && b <= 0)
{
    Console.WriteLine("Точка ({0}; {1}) принадлежит заштрихованной области.", a, b);
}
else
{
    Console.WriteLine("Точка ({0}; {1}) не принадлежит заштрихованной области.", a, b);
}

