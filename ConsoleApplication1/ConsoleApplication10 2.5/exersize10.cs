using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int[]> temperature = new Dictionary<string, int[]>();
        Random random = new Random();
        
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        
        foreach (string month in months)
        {
            int[] temperatures = new int[30];
            
            for (int day = 0; day < 30; day++)
            {
                temperatures[day] = random.Next(-30, 41);
            }
            
            temperature.Add(month, temperatures);
        }
        
        foreach (KeyValuePair<string, int[]> kvp in temperature)
        {
            string month = kvp.Key;
            int[] temperatures = kvp.Value;
            
            double averageTemperature = CalculateAverageTemperature(temperatures);
            
            Console.WriteLine("The average temperature in the month {0}: {1:F2}", month, averageTemperature);
        }
    }
    static double CalculateAverageTemperature(int[] temperatures)
    {
        int sum = 0;
        
        foreach (int temperature in temperatures)
        {
            sum += temperature;
        }
        
        double averageTemperature = (double)sum / temperatures.Length;
        return averageTemperature;
    }
}