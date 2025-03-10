using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public class QuestionOne
    {

        //Question 1.1
        public string checkNumber()
        {
        
            Console.WriteLine("Enter any number between 1 to 10");
            int.TryParse(Console.ReadLine(), out int n );
            return (n > 1 && n <= 10) ? "Valid" : "Invalid";
        }

        //Question 1.2
        static int MaxNumber()
        {
            int a = 7;
            int b = 2;
            int c = 11;

            int[] numbers = { a, b, c };

            Array.Sort(numbers);
            return numbers[numbers.Length - 1];
        }


        //Question 1.3
        static string ImageType()
        {
            int imageHieight = 168;
            int imageWidth = 100;
            return imageHieight == imageWidth ? "Potrait" : "Landscape";
        }


        //Question 1.4
        static string SpeedCheck()
        {
            int speedLimit = 60;
            int currentSpeed = 120;

            if (currentSpeed < speedLimit)
            {
                return "Ok";
            }

            int demeritPoint = (currentSpeed - speedLimit) / 5;

            return demeritPoint < 12 ? "Keep speeding, you already have " + demeritPoint + " demerit points" : "License suspended";
        }

        public QuestionOne()
        {

            Console.WriteLine(checkNumber());
            Console.WriteLine(MaxNumber());
            Console.WriteLine(ImageType());
            Console.WriteLine(SpeedCheck());
        }

    }
}
