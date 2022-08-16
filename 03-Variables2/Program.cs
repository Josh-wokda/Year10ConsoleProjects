﻿using System;

namespace _03_Variables2
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Create an 'integer' variable and assign it a whole number
            int nice = 69;

            // 2. Create a 'floating point' variable and assign it a decimal number
            float verynice = 420.69f;

            // 3. Create a 'boolean' variable and assign it either true or false
            bool itisnice = true;

            // 4. Output a message for each of your variables
            // E.g. "There are 27 days until christmas", "Avatar scored 7.8 on the IMDb", "Is the door open? false"
            Console.WriteLine($"{nice} is a nice number. {verynice} is an even nicer number. Is it nice? {itisnice}");

            // 5. Make the program wait for input at the end
            Console.ReadLine();

        }
    }
}


/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Use Google to find out what other data types are in C#, then have a go at using them
 
2. Find out how to join variables to strings using "String Interpolation"


QUESTIONS:
        
1. What is a the best data type for a whole number?
integer



2. What data types can be used for decimal numbers?
float



EXAMPLE:

This is an example of creating a double precision floating point number and outputting it to the console

  double preciseNumber = 2.997;
  Console.WriteLine("My precise number is: " + preciseNumber);
  Console.ReadLine();


LINKS:

https://www.tutorialspoint.com/csharp/csharp_variables.htm
https://www.tutorialspoint.com/csharp/csharp_data_types.htm


WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */