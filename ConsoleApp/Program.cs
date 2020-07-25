using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

using NUnit.Framework;

namespace ConsoleApp
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine(CompareInt(811181, Squaredigit(9119)));
            Console.WriteLine(CompareInt(9414, Squaredigit(3212)));
            Console.WriteLine(CompareInt(4114, Squaredigit(2112)));
        }
        /// <summary>
        /// print gapful numbers to console from range 100 to 999
        /// </summary>
        public static void Gapfull()
        {
            bool isValid;
            do
            {
                try
                {
                    isValid = true;
                    for (int i = 100; i <= 999; i++)
                    {
                        int firstNumber = i / 100;
                        int secondNumber = (i / 10) % 10;
                        int thirdNumber = i % 10;
                        double factor = (firstNumber * 10) + thirdNumber;

                        if (i % factor == 0)
                            Console.WriteLine($"{i} / {factor} = {i / factor}\t - NUMBER IS GAPFUL");
                    }
                }
                catch (Exception e)
                {
                    isValid = false;
                    Console.WriteLine(e.Message);
                }
            }
            while (!isValid);
        }
        /// <summary>
        /// output to the console the sum of all even numbers up to the number entered from the keyboard
        /// </summary>
        public static void EvenSum()
        {
            bool isCorrectFormatNumber;
            do
            {
                Console.WriteLine("We greet you! In order to calculate the sum of even numbers, enter a number:");
                try
                {
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    isCorrectFormatNumber = true;
                    int summ = 0;
                    
                    for (int i = 0; i <= inputNumber; i++)
                    {
                        if (i % 2 == 0)
                        {
                            summ += i;
                        }
                    }
                    Console.WriteLine($"The sum of all even numbers is: {summ}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\n");
                    isCorrectFormatNumber = false;
                }
            }
            while (!isCorrectFormatNumber);
        }
        /// <summary>
        /// print to console prime numbers and sum of prime numbers between one and entered number;
        /// </summary>
        public static void PrimeSum()
        {
            bool isValid = false;
            int sum = 0;
            int divCount = 0;
            while (!isValid)
            {
                try
                {
                    Console.Write("Enter number: ");
                    int inputNumber = Int32.Parse(Console.ReadLine());
                    for (int i = 1; i < inputNumber; i++)
                    {
                        divCount = 0;
                        for (int j = 1; j < inputNumber; j++)
                        {
                            if(i % j == 0)
                            {
                                divCount++;
                            }
                        }
                        if (divCount == 2)
                        {
                            Console.WriteLine(i + "\t- is prime number!");
                            sum += i;
                        }
                    }
                    isValid = true;
                    Console.WriteLine($"Sum of prime numbers between 1 and {inputNumber} equals {sum}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    isValid = false;
                }
            }
        }
        /// <summary>
        /// method that checks passwords for compliance with certain rules
        /// </summary>
        public static void PasswordValidation()
        {
            bool isValid;
            Regex symbol = new Regex(@"[!@#$%^&*()_+=<>?/,.№;:']");
            Regex letter = new Regex(@"[\p{L}\p{Ll}\p{Lu}]");
            Regex letterUp = new Regex(@"\p{Lu}");
            Regex numeral = new Regex(@"[0-9]");
            Regex space = new Regex(@"\p{Z}");
            do
            {
                Console.WriteLine("Input password");
                string password = Console.ReadLine();
                isValid = true;

                MatchCollection symbolCollections = symbol.Matches(password);
                MatchCollection letterCollections = letter.Matches(password);
                MatchCollection letterUpCollections = letterUp.Matches(password);
                MatchCollection numeralCollections = numeral.Matches(password);
                MatchCollection spaceCollections = space.Matches(password);

                if (password.Length < 5 || password.Length > 10)
                {
                    isValid = false;
                    Console.WriteLine("Your password cannot be less than 5 and not more than 10 characters");
                }
                if (symbolCollections.Count == 0)
                {
                    isValid = false;
                    Console.WriteLine("Password must contain at least one special character");
                }
                if (letterCollections.Count == 0)
                {
                    isValid = false;
                    Console.WriteLine("Password must contain at least one letter");
                }
                if (letterUpCollections.Count == 0)
                {
                    isValid = false;
                    Console.WriteLine("Password must contain at least one uppercase letter");
                }
                if (numeralCollections.Count == 0)
                {
                    isValid = false;
                    Console.WriteLine("Password must contain at least one digit");
                }
                if (spaceCollections.Count >= 1)
                {
                    isValid = false;
                    Console.WriteLine("Password must not contain spaces");
                }
                if((symbolCollections.Count == password.Length) 
                    || (letterCollections.Count == password.Length)
                    || (numeralCollections.Count == password.Length))
                    Console.WriteLine("password security level - low");
                if((symbolCollections.Count == 2)
                    && (letterCollections.Count == 2)
                    && (numeralCollections.Count == 2))
                    Console.WriteLine("password security level - medium");
                if ((symbolCollections.Count >= 3)
                    && (letterCollections.Count >= 3)
                    && (numeralCollections.Count >= 3))
                    Console.WriteLine("password security level - high");
            }
            while (!isValid);
            Console.WriteLine("Your password has been successfully saved in the system !!!!");
        }
        /// <summary>
        /// depending on the entered value, actions are displayed
        /// </summary>
        public static void Cheers()
        {
            Console.WriteLine("Enter the number of yards");
            var x = ReadTypeLine(Convert.ToInt32);

            if (x > 10)
                Console.WriteLine("High Five");
            else if (x < 1)
                Console.WriteLine("shh");
            else if (x >= 1 && x <= 10)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write("Ra!");
                }
            }
        }
        /// <summary>
        /// The method checks if the user entered the value using the input parameter: the delegate
        /// </summary>
        /// <typeparam name="T">GenericType</typeparam>
        /// <param name="convertor">conversion of the entered number to the type specified in a third-party method</param>
        /// <returns></returns>
        public static T ReadTypeLine<T>(Func<string, T> convertor)
        {
            T value = default;
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    value = convertor(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception e)
                {
                    isValid = false;
                    Console.WriteLine(e.Message);
                }
            }
            return value;
        }
        /// <summary>
        /// The method checks the accuracy of user input
        /// </summary>
        /// <returns>return converted result</returns>
        ///
        public static int CorrectFormat()
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    result = Convert.ToInt32(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception e)
                {
                    isValid = false;
                    Console.WriteLine(e.Message);
                }
            }
            return result;
        }
        /// <summary>
        /// calculating a number that is in the series of Fibonacci numbers using recursion
        /// </summary>
        /// <param name="number">keyboard input number that indicates the sequence number in the Fibonacci</param>
        /// <returns></returns>
        public static int FibonacciRecursion(double number)
        {
            if (number == 0)
                return 0;
            else if (number == 1)
                return 1;
            else
            {
                return FibonacciRecursion(number - 1) + FibonacciRecursion(number - 2);
            }
        }
        /// <summary>
        /// When entering through the console the sequence number of the Fibonacci sequence, 
        /// the method displays the Fibonacci number without using recursion method
        /// </summary>
        public static void Fibonacci()
        {
            Console.WriteLine("input number:");
            var number = ReadTypeLine(Convert.ToInt32);
            double firstNumber = 0;
            double secondNumber = 1;
            double sum = default;
            if (number == 0)
                Console.WriteLine(firstNumber);
            if (number == 1)
                Console.WriteLine(number);
            else
                for (int i = 0; i < number; i++)
                {
                    sum = firstNumber + secondNumber;
                    secondNumber = firstNumber;
                    firstNumber = sum;
                }
            Console.WriteLine(sum);
        }
        /// <summary>
        /// method comparing two integers
        /// </summary>
        public static bool CompareInt(int x, int y)
        {
            return x == y;
        }
        /// <summary>
        /// converting seconds to a readable time format
        /// </summary>
        /// <param name="x">input value (in seconds)</param>
        /// <returns></returns>
        public static string Hrt(int x)
        {
            bool isTrue;
            do
            {
                string resul;
                isTrue = true;
                if (x < 0)
                {
                    isTrue = false;
                }
                resul = ($"{x/3600:00}:{(x % 3600) / 60:00}:{(x % 3600) % 60:00}");
                return resul;
            }
            while (!isTrue);
        }
        /// <summary>
        /// method for moving the first letter of each word to the end, then adding “ay” to the end of the word, while the punctuation marks remain untouched
        /// </summary>
        /// <param name="phrase">string type passed parameter</param>
        /// <returns></returns>
        public static string Piglatin(string phrase)
        {
            return string.Join(" ", phrase.Split(" ").Select(x => x.Substring(1) + x[0] + "ay"));
        }
        /// <summary>
        /// method that squares each digit of an entered number no input parameters
        /// </summary>
        public static void MySquaredigit()
        {
            Console.WriteLine("input number:");
            int numb = ReadTypeLine(Convert.ToInt32);
            string x = Convert.ToString(numb);
            string z;
            int q;
            for (int i = 0; i < x.Length; i++)
            {
                x.Split("", x.Length);
                z = Convert.ToString(x[i]);
                q = int.Parse(z);
                Console.WriteLine($"square of a number: {x[i]} = {q * q}");
            }
        }
        /// <summary>
        /// method that squares each digit of an entered number from input parameters
        /// </summary>
        public static int Squaredigit(int numb)
        {
            List<int> list = new List<int>();
            string x = Convert.ToString(numb);
            string w = default;
            string z;
            int q;
            for (int i = 0; i < x.Length; i++)
            {
                x.Split("", x.Length);
                z = Convert.ToString(x[i]);
                q = int.Parse(z);
                q *= q;
                list.Add(q);
                w = string.Concat(list);
            }
            return Convert.ToInt32(w);
        }
    }
}
