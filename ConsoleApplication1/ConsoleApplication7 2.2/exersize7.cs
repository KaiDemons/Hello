using  System;

int[] mas = new int[100];

int num = 1;

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = num;
    num += 2;
}

for (int i = 0; i < mas.Length; i++)
    
{    
    Console.WriteLine(mas[i]);
}