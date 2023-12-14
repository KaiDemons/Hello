using System;

int a = 5;

int[,] matrix = new int[a, a];

for (int i = 0; i < a; i++)
{
    matrix[i, 0] = 1;
    matrix[0, i] = 1;
}

for (int i = 1; i < a; i++)
{
    for (int j = 1; j < a; j++)
    {
        matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
    }
}

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
   