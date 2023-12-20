using System;

double a = 2.12;
double b = 3.12;

bool isInRegion = false;

if (b == 4 && a >= -1 && a <= 3)
{
    isInRegion = true;
}

if (b == -2 && a >= -1 && a <= 3)
{
    isInRegion = true;
}

if (a == -1 && b >= -2 && b <= 4)
{
    isInRegion = true;
}

if (a == 3 && b >= -2 && b <= 4)
{
    isInRegion = true;
}

if (a > -1 && a < 3 && b > -2 && b < 4)
{
    isInRegion = true;
}

if (isInRegion)
{
    Console.WriteLine("The point belongs to the shaded area.");
}
else
{
    Console.WriteLine("The point does not belong to the shaded area.");
}