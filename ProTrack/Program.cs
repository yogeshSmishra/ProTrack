using ProTrack.Models;
using ProTrack.Logic;
using System;

var service = new TaskLogic();
int choice;

Console.WriteLine("--------------------Welcome to ProTrack--------------------");

do
{
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Add a Task");
    Console.WriteLine("2. View All Tasks");
    Console.WriteLine("3. Exit");
    Console.Write("Select an option: ");

    bool isValid = int.TryParse(Console.ReadLine(), out choice);

    if (!isValid)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        continue;
    }

    switch (choice)
    {
        case 1:
            AddTask(service);
            break;
        case 2:
            ShowTasks(service);
            break;
        case 3:
            Console.WriteLine("Exiting..");
            break;
        default:
            Console.WriteLine("Invalid choice. Please select a valid option.");
            break;
    }
} while (choice != 3);
Console.WriteLine("Thank you for using ProTrack :)");


//local functionss

void AddTask(TaskLogic service)
{
    Console.Write("Enter Task Title: ");
    string title = Console.ReadLine() ?? "Untitled";
    Console.Write("Enter Description: ");
    string description = Console.ReadLine() ?? "";
    service.AddTask(title, description);
    Console.WriteLine("Task added successfully!");
}

void ShowTasks(TaskLogic service)
{
    var tasks = service.GetAllTasks();
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks available.");
        return;
    }
    Console.WriteLine("\n--- YOUR TASKS ---");
    foreach (var task in tasks)
    {
        Console.WriteLine($"[{task.Id}] {task.Title} - Status: {task.Status}");
    }
    Console.WriteLine($"Total Tasks Created: {TaskLogic.GetTaskCount()}");
}