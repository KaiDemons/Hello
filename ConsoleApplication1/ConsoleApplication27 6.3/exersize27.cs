using System;

int number = 40; // задайте здесь ваше число

if (number % 2 == 0 && number % 10 == 0)
{
    Console.WriteLine("The number is an even and multiple of 10");
}
else
{
    Console.WriteLine("The number is not even and is a multiple of 10");
}

Console.ReadLine();