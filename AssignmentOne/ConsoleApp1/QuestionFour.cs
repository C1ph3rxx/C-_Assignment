using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public class QuestionFour
    {

        //Question 4.5
        static int countVowels()
        {
            Console.WriteLine("Enter an English word to count the number of vowels (a,e,i,o,u).");
            string input = Console.ReadLine() ?? "";
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int countVowels = 0;
            if (String.IsNullOrEmpty(input))
            {
                return 0;
            }
            foreach (char n in input.ToLower().ToCharArray())
            {
                if (vowels.Contains(n))
                {
                    countVowels++;
                }
            }
            return countVowels;
        }

        //Question 4.4
        static string PascalCase()
        {
            Console.WriteLine("Enter a few words separated by space. This converts the sentence into pascal case.");
            string input = Console.ReadLine() ?? "";
            if (String.IsNullOrEmpty(input))
            {
                return "";
            }
            StringBuilder result = new StringBuilder();
            foreach (string n in input.Trim().Split(" "))
            {
                Char firstCharacter = char.ToUpper(n[0]);
                result.Append(firstCharacter + n.Substring(1).ToLower());
            }
            return result.ToString();
        }


        //Question 4.3
        static string CheckTime()
        {
            Console.WriteLine("Enter a time value in the 24-hout time format (e.g 19:00). ");
            string input = Console.ReadLine() ?? "";
            if (input.Length < 1)
            {
                return "Invalid Time";
            }
            string[] myTime = input.Split(":");
            int hour = Convert.ToInt16(myTime[0]);
            int minute = Convert.ToInt16(myTime[1]);

            if (hour < 0 || hour > 24 || minute < 0 || minute > 59) 
            {
                //throw new FormatException("Invalid Time");
                return "Invalid Time";
            }

            return "Valid Time";

        }

        //Question 4.2
        static string CheckDuplicates()
        {
            Console.WriteLine("Enter a couple numbers separated by a hyphen (e.g 5-3-6-2-7). ");
            string[] input = Console.ReadLine()?.Split("-") ?? [];
            int[] intArray = Array.ConvertAll(input, int.Parse);
            if (input.Length < 1)
            {
                return "";
            }

            HashSet<int> set = new HashSet<int>();
            foreach (int n in intArray)
            {
                if (!set.Add(n))
                {
                    return "Duplicate found";
                }

            }
            return "No duplicates";
        }

        //Question 4.1
        static string CheckSequence()
        {
            Console.WriteLine("Enter a couple numbers separated by a hyphen (e.g 5-3-6-2-7). ");
            string[] input = Console.ReadLine()?.Split("-") ?? [];
            int[] intArray = Array.ConvertAll(input, int.Parse);
            Boolean isConsecutive = true;
            for (int i = 1; i < intArray.Count(); i++)
            {
                if (Math.Abs(intArray[i] - intArray[i - 1]) != 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            return isConsecutive ? "Consecutive" : "Not consecutive";
        }

        public QuestionFour()
        {

            Console.WriteLine(countVowels());
            Console.WriteLine(PascalCase());
            Console.WriteLine(CheckTime());
            Console.WriteLine(CheckDuplicates());
            Console.WriteLine(CheckSequence());

        }


    }
}
