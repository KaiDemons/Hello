using System;
using System.IO;

int[] nums = Array.ConvertAll(File.ReadAllText("numsTask1.txt").Split(), int.Parse);
int minIndex = 0;
for (int i = 1; i < nums.Length; i++) {
    if (nums[i] < nums[minIndex]) {
        minIndex = i;
    }
}

long result = 1;
for (int i = minIndex + 1; i < nums.Length; i++)
{
    result *= nums[i];
}

Console.WriteLine("Production of numbers after the minimum: " + result);