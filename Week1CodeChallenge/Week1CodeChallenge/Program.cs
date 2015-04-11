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
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
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
                    if (numberList[previous] % 2 != 0 && numberList[i] % 2 != 0 && char.IsDigit(numberList[previous]))
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
