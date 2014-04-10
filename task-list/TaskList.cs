// Text-based console Tasklist manager
// Features: Show all tasks, Add task, Delete task, Load tasklist, Save tasklist


using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;


// Keeps track of the TaskList
public class TaskList
{
    public string name;
    public List<string> listOfStrings;

    public TaskList()
    {
        name = "";
        listOfStrings = new List<string>();
    }
}


class Program
{
    static TaskList taskList = new TaskList();

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

        for (int i = 0; i < taskList.listOfStrings.Count; i++)
        {
            Console.WriteLine("{0}.................... {1}", i+1, taskList.listOfStrings[i]);
        }

        ShowTasks();
    }

    static void DeleteTask()
    {
        int sizeOfTaskList = taskList.listOfStrings.Count;

        if (sizeOfTaskList == 0)
        {
            Console.WriteLine(HyphenMultiplier(80));
            Console.WriteLine("ERROR: No tasks to delete.");
            Console.WriteLine(HyphenMultiplier(80));
            Thread.Sleep(1500);
            ShowTasks();
        }
        else
        {
            Console.WriteLine(HyphenMultiplier(80));
            Console.Write(">>> Delete task number: ");
            string input = Console.ReadLine();

            if (input == "1" && sizeOfTaskList >= 1)
            {
                taskList.listOfStrings.RemoveAt(0);
                ShowTasks();
            }
            else if (input == "2" && sizeOfTaskList >= 2)
            {
                taskList.listOfStrings.RemoveAt(1);
                ShowTasks();
            }
            else if (input == "3" && sizeOfTaskList >= 3)
            {
                taskList.listOfStrings.RemoveAt(2);
                ShowTasks();
            }
            else if (input == "4" && sizeOfTaskList >= 4)
            {
                taskList.listOfStrings.RemoveAt(3);
                ShowTasks();
            }
            else if (input == "5" && sizeOfTaskList >= 5)
            {
                taskList.listOfStrings.RemoveAt(4);
                ShowTasks();
            }
            else if (input == "6" && sizeOfTaskList >= 6)
            {
                taskList.listOfStrings.RemoveAt(5);
                ShowTasks();
            }
            else if (input == "7" && sizeOfTaskList >= 7)
            {
                taskList.listOfStrings.RemoveAt(6);
                ShowTasks();
            }
            else if (input == "8" && sizeOfTaskList >= 8)
            {
                taskList.listOfStrings.RemoveAt(7);
                ShowTasks();
            }
            else if (input == "9" && sizeOfTaskList >= 9)
            {
                taskList.listOfStrings.RemoveAt(8);
                ShowTasks();
            }
            else if (input == "10" && sizeOfTaskList >= 10)
            {
                taskList.listOfStrings.RemoveAt(9);
                ShowTasks();
            }
            else
            {
                Console.WriteLine(HyphenMultiplier(80));
                Console.WriteLine("ERROR: Not a valid number.");
                Console.WriteLine(HyphenMultiplier(80));
                Thread.Sleep(1500);
                ShowTasks();
            }
        }
    }

    static void SaveTaskList()
    {
        int sizeOfTaskList = taskList.listOfStrings.Count;

        if (sizeOfTaskList == 0)
        {
            Console.WriteLine(HyphenMultiplier(80));
            Console.WriteLine("ERROR: No tasks.");
            Console.WriteLine(HyphenMultiplier(80));
            Thread.Sleep(1500);
            Main();
        }
        // Create a folder
        Directory.CreateDirectory("TaskLists");

        Console.Write("Save tasklist (filename): ");
        string fileName = Console.ReadLine();
        taskList.name = fileName + ".txt";

        // Write to file
        File.WriteAllLines("TaskLists/"+fileName + ".txt", taskList.listOfStrings);
        Console.Clear();
        Console.WriteLine(HyphenMultiplier(80));
        Console.WriteLine();
        Console.WriteLine("Created '{0}' succesfully!", taskList.name);
        Console.WriteLine();
        Console.WriteLine(HyphenMultiplier(80));
        Thread.Sleep(1500);
        ShowTasks();
    }

    static void LoadTaskList()
    {
        Console.WriteLine(HyphenMultiplier(80));
        Console.Write("Load tasklist (filename): ");
        string fileName = Console.ReadLine();

        // Check if the file exists
        if (System.IO.File.Exists("TaskLists/" + fileName + ".txt") == true)
        {
            // Empty the current TaskList
            taskList.listOfStrings.Clear();

            int counter = 0;
            string line;

            // Read the file and display it line by line
            System.IO.StreamReader file = new System.IO.StreamReader("TaskLists/" + fileName + ".txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                taskList.listOfStrings.Add(line);
                counter++;
            }
            file.Close();
            taskList.name = fileName + ".txt";

            Console.Clear();
            Console.WriteLine(HyphenMultiplier(80));
            Console.WriteLine();
            Console.WriteLine("Loaded '{0}' succesfully!", taskList.name);
            Console.WriteLine();
            Console.WriteLine(HyphenMultiplier(80));
            Thread.Sleep(1500);
            ShowTasks();
        }
        else
        {
            Console.WriteLine(HyphenMultiplier(80));
            Console.WriteLine("ERROR: Tasklist doesn't exist.");
            Console.WriteLine(HyphenMultiplier(80));
            Thread.Sleep(1500);
            Main();
        }
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
            taskList.name = "";
        }
        else 
        {
            Console.WriteLine(HyphenMultiplier(80));

            if (taskList.name != "")
                Console.WriteLine("TASKLIST ({0}):", taskList.name);
            else
                Console.WriteLine("TASKLIST:");

            Console.WriteLine();

            for (int i = 0; i < taskList.listOfStrings.Count; i++)
                Console.WriteLine("{0}.................... {1}", i + 1, taskList.listOfStrings[i]);

            Console.WriteLine(HyphenMultiplier(80));
        }
    }

    static void Main()
    {
        ShowTasks();

        // Main loop
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
                Thread.Sleep(700);
                ShowTasks();
            }
        }
    }
}