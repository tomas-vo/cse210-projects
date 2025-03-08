using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?: ");
        String magic_number = Console.ReadLine();
        int number = int.Parse(magic_number);

        int NGuess = 0;

    
            while (NGuess != number) 
         {   

            Console.WriteLine(" What is your guess?: ");
            string Guess = Console.ReadLine();
            NGuess = int.Parse(Guess);



            if (NGuess > number )
            {
                Console.WriteLine($"Lower");
            }

            else if (NGuess < number )
            {
                Console.WriteLine($"Higher");
            }

            else
            {
                Console.WriteLine($"Correct! the magic number is: {NGuess}");
            }
        }
     }
}    

// Everything ready :)