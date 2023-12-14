using System;

Console.Write("Введите строку: ");

string input = Console.ReadLine();

string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

int wordCount = words.Length;

string modifiedString = "Start " + input + " End";

Console.WriteLine("Количество слов: " + wordCount); 

Console.WriteLine("Модифицированная строка: " + modifiedString); 

Console.ReadLine();

