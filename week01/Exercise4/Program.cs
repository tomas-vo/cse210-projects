using System;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int addnumber;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        
        do
        {
            Console.WriteLine("Enter number: ");
            addnumber = int.Parse(Console.ReadLine());

            if (addnumber != 0) 
            {
                numbers.Add(addnumber);
            }

        } while (addnumber != 0); 

        
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return; 
        }

        int sum = 0;
        int largestNumber = numbers[0]; 

        
        foreach (int number in numbers)
        {
            sum += number; 
            if (number > largestNumber) 
            {
                largestNumber = number;
            }
        }

        
        double average = (double)sum / numbers.Count;

        
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Largest Number: " + largestNumber);
    }
}




/* 

 Enter a list of numbers, type 0 when finished.
  Enter number: 18
  Enter number: 36
  Enter number: 2
  Enter number: 48
  Enter number: 6
  Enter number: 12
  Enter number: 9
  Enter number: 0
  The sum is: 131
  The average is: 18.714285714285715
  The largest number is: 48

-crear lista. (hacer bucle preguntando por numeros para add hasta digitar 0)

-hacer total
-hacer un average
-encontrar el numero mas alto
(comparando cada numero de la lista con el anterior. haciendo un index)

*/