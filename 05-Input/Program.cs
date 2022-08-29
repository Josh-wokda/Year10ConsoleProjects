using System;

namespace _05_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ask for the user's name
            Console.WriteLine("Hi, whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {name} :)");    
            Console.ReadLine();

            //Extension Task
            Console.WriteLine("How was your day?");
            string day = Console.ReadLine();
               

            if (day == "good")
            {
                Console.WriteLine("Thats good ;)");
            }

            else if (day == "bad")
            {
                Console.WriteLine("Oh, that not very good");
            }

            else if (day == "suck my cock")
            {
                Console.WriteLine($"Well if you insist {name}");
            }

            else
            {
                Console.WriteLine("Thats alright ig");
            }

            Console.ReadLine();
            
        }
    }
}

/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Ask for multiple inputs
2. Use Google to work out how to input a type other than string


QUESTIONS:
        
1. What does assignment mean?
assigning a value to a variable



2. What does Console.ReadLine() do?
it takes a string input from the user



EXAMPLE:

This is an example of creating a string variable and assigning to it with user input

  string example = Console.ReadLine();


WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */