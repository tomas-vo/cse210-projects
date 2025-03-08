using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage?: ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        string letter = "";

        if (number >= 90) //if
        {
            letter = "A";
            
        }
        else if (number >= 80) //elif
        {
            letter = "B";
            
        }
        else if (number >= 70) //elif
        {
            letter = "C";
            
        }
        else if (number >= 60) //elif
        {
            letter = "D";
            
        }
        else // else
        {
            letter = "F";
            
        }

         Console.WriteLine($"Your grade is: {letter}");

         if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry, you can do better next time. Keep going!");
        }
    }
}


// A >= 90
//B >= 80
//C >= 70
//D >= 60
//F < 60