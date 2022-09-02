using System;

namespace _06_NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is how we can store user input as a floating point number

            Console.WriteLine("Please enter a number for X:");
            float x = float.Parse(Console.ReadLine());

            // 1. Now do the same for the variable 'y'

            Console.WriteLine("now enter a number for y you donkey");
            float y = float.Parse(Console.ReadLine());


            // We can then perform some mathematical operations on it. E.g. addition with +

            Console.WriteLine("now guess");
            Console.WriteLine("guess what they make when put together you clown");

            float answer = float.Parse(Console.ReadLine());

            if (answer == (x + y))
            {
                Console.WriteLine("good you got it correct");
            }

            else
            {
                Console.WriteLine("dead wrong you idiot");
            }

            // 2. Try doing multiplication with * 

            Console.ReadLine();
            Console.WriteLine("now for your next question what is the answer if you multiply them");

            float answertwo = float.Parse(Console.ReadLine());

            if (answertwo == (x * y))
            {
                Console.WriteLine("wooow, youre really good at this arent you");
            }

            else
            {
                Console.WriteLine("haha, youre so stupid how did you get that wrong multiplication is easy");
            }

            // 3. Subtraction with - 

            Console.ReadLine();
            Console.WriteLine("righty ho then onto subtraction");
            Console.WriteLine($"youll be doing {x} - {y}, lets try and get it right");

            float answerthree = float.Parse(Console.ReadLine());

            if (answerthree == (x - y))
            {
                Console.WriteLine("damn nerrrd!");
            }

            else
            {
                Console.WriteLine("oh. my. god. you are the most stupid person i think ive seen in my life");
            }

            // 4. Division with /

            Console.ReadLine();
            Console.WriteLine("alright final question and then i dont have to deal with you anymore");
            Console.WriteLine($"whats {x} divided by {y}");

            float answerfour = float.Parse(Console.ReadLine());

            if (answerfour == (x / y))
            {
                Console.WriteLine("god damnit!");
            }

            else
            {
                Console.WriteLine("haha sucked in");
            }

            Console.WriteLine("alright cya you sucked to deal with");

            // 5. Wait for input before ending

            Console.ReadLine();

            
        }
        
        // Extension 1
        private static void SameButDoubles()
        {
            // This is how we can store user input as a floating point number

            Console.WriteLine("Please enter a number for X:");
            double x2 = double.Parse(Console.ReadLine());

            // 1. Now do the same for the variable 'y'

            Console.WriteLine("now enter a number for y you donkey");
            double y2 = double.Parse(Console.ReadLine());


            // We can then perform some mathematical operations on it. E.g. addition with +

            Console.WriteLine("now guess");
            Console.WriteLine("guess what they make when put together you clown");

            double answer2 = double.Parse(Console.ReadLine());

            if (answer2 == (x2 + y2))
            {
                Console.WriteLine("good you got it correct");
            }

            else
            {
                Console.WriteLine("dead wrong you idiot");
            }

            // 2. Try doing multiplication with * 

            Console.ReadLine();
            Console.WriteLine("now for your next question what is the answer if you multiply them");

            double answertwo2 = double.Parse(Console.ReadLine());

            if (answertwo2 == (x2 * y2))
            {
                Console.WriteLine("wooow, youre really good at this arent you");
            }

            else
            {
                Console.WriteLine("haha, youre so stupid how did you get that wrong multiplication is easy");
            }

            // 3. Subtraction with - 

            Console.ReadLine();
            Console.WriteLine("righty ho then onto subtraction");
            Console.WriteLine($"youll be doing {x2} - {y2}, lets try and get it right");

            double answerthree2 = double.Parse(Console.ReadLine());

            if (answerthree2 == (x2 - y2))
            {
                Console.WriteLine("damn nerrrd!");
            }

            else
            {
                Console.WriteLine("oh. my. god. you are the most stupid person i think ive seen in my life");
            }

            // 4. Division with /

            Console.ReadLine();
            Console.WriteLine("alright final question and then i dont have to deal with you anymore");
            Console.WriteLine($"whats {x2} divided by {y2}");

            double answerfour2 = double.Parse(Console.ReadLine());

            if (answerfour2 == (x2 / y2))
            {
                Console.WriteLine("god damnit!");
            }

            else
            {
                Console.WriteLine("haha sucked in");
            }

            Console.WriteLine("alright cya you sucked to deal with");

            // 5. Wait for input before ending

            Console.ReadLine();
        }

        // Extension 2


    }
}

/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Modify the program to work with the 'double' type
2. Use Google to work out how to get the remainder of a division using the 'modulus operator'
3. Find out what happens if you use integers when dividing


QUESTIONS:
        
1. What does "float.Parse" do?



2. What is a parameter? Give an example of where you have used one.



3. Why is the 'Console.ReadLine()' a parameter to float.Parse?




EXAMPLE:

This is what the final program output might look like:

  Please enter a number for X:
  7
  Please enter a number for Y:
  3
  X plus Y = 10
  X times Y = 21
  X minus Y = 4
  X divided by Y = 2.333333


WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */