﻿using System;

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
        static void Main()
        {
            //EvenSum();
            PrimeSum();
            Console.WriteLine("75group");
        }
    }
}
