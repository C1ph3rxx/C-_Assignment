using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public class QuestionThree
    {
        static List<int> numbers = new();
        static List<string> names = new();


        //Question 3.5
        static string displayLeast3()
        {
            Console.WriteLine("Enter a list of comma separated value (e.g 4,2,1,6,8,3). ");
            string[] input = Console.ReadLine()?.Split(",") ?? [];
            int[] intArray = Array.ConvertAll(input, int.Parse);

            if (input.Length < 5)
            {
                Console.WriteLine("The list should have at least 5 numbers");
                return displayLeast3();
            }
            Array.Sort(intArray);
            int[] result = intArray.Take(3).ToArray();
            return string.Join(", ", result);
        }

        //Question 3.4
        static string ContinuousInput()
        {
            Console.WriteLine("Enter a number or type 'Quit' to exit");
            string input = Console.ReadLine() ?? "";
            if (input != "Quit")
            {
                numbers.Add(Convert.ToInt32(input));
                return ContinuousInput();
            }

            numbers = numbers.Distinct().ToList();

            return string.Join(", ", numbers);
        }



        //Question 3.3
        static string SortUniqueNumbers()
        {
            Console.WriteLine("Input five UNIQUE numbers.\n Ready? Let's go");
            int number = int.Parse(Console.ReadLine() ?? "");
            if (numbers.Contains(number))
            {
                Console.WriteLine("UNIQUE numbers bro. That number is already part of the list");
                return SortUniqueNumbers();
            }
            numbers.Add(number);
            if (numbers.Count != 5)
            {
                return SortUniqueNumbers();
            }

            numbers.Sort();
            return string.Join(", ", numbers);

        }

        //Question 3.2
        static string ReverseName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine() ?? "";
            char[] nameArray = name.ToCharArray();      //Converts the string name to charArray
            Array.Reverse(nameArray);                    //Reverses the char array

            return new string(nameArray);               //Returns a string of the reverse char array

        }

        //Question 3.1
        static string CountLikes()
        {
            Console.WriteLine("Enter a unique name");
            string uniqueName = Console.ReadLine() ?? "";

            if (uniqueName.Length < 1)
            {
                if (names.Count < 1)
                {
                    return "";
                }
                if (names.Count < 2)
                {
                    return names.First();
                }
                StringBuilder result = new StringBuilder();
                if (names.Count < 3)
                {
                    foreach (string n in names)
                    {
                        result.Append(n).Append(" ");
                    }
                    return result.Append(" liked your post").ToString().Trim();
                }

                return result.Append(names[0]).Append(" ").Append(names[1]).Append(" and ").Append((names.Count() - 2).ToString()).Append(" others liked your post.").ToString().Trim();

            }

            names.Add(uniqueName);

            return CountLikes();
        }

        public QuestionThree()
        {

            //Question 3
            Console.WriteLine(displayLeast3());
            Console.WriteLine(ContinuousInput());
            Console.WriteLine(SortUniqueNumbers());
            Console.WriteLine(ReverseName());
            Console.WriteLine(CountLikes());


        }
    }
}
