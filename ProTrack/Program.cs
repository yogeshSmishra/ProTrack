using ProTrack.Models;
using ProTrack.Logic;

// Create an instance of our service to manage our data
var service = new TaskLogic();

Console.WriteLine("                 Welcome to ProTrack                 ");

while (true)
{
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Add a Task");
    Console.WriteLine("2. View All Tasks");
    Console.WriteLine("3. Exit");
    Console.Write("Select an option: ");

    var choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Enter Task Title: ");
        string title = Console.ReadLine() ?? "Untitled";

        Console.Write("Enter Description: ");
        string description = Console.ReadLine() ?? "";

        service.AddTask(title, description);
        Console.WriteLine("Task added successfully!");
    }
    else if (choice == "2")
    {
        var tasks = service.GetAllTasks();
        Console.WriteLine("\n--- YOUR TASKS ---");
        foreach (var task in tasks)
        {
            Console.WriteLine($"[{task.Id}] {task.Title} - Status: {task.Status}");
        }
    }
    else if (choice == "3")
    {
        break;
    }
}