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
            Console.WriteLine(Yodaizer("I like code"));
            TextStats("I think this function should work. I'm not sure what do you think? if it does, great, if not, then I need to fix it");
            //loops from 0 to 25 to test if an odd number between is odd or not
            for (int i = 0; i <= 25; i++)
            {
                if (i % 2 != 0)
                {
                    if (IsPrime(i) == true)
                    {
                        Console.WriteLine("{0} is a prime number", i);
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            Console.WriteLine(DashInsert(454793));
            Console.WriteLine(DashInsert(8675309));
            Console.ReadKey();
        }
        /// <summary>
        /// returns a string (fizz if divisable by 5, buzz if divisable by 3, FizzBuzz if divisable by 3 and 5, returns number as string if not divisable)
        /// </summary>
        /// <param name="number">insert a veriable</param>
        /// <returns></returns>
        public static string FizzBuzz(int number)
        {
            if (number < 0)
            {
                return("");
            }
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
        /// <summary>
        /// Turns sentances into the way yoda would say them
        /// </summary>
        /// <param name="text">enter sentence</param>
        /// <returns>yoda version of sentence</returns>
        public static string Yodaizer(string text)
        {
            string[] yodaArray = text.Split(' ');
            if (yodaArray.Length == 3)
            {
                string[] trueYoda = new string[3];
                trueYoda[0] = yodaArray[2] + ",";
                trueYoda[1] = yodaArray[0];
                trueYoda[2] = yodaArray[1];
                string trueYodaTalk = string.Join(" ", trueYoda);
                return trueYodaTalk;
                   
              
            }
            Array.Reverse(yodaArray);
            string yodaTalk = string.Join(" ", yodaArray);
            return yodaTalk;
        }
        /// <summary>
        /// Show number of characters, words, vowels, consonants, 
        /// </summary>
        /// <param name="input">insert any string</param>
        public static void TextStats(string input)
        {
            int counter = 0;
            int counterVowel = 0;
            int counterConsonants = 0;
            int counterSpecialChar = 0;

            for (int i = 0; i < input.Length; i++)
            {
                counter++;
            }
            Console.WriteLine("Number of characters: {0}", counter);
            
            counter = 0;
            //splits string into an array by sperating by a space character
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length ; i++)
            {
                counter++;
            }
            Console.WriteLine("Number of words: {0}", counter);
            string loweredInput = input.ToLower();
            for (int i = 0; i < loweredInput.Length ; i++)
            {
                if (char.IsLetter(loweredInput[i]) && "aeiou".Contains(loweredInput[i]))
                {
                    counterVowel++;
                }
                //if it's not a vowel it must be a consonant so adds to counterConsonants
                else if (char.IsLetter(loweredInput[i]))
                {
                    counterConsonants++;
                }
            }
            Console.WriteLine("Number of vowels: {0}", counterVowel);
            Console.WriteLine("Number of consonants: {0}", counterConsonants);
            for (int i = 0; i < input.Length; i++)
            {
                if ("., ?".Contains(input[i]))
                {
                    counterSpecialChar++;
                }
            }
            Console.WriteLine("Number of special characters: {0}", counterSpecialChar);

        }
        /// <summary>
        /// finds is a number is prime 
        /// </summary>
        /// <param name="number">integer</param>
        /// <returns>a boolean true or false is returned</returns>
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        /// <summary>
        /// inserts dash between two odd numbers (0 not included)
        /// </summary>
        /// <param name="number">any integer</param>
        /// <returns>string of the integer with dashes inserted</returns>
        public static string DashInsert(int number)
        {
            string numberString = number.ToString();
            List<char> numberList = new List<char> { };
            for (int i = 0; i < numberString.Length; i++)
            {
                numberList.Add(numberString[i]);
            }
            for (int i = 0; i < numberString.Length; i++)
            {
                
                int previous = i - 1;
                if (numberList[i] != 0 && i > 0)
                {
                    if (numberList[previous] == '-' && i > 0)
                    {
                        previous++;
                        i++;
                    }
                    if (numberList[previous] % 2 != 0 && numberList[i] % 2 != 0)
                    {
                        numberList.Insert(i, '-');
                    }
                }

            }
            string numberDashed = string.Join("", numberList);
            return numberDashed;
        }
    }
}
