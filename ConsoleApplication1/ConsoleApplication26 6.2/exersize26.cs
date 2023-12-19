using System;
using System.IO;

string fileName = "numsTask2.txt";

try
{
    string[] words = File.ReadAllLines(fileName); // чтение всех строк из файла
    string result = string.Join(" ", words); // объединение слов в одну строку

    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}

Console.ReadLine();