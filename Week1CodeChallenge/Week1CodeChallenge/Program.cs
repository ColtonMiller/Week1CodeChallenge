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
 
            }
            string yodaTalk = string.Join(" ", yodaArray);
            return yodaTalk;
        }
        public static void TextStats(string input)
        {
            int counter = 0;
            int counterVowel = 0;
            int counterConsonants = 0;
            int counterSpecialChar = 0;
            var vowel = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};
            var specialChar = new HashSet<char> { '.', ',', ' ', '?' };

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
            string loweredInput = input.ToLower();
            for (int i = 0; i < loweredInput.Length ; i++)
            {
                if (char.IsLetter(loweredInput[i]) && vowel.Contains(loweredInput[i]))
                {
                    counterVowel++;
                }
                else if (char.IsLetter(loweredInput[i]))
                {
                    counterConsonants++;
                }
            }
            Console.WriteLine("Number of vowels: {0}", counterVowel);
            Console.WriteLine("Number of consonants: {0}", counterConsonants);
            for (int i = 0; i < input.Length; i++)
            {
                if (specialChar.Contains(input[i]))
                {
                    counterSpecialChar++;
                }
            }
            Console.WriteLine("Number of special characters: {0}", counterSpecialChar);

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
