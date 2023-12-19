using System;
using System.IO;

string filePath = "numsTask5.txt";
string[] lines = File.ReadAllLines(filePath);
int[] nums = Array.ConvertAll(lines, int.Parse);

int minIndex = 0;
int maxIndex = 0;

for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] < nums[minIndex])
        minIndex = i;

    if (nums[i] > nums[maxIndex])
        maxIndex = i;
}

int startIndex = Math.Min(minIndex, maxIndex) + 1;
int endIndex = Math.Max(minIndex, maxIndex);

int sum = 0;
int count = 0;

for (int i = startIndex; i < endIndex; i++)
{
    sum += nums[i];
    count++;
}

double average = (double)sum / count;

Console.WriteLine($"Arithmetic mean of elements between minimum and maximum: {average}");