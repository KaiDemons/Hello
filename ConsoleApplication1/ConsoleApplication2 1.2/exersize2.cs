using System;
using System.Collections.Generic;

List<int> nums = new List<int>();
            
Console.WriteLine("Enter the numbers(Enter 0 for pause):");
while (true)
{
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == 0)
        break;
    nums.Add(input);
}

int sum = 0, product = 1, arithmean;
foreach (int num in nums)
{
    sum += num;
    product *= num;
}
arithmean = sum / nums.Count;
            
Console.WriteLine($"The sum of numbers: {sum}, the product of numbers: {product}, the arithmetic mean: {arithmean}");