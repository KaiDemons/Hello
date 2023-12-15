using System;

class Program
{
    static void Main()
    {
        string[] lines = System.IO.File.ReadAllLines("nums.txt");
        int[] height = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            height[i] = int.Parse(lines[i]);
        }

        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int area = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, area);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        Console.WriteLine("Largest area: " + maxArea);
    }
}