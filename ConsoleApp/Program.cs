using System;

namespace ConsoleApp
{
    static class Program
    {
        static void Main()
        {
            PrimeSum();
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
    }
}
