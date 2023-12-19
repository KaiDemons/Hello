using System;

int divisor; 
int sum = 0;

do
{
    Console.Write("Enter a positive number (enter a negative number to complete): ");
    divisor = Convert.ToInt32(Console.ReadLine());
    
    if (divisor > 0)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % divisor == 0)
        {
            sum += number;
        }
    }
} while (divisor > 0);


Console.WriteLine("The sum of the numbers divisible by a positive number entirely: " + sum);
Console.ReadLine();