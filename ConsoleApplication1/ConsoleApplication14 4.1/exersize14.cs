using System;

{
    Console.Write("Enter number n: ");
    int n = int.Parse(Console.ReadLine());

    long product = CalculateProduct(n);
    Console.WriteLine("The product of natural numbers that are multiples of three and do not exceed {0}: {1}", n, product);
}

static long CalculateProduct(int n) 
{
        long product = 1; 
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                product *= i;
            }
        }
        return product;
        
}
