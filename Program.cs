using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the task list program!");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "x")
            {
                Console.WriteLine("Add new task:)\n");
                Console.WriteLine("Press 1 to add a task to the list.");
                Console.WriteLine("Press 2 to remove a task from the list.");
                Console.WriteLine("Press 3 to view the list.\n");
                Console.WriteLine("Press X to exit the program");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the name of the task.");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Success. The list have a new task.\n");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.Write(i + " " + taskList[i]);
                    }
                    Console.WriteLine("Please enter the number of the task to remove from the list.");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current task in the list: ");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "x")
                {
                    Console.WriteLine("Good bye!");
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
            Console.WriteLine("Thank you for using the program!");
        }
    }
}