using System;
using System.IO;

string filename = "numsTask2.txt";
        
string fileContent = File.ReadAllText(filename);
string[] numbersStr = fileContent.Split(';');
double[] numbers = new double[numbersStr.Length];
for (int i = 0; i < numbersStr.Length; i++) 
{
    try 
    {
        numbers[i] = double.Parse(numbersStr[i]);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return ;
    }
     
}

Array.Sort(numbers);

string sortedNumbers = "";
for (int i = 0; i < numbers.Length; i++)
{ 
    sortedNumbers += numbers[i].ToString();
    if (i != numbers.Length - 1)
    {
        sortedNumbers += ";";
    }
}
        
File.WriteAllText(filename, sortedNumbers);

Console.WriteLine("Числа были успешно отсортированы и записаны обратно в файл.");