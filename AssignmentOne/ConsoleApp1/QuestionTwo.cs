using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public class QuestionTwo
    {

        //Question 2.5
        static int MaxNumber()
        {
            Console.WriteLine("Enter a series of numbers separated by a comma");
            string[] stringArray = Console.ReadLine()?.Split(",") ?? [];                //Splits the comma separated numbers into an array of strings
            int[] intArray = Array.ConvertAll(stringArray, int.Parse);                 //converts the string array to integer array
            return intArray.Max();                                    //Returns the largest number  in the integer array
        }

        //Question 2.4
        static string GuessNumber()
        {

            Random random = new Random();
            int secret = (int)(random.NextDouble() * 10); // Generates a random double between 0.0 and 1.0
            int count = 0;                                          //Counter to keep track of user input
            Console.WriteLine(secret);                              //Displays the secret for refernce 
            Console.WriteLine("Let's play a game.\nGuess my secret number between 1-10 in 5 attempts to win the prize");

            while (count < 4)
            {
                Console.WriteLine("Enter your guess");
                int.TryParse(Console.ReadLine(), out int guess);

                if (guess == secret)
                {
                    return "You won";
                }
                count++;
            }

            return "You lost";

        }


        //Question 2.3
        static int count = 0;
        static int Factorial(int n)
        {
            do
            {

                Console.WriteLine($"A program to calculate the factorial of {n}");
                count++;
            }
            while (count < 1);
            return (n <= 1) ? 1 : n * Factorial(n - 1);             //Recursive function that returns the factorial when the number gets to 1

        }

        //Question 2.2
        static int CountInputs()
        {
            int count = 0;
            do
            {
                Console.WriteLine("This program will collate the sum of number inputs until you enter 'ok'");
                count++;

            }
            while (count < 1);

            Console.WriteLine("Enter a number\n");
            string? input = Console.ReadLine() ?? "";

            return input.Equals("ok") ? 0 : (Convert.ToInt32(input) + CountInputs());
        }

        //Question 2.1
        static int DivisibleBy3()
        {
            List<int> numbers = new List<int>();         //Creates a variable-size List
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)     //Modulo operation foreach number less 100 that is divisble by 3 without a remainder
                {
                    numbers.Add(i);         //Adds the numbers that pass the modulo operation into the numbers list
                }
            }


            return numbers.Count();         //Returns the count of the numbers divisible by 3 in the List
        }

        public QuestionTwo()
        {
            //Question 2
            Console.WriteLine(MaxNumber());
            Console.WriteLine(GuessNumber());
            Console.WriteLine(Factorial(6));
            Console.WriteLine(CountInputs());
            Console.WriteLine(DivisibleBy3());

        }
    }
}
