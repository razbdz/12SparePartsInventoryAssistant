// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    { string[] inventory = { "hydraulic pump", "PLC module", "servo motor" };

        Console.WriteLine("Hej. Welcome to the spare parts inventory!");

        while (true)
        { Console.Write("Which part do you need? ");
            string userInput = Console.ReadLine() ?? "";

         
            if (userInput == "Do you actually have any parts?" ||
                userInput == "Do you actualy have any parts?" || 
                userInput == "Is there anything in stock at all?")
            { Console.WriteLine($"We have {inventory.Length} part(s)!");
                foreach (string item in inventory)
                {
                    Console.WriteLine(item);
                }
                continue;
            }
            bool match = Array.Exists(inventory, part => part == userInput);

            if (match)
            { Console.WriteLine($"I've got {userInput} here for you");
                break; 
            }
            else
            { Console.WriteLine($"I am afraid we don't have any {userInput} in the inventory");
            }
        }
    }
}