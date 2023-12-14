using System;

int[,] calendar = new int [12,30];
Random random = new Random();
for (int i = 0; i < 12; i++)
for (int j = 0;  j < 30; j++)
{
    if (i == 0)
        calendar[i, j] = random.Next(-28, -10);
    if (i == 1)
        calendar[i, j] = random.Next(-14, 4);
    if (i == 2)
        calendar[i, j] = random.Next(-9, 12);
    if (i == 3)
        calendar[i, j] = random.Next(-4, 18);
    if (i == 4)
        calendar[i, j] = random.Next(3, 23);
    if (i == 5)
        calendar[i, j] = random.Next(15, 33);
    if (i == 6)
        calendar[i, j] = random.Next(22, 30);
    if (i == 7)
        calendar[i, j] = random.Next(15, 25);
    if (i == 8)
        calendar[i, j] = random.Next(9, 20);
    if (i == 9)
        calendar[i, j] = random.Next(-3, 16);
    if (i == 10)
        calendar[i, j] = random.Next(-10, 3);
    if (i == 11)
        calendar[i, j] = random.Next(-35, -15);
}

int[] averagetemp = CalculatingTheAverageTemperature(calendar);
Array.Sort(averagetemp);

for (int month = 0; month<12; month++)
Console.WriteLine($"The average temperature in the month {month+1}:{averagetemp[month]}");

int[] CalculatingTheAverageTemperature(int[,] calendar1)
{
    int[] averageTemperature = new int[12];
    for (int i = 0; i < 12; i++)
    {
        int sum = 0;
        for (int j = 0; j < 30; j++)
        {
            sum += calendar1[i, j];
            if (j == 29)
            {
                averageTemperature[i] = sum / 30;
            }
        }
    }
    Console.WriteLine();
                
    return averageTemperature;
}