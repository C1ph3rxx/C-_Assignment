using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public class QuestionFive
    {
        static string pattern = @"(?<=\b\w+)\W+";
        static List<int> numbers = new List<int>();

        //Question 5.2
        static string GetLongestWord(string file)
        {
            string longestWord = "";
            try
            {

                if (!File.Exists(file))
                {
                    Console.WriteLine("File doesnt exist");
                    return "";
                }

                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(file))
                {
                    string? line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        foreach (string word in line.Split(" "))
                        {

                            string result = Regex.Replace(word, pattern, "");

                            if (longestWord.Length < result.Length)
                            {
                                longestWord = result;
                            }

                        }

                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return longestWord;
        }


        //Question 5.1
        static int WordsCount(string file)
        {
            int count = 0;
            try
            {

                if (!File.Exists(file))
                {
                    Console.WriteLine("File doesnt exist");
                    return 0;
                }

                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(file))
                {
                    string? line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        foreach (string word in line.Split(" "))
                        {
                            count++;

                            //Console.WriteLine(word);
                        }
                        //Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return count;

        }

        public QuestionFive()
        {

            //string fileName = "C:\\Users\\ugoo.alaegbu\\Documents\\MyFile.txt";

            Console.WriteLine("Path to text file to perform operation");
            string fileName = Console.ReadLine() ?? "";
          
            Console.WriteLine(GetLongestWord(fileName));
            Console.WriteLine(WordsCount(fileName));

        }

    }
}
