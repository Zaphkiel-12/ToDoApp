
using System;
using System.Collections.Generic;

List<string> task = new List<string>();

bool adding = true;


Console.WriteLine("=== Welcome to To Do List ver 1.0 !! >~< ===");
while (adding)
{
    Console.WriteLine("1. Add Tasks");
    Console.WriteLine("2. View Tasks");
    Console.WriteLine("3. Remove Tasks");
    Console.WriteLine("4. Exit");

    Console.Write("What do you want to do? ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("Enter the task you want to add: ");
        string newTask = Console.ReadLine();
        task.Add(newTask);
        Console.WriteLine("Your task is added successfully!");
    }
    else if (choice == "2")
    {
        if (task.Count == 0)
        {
            Console.WriteLine("There are no tasks currently added in your list.");
        }
        else if (task.Count > 0)
        {
            Console.WriteLine("Your Tasks: ");
            for (int i = 0; i < task.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {task[i]}");
            }
            Console.WriteLine("End of Tasks.");
        }
    }
    else if (choice == "3")
    {
        if (task.Count == 0)
        {
            Console.WriteLine("There are no tasks currently added on your list.");

        }
        else if (task.Count > 0)
        {
            Console.WriteLine("Your Tasks: ");
            for (int i = 0; i < task.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {task[i]}");
            }
            Console.WriteLine("Enter the number of the task you want to remove: ");
            int removeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            if (removeIndex >= 0 && removeIndex < task.Count)
            {
                task.RemoveAt(removeIndex);
                Console.WriteLine("Your task is removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
    else if (choice == "4")
    {
        adding = false;
        Console.WriteLine("Thank you for using To Do List ver 1.0 !! >~<");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
}
