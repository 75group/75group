using System;

namespace ConsoleApp
{
    static class Program
    {
        static void Main()
        {
            //Gapfull();
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
    }
}
