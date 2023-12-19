using System;
using System.IO;

{
        string filename = "numsTask2.txt";
        double[] numbers = ReadNumbersFromFile(filename);

        double sum = 0;
        foreach (double num in numbers)
        {
            if (num == 0)
            {
                break;
            }
            else if (num > 0)
            {
                sum += num;
            }
        }

        Console.WriteLine("Sum of elements up to the first zero: {0}", sum);
}

static double[] ReadNumbersFromFile(string filename) 
    {
        string[] lines = File.ReadAllText(filename).Split(';');

        double[] numbers = new double[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            double.TryParse(lines[i], out numbers[i]);
        }

        return numbers; 
    }
