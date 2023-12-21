using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}\nDescription: {Description}\nDue Date: {DueDate}";
    }
    
}

class Program
{
    private static List<Task> tasks = new List<Task>();
    private static string filename = "task.json";

    static void Main(string[] args)
    {
        LoadTasks();
        while (true)
        {
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Edit task");
            Console.WriteLine("3. Delete task");
            Console.WriteLine("4. View tasks for today");
            Console.WriteLine("5. View tasks for tomorrow");
            Console.WriteLine("6. View tasks for this week");
            Console.WriteLine("7. View all tasks");
            Console.WriteLine("8. View completed tasks");
            Console.WriteLine("9. Exit");
            
            Console.Write("\nEnter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    EditTask();
                    break;
                case 3:
                    DeleteTask();
                    break;
                case 4:
                    ViewTasksForToday();
                    break;
                case 5:
                    ViewTasksForTomorrow();
                    break;
                case 6:
                    ViewTasksForThisWeek();
                    break;
                case 7:
                    ViewAllTasks();
                    break;
                case 8:
                    ViewCompletedTasks();
                    break;
                case 9:
                    SaveTasks();
                    return;
            }
        }
    }

    static void LoadTasks()
    {
        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            tasks = JsonConvert.DeserializeObject<List<Task>>(json);
        }
    }

    static void SaveTasks()
    {
        string json = JsonConvert.SerializeObject(tasks);
        File.WriteAllText(filename,json);
    }

    static void AddTask()
    {
        Console.Write("Enter task title: ");
        string title = Console.ReadLine();
        
        Console.Write("Enter task description: ");
        string description = Console.ReadLine();
        
        Console.Write("Enter due date (yyyy-mm-dd): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        Task newTask = new Task
        {
            Title = title,
            Description = description,
            DueDate = dueDate
        };
        
        tasks.Add(newTask);
    }

    static void EditTask()
    {
        Console.Write("Enter task index to edit: ");
        int index = int.Parse(Console.ReadLine());
        if (index > -0 && index < tasks.Count)
        {
            Task task = tasks[index];

            Console.Write("Enter new task title: ");
            string title = Console.ReadLine();
            
            Console.Write("Enter new task description: ");
            string description = Console.ReadLine();
            
            Console.Write("Enter new due date (yyy-mm-dd): ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            task.Title = title;
            task.Description = description;
            task.DueDate = dueDate;
        }
        else
        {
            Console.WriteLine("Invalid task index");
        }
    }

    static void DeleteTask()
    {
        Console.Write("Enter task index to delete: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid task index");
        }
    }

    static void ViewTasksForToday()
    {
        DateTime today = DateTime.Today;
        
        Console.WriteLine($"Tasks for {today.ToShortDateString()}:");
        foreach (Task task in tasks)
        {
            if (task.DueDate.Date == today.Date)
            {
                Console.WriteLine(task);
                Console.WriteLine();
            }
        } 
    }

    static void ViewTasksForTomorrow()
    {
        DateTime tomorrow = DateTime.Today.AddDays(1);
        
        Console.WriteLine($"Tasks for {tomorrow.ToShortDateString()}:");
        foreach (Task task in tasks)
        {
            if (task.DueDate.Date == tomorrow.Date)
            {
                Console.WriteLine(task);
                Console.WriteLine();
            }
        }
    }

    static void ViewTasksForThisWeek()
    {
        DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 1);
        DateTime endOfWeek = startOfWeek.AddDays(7);
        
        Console.WriteLine($"Tasks for this week({startOfWeek.ToShortDateString()}-{endOfWeek.ToShortDateString()}:");
        foreach (Task task in tasks)
        {
            if (task.DueDate.Date >= startOfWeek.Date && task.DueDate.Date <= endOfWeek.Date)
            {
                Console.WriteLine(task);
                Console.WriteLine();
            }
        }
    }

    static void ViewAllTasks()
    {
        Console.WriteLine("All tasks:");
        foreach (Task task in tasks)
        {
            Console.WriteLine(task);
            Console.WriteLine();
        }
    }

    static void ViewCompletedTasks()
    {
        Console.WriteLine("Completed tasks:");
        foreach (Task task in tasks)
        {
            if (task.DueDate.Date < DateTime.Today.Date)
            {
                Console.WriteLine(task);
                Console.WriteLine();
            }
        }
    }
}