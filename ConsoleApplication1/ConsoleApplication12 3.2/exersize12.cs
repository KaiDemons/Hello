using System;
using System.IO;


class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("nums.txt");
        
        StreamWriter writer = new StreamWriter("output.txt");

        string line;
        
        while ((line = reader.ReadLine()) != null)
        {
            string[] numbers = line.Split(' ');
            
            foreach (string number in numbers)
            {
                int num = int.Parse(number);
                
                if (num % 2 != 0)
                {
                    writer.Write(num + " ");
                }
            }
        }
        
        reader.Close();
        writer.Close();
    }
}