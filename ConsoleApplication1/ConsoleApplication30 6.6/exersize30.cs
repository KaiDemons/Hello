using System;

    Random random = new Random();
    int arraySize = random.Next(5, 10); // случайный размер массива от 5 до 10

    double[] array = new double[arraySize]; // создание массива заданного размера

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = random.NextDouble() * (10 - (-10)) + (-10); // заполнение массива случайными дробными числами от -10 до 10
    }

    double[] positiveArray = Array.FindAll(array, x => x > 0); // массив с положительными элементами
    double[] negativeArray = Array.FindAll(array, x => x < 0); // массив с отрицательными элементами

    Console.WriteLine("Исходный массив: " + string.Join(", ", array));
    Console.WriteLine("Положительные элементы: " + string.Join(", ", positiveArray));
    Console.WriteLine("Отрицательные элементы: " + string.Join(", ", negativeArray));