using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Yodaizer("I like Code");
            Console.ReadKey();
        }
        public static string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return ("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                return ("Buzz");
            }
            else if (number % 5 == 0)
            {
                return ("Fizz");
            }
            else
            {
                return number.ToString();
            }
        }
        public static string Yodaizer(string text)
        {
            string[] yodaArray = text.Split(' ');
            Array.Reverse(yodaArray);
            if (yodaArray.Length == 3)
            {
                string[] tempArray   
            }
            string yodaTalk = string.Join(" ", yodaArray);
            return yodaTalk;
        }
        public static void TextStats(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                counter++;
            }
            Console.WriteLine("Number of characters: {0}", counter);
            
            counter = 0;
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length ; i++)
            {
                counter++;
            }
            Console.WriteLine("Number of words: {0}", counter);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] =
            }
        }
        public static bool IsPrime(int number)
        {
            
            return true;
        }
        public static string DashInsert(int number)
        {
            return string.Empty;
        }
    }
}
