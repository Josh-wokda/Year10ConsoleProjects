using System;

namespace _04_Variables3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. This program has 3 errors that you can fix by creating some variables.
            //    Create the correct variables using 3 different data types so that the WriteLine statement outputs:
            //    "As of 2016 the population of China was 1.379 billion."

            int year = 1969;
            string country = "Alabama";
            float population = 10.69f;


            
            // Do not modify these lines:

            Console.WriteLine($"As of {year.ToString()} the population of {country} was {population.ToString()} billion.");
            Console.ReadLine();


            // Extension task

            int yearo = 1999;
            string name = "Schlagg";
            float fat = 352.5f;

            Console.WriteLine($"In the year {yearo.ToString()}, there were {fat.ToString()} losses of life due to the crimes of {name}");
            Console.ReadLine();
        }
    }
}

/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Create another output statement using a combination of different variables


QUESTIONS:
        
1. What is a the purpose of 'ToString()' for some of the variables?

converts an int or float to a string so it can be written by the computer



LINKS:

https://www.tutorialspoint.com/csharp/csharp_variables.htm
https://www.tutorialspoint.com/csharp/csharp_data_types.htm


WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */
