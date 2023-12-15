using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("input.txt");
        string[] selectedNumbers = lines[0].Split(' ');
        int n = int.Parse(lines[1]);
        
        string[] tickets = new string[n];
        for (int i = 0; i < n; i++)
        {
            tickets[i] = lines[i + 2];
            string[] numbers = tickets[i].Split(' ');

            int count = 0;
            foreach (string number in numbers)
            {
                if (Array.IndexOf(selectedNumbers, number) != -1)
                {
                    count++;
                }
            }
            
            if (count >= 3)
            {
                tickets[i] = "Lucky";
            }
            else
            {
                tickets[i] = "Unlucky";
            }
        }
        
        File.WriteAllLines("output.txt", tickets);
    }
}