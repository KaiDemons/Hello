using System;
using System.IO;

{
    string filename = "numsTask3.txt";
    int[] numbers = ReadNumbersFromFile(filename);

    int min = numbers[0];
    int max = numbers[0];
    foreach (int num in numbers)
    {
        if (num < min)
        {
            min = num;
        }
        if (num > max)
        {
            max = num;
        }
    }

    if (min == 0 || max == 0)
    {
        Console.WriteLine("array contains 0!!!");
    }
    else
    {
        double ratio = (double)min / (double)max;
        Console.WriteLine("ratio of minimum ({0}) and maximum({1}) array elements: {2:F2}",min,max,ratio);
    }
}

    static int[] ReadNumbersFromFile(string filename) 
{
    string[] lines = File.ReadAllText(filename).Split(',');

    int[] numbers = new int[lines.Length];
    for (int i = 0; i < lines.Length; i++)
    {
        int.TryParse(lines[i], out numbers[i]);
    }

    return numbers; 
}