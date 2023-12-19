using System;
using System.IO;

string fileName = "numsTask1.txt";
if (!File.Exists(fileName)) 
{
    Console.WriteLine($"The {fileName} file was not found.");
    return;
}

string[] words = File.ReadAllLines(fileName); 

foreach (string word in words)
{
    if (word.Length % 2 != 0) 
    {
        Console.WriteLine(word);
    }
}

Console.ReadLine();