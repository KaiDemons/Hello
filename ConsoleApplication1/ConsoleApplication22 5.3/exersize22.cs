using System;
using System.IO;

int[] nums = Array.ConvertAll(File.ReadAllText("numsTask3.txt").Split(), int.Parse);
int minIndex = 0;
for (int i = 1; i < nums.Length; i++) {
    if (nums[i] < nums[minIndex]) {
        minIndex = i;
    }
}

double sum = 0;
for (int i = 0; i < minIndex; i++) {
    sum += nums[i];
}

double average = sum / minIndex;

Console.WriteLine("Arithmetic mean of elements to minimum: " + average);