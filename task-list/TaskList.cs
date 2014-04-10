// Text-based console Tasklist manager
// Features: Show all tasks, Add task, Delete task, Load tasklist, Save tasklist


using System;
using System.Threading;
using System.Collections.Generic;


// Records the tasklist
public class TaskList
{
    public string name;

    public TaskList()
    {
        name = "";
        var listOfStrings = new List<string>();
        //List<string> l = new List<string>();
    }
}


class Program
{
    static TaskList taskList = new TaskList();

    // Multiply char or string
    static string HyphenMultiplier(int n)
    {
        return new String('-', n);
    }

    static void ShowMenu()
    {
        Console.WriteLine("Select your option:");
        Console.WriteLine("-------------------");
        Console.WriteLine();
        Console.WriteLine("1. Add task");
        Console.WriteLine("2. Delete task");
        Console.WriteLine("3. Save current tasklist to <filename>.txt");
        Console.WriteLine("4. Load tasklist");
        Console.WriteLine();
        Console.WriteLine("0. QUIT");
        Console.WriteLine();
    }

    static void AddTask()
    {
        throw new NotImplementedException();
    }

    static void DeleteTask()
    {
        throw new NotImplementedException();
    }

    static void SaveTaskList()
    {
        throw new NotImplementedException();
    }

    static void LoadTaskList()
    {
        throw new NotImplementedException();
    }

    static void ShowTasks()
    {
        throw new NotImplementedException();
    }

    static void Main()
    {
        //ShowTasks();

        while (true)
        {
            ShowMenu();
            Console.Write(">> ");
            string input = Console.ReadLine();

            if (input == "1")
                AddTask();
            else if (input == "2")
                DeleteTask();
            else if (input == "3")
                SaveTaskList();
            else if (input == "4")
                LoadTaskList();
            else if (input == "0")
                Environment.Exit(0);
            else
            {
                Console.WriteLine(HyphenMultiplier(80));
                Console.WriteLine("ERROR: Invalid Command.");
                Console.WriteLine(HyphenMultiplier(80));

                // Wait 700ms (0.7s)
                Thread.Sleep(700);
                ShowTasks();
            }
        }
    }
}