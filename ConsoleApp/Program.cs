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
        static void Main()
        {
            EvenSum();
            Console.WriteLine("75group");
        }
    }
}
