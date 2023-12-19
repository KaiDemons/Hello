using System;
using System.IO;


int[] nums = Array.ConvertAll(File.ReadAllText("numsTask4.txt").Split(), int.Parse);

int max = nums[0];
for (int i = 1; i < nums.Length; i++) {
    if (nums[i] > max) {
        max = nums[i];
    }
}

int sum = 0;
for (int i = 0; i < nums.Length; i++) {
    if (nums[i] == max - 1 || nums[i] == max + 1) {
        sum += nums[i];
    }
}

Console.WriteLine("Sum of elements differing from the maximum by 1: " + sum);