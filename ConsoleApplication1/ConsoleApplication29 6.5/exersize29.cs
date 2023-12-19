using System;

int[,] matrix = {
    { 0, 1, 0 },
    { 1, 0, 1 },
    { 1, 1, 1 }
};

int n = matrix.GetLength(0);
int m = matrix.GetLength(1);

int[,] newMatrix = new int[n, m + 1];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        newMatrix[i, j] = matrix[i, j];
    }
}

for (int i = 0; i < n; i++)
{
    int count = 0;

    for (int j = 0; j < m; j++)
    {
        if (matrix[i, j] == 1)
        {
            count++;
        }
    }

    newMatrix[i, m] = count % 2 == 0 ? 0 : 1;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m + 1; j++)
    {
        Console.Write(newMatrix[i, j] + " ");
    }

    Console.WriteLine();
}

