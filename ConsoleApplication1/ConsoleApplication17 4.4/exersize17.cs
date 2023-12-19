using System;
using System.IO;

string filename = "numTask4.txt";
int count = Countadjacentmatches(filename);
Console.WriteLine("Number of adjacent numbers " + count);

int Countadjacentmatches(string filename)
{
    count = 0;
    int prevNum = int.MinValue;

    string[] lines = File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] numbers = line.Split(' ');

        foreach (string numberStr in numbers)
        {
            if (int.TryParse(numberStr, out int currentNum))
            {
                if (currentNum == prevNum)
                {
                    count++;
                }

                prevNum = currentNum;
            }
        }
    }

    return count;
}