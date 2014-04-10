// Text-based console Tasklist manager
// Features: Show all tasks, Add task, Delete task, Load tasklist, Save tasklist


using System;
using System.Collections.Generic;
using System.Threading;


// Records the tasklist
public class TaskList
{
    public string name;
    public List<string> listOfStrings;

    public TaskList()
    {
        name = "";
        listOfStrings = new List<string>();
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
        Console.WriteLine(HyphenMultiplier(80));
        Console.Write(">>> Add task: ");
        string input = Console.ReadLine();
        Console.Clear();

        Console.WriteLine(HyphenMultiplier(80));
        Console.WriteLine("TASKLIST ({0}):", taskList.name);
        Console.WriteLine();

        taskList.listOfStrings.Add(input);  // Update task list

        foreach (string task in taskList.listOfStrings)
        {
            Console.WriteLine(task);
        }
        Console.WriteLine(HyphenMultiplier(80));
    }

    static void DeleteTask()
    {
        Console.WriteLine("Not implemented yet.");
        Console.WriteLine();
    }

    static void SaveTaskList()
    {
        Console.WriteLine("Not implemented yet.");
        Console.WriteLine();
    }

    static void LoadTaskList()
    {
        Console.WriteLine("Not implemented yet.");
        Console.WriteLine();
    }

    static void ShowTasks()
    {
        int sizeOfTaskList = taskList.listOfStrings.Count;
        Console.Clear();

        if (sizeOfTaskList == 0)
        {
            Console.WriteLine(HyphenMultiplier(80));
            Console.WriteLine("No tasks.");
            Console.WriteLine(HyphenMultiplier(80));
        }
        else 
        {
            Console.WriteLine(HyphenMultiplier(80));
            Console.WriteLine("TASKLIST ({0}):", taskList.name);
            Console.WriteLine();

            foreach (string task in taskList.listOfStrings)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine(HyphenMultiplier(80));

        }
    }

    static void Main()
    {
        ShowTasks();

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