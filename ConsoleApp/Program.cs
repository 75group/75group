using System;

namespace ConsoleApp
{
    static class Program
    {
        /// <summary>
        /// my code displays the sum of all even elements of the array from 0 to the number specified by the user
        /// </summary>
        static void EvenSum()
        {
            int sum = 0;
            int i;
            Console.WriteLine($"Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 0; i <= n; i+=2)
            {
                sum += i;
            }
            Console.WriteLine("The sum of the even numbers is {0}", sum);
            Console.ReadKey(true);
        }
        /// <summary>
        /// my code displays the sum of all primes from 0 to the number specified by the user
        /// </summary>
        static void PrimeSum()
        {
            int sum=0;
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (IsSimple(i)==true)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum of all primes {0}", sum);
            Console.ReadKey();
        }
        /// <summary>
        /// this method determines is a prime number
        /// </summary>
        /// <param name="a">in number</param>
        /// <returns></returns>
        static bool IsSimple (int a)
        {
            int kd = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a%i==0)
                {
                    kd++;
                }
            }
            if (kd == 2)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// implemented a method that displays the value to the console depending on the number entered by the user
        /// </summary>
        static void Cheers()
        {
            Console.WriteLine("Enter your yards");
            int yards = Convert.ToInt32(Console.ReadLine());
            if (yards < 1)
            {
                Console.WriteLine("Shh!!!");
            }
            else if(yards <= 10)
            {
                for (int i = 1; i <= yards; i++)
                {
                    Console.Write("Ra!");
                }
            }
            else 
            {
                Console.WriteLine("High Five!");
            }

        }
        /// <summary>
        /// metod Fibbonacci
        /// </summary>
        static void Fibbonacci()
        {
            Console.WriteLine("Enter the Fibonacci Number Serial Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int perv = 1;
            Console.Write("{0}", perv);
            int vtor = 1;
            Console.Write("{0}", vtor);
            int fib = 0;
            while (number >= fib)
            {
            fib = perv + vtor;
            Console.Write("{0}", fib);
            perv = vtor;
            vtor = fib;
            }
        }
        /// <summary>
        /// This method checks if the user-entered number is gapful
        /// </summary>
        static void Gapful()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int firstNumber = a / 100;
            int thirdNumber = a % 100 % 10;
            int combineNumber = firstNumber * 10 + thirdNumber;
            
            if (a % combineNumber == 0)
                Console.WriteLine("Gapful");
            else
            {
                Console.WriteLine("Not Gapful");
            }
        }
        /// <summary>
        /// This method displays all gapful numbers from 100 to 999.
        /// </summary>
        static void GapfulRunge()
        {
            for (int number=100; number <= 999; number++)
            {
                int firstNumber = number / 100;
                int thirdNumber = number % 100 % 10;
                int combineNumber = firstNumber * 10 + thirdNumber;
                if (number % combineNumber == 0)
            {
                Console.WriteLine($"{number} is gapful number");
            }
            }
            
        }
        /// <summary>
        ///  method for comparing two numbers that returns true if the numbers are equal and false if not.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static bool CompareInt(int a, int b)
        {
            return a == b;
        }
            
        static void Main()
        {
        //EvenSum();
        //PrimeSum();
        //Cheers();
        //Fibbonacci();
        //Gapful();
        //GapfulRunge();
        bool a = CompareInt(1,1);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
