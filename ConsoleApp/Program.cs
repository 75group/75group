using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    static class Program
    {
        static void Main()
        {
            PasswordValidation();
            Console.ReadKey();
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
    }
}