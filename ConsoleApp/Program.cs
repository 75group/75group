using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    static class Program
    {
        static void Main()
        {
            Password();
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
        /// output to the console prime numbers of input number and input sum prime numders
        /// </summary>
        public static void PrimaNumber()
        {
            bool isPrimaNumber;
            do
            {
                Console.WriteLine("Enter the number to which you need to find prime numbers (number mast be > 1)");
                try
                {
                    isPrimaNumber = true;
                    int number = Convert.ToInt32(Console.ReadLine());
                    int variable;
                    int sum = 0;
                    for (int inputNumber = 0; inputNumber <= number; inputNumber++)
                    {
                        variable = 0;
                        for (int x = 1; x <= number; x++)
                        {
                            if (inputNumber % x == 0)
                            {
                                variable++;
                            }
                        }
                        if (variable == 2)
                        {
                            sum += inputNumber;
                            Console.WriteLine($"{inputNumber}");
                        }
                    }
                    Console.WriteLine($"Sum all prime numbers = {sum}");
                }
                catch (Exception e)
                {
                    isPrimaNumber = false;
                    Console.WriteLine(e.Message);
                }
            }
            while (!isPrimaNumber);
        }
        /// <summary>
        /// method create passwopd and checks its compliance
        /// </summary>
        public static void Password()
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]");
            Console.WriteLine("input your password");
            string password = Console.ReadLine();

            if(password.Length < 5)
            {
                Console.WriteLine("Sorry your password most be at least 5 characters");
            }
            else if (password.Length > 10)
            {
                Console.WriteLine("Sorry your password most be no more than 10 characters");
            }
            foreach(char sr in password)
            {
                if()
            }



            Console.ReadKey();
        }
    }
}
