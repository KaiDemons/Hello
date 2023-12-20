using System;

Random random = new Random();
int length = random.Next(1, 10);
double[] array = new double[length];
for (int i = 0; i < length; i++)
{
    array[i] = random.NextDouble() * (random.Next(0, 2) >= 1 ? -1 : 1);
}

double[] positiveElements = Array.FindAll(array, element => element > 0);
double[] negativeElements = Array.FindAll(array, element => element < 0);

string[] positiveStrings = Array.ConvertAll(positiveElements, element => element.ToString());
string[] negativeStrings = Array.ConvertAll(negativeElements, element => element.ToString());

Console.WriteLine("Source array: " + string.Join(", ", Array.ConvertAll(array, element => element.ToString())));
Console.WriteLine("Positive elements: " + string.Join(", ", positiveStrings));
Console.WriteLine("Negative elements: " + string.Join(", ", negativeStrings));