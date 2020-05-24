using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an upper bound integer");
            int input = int.Parse(Console.ReadLine()); // Takes upper Bound from user

            int i = 1;

            List<int> primes = new List<int>(1);
            while (i <= input)
            {
                if (IsPrime(i) == true)
                {
                    primes.Add(i);
                    i++;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("\u03C0(" + input + ") = " + primes.Count); // Shows value of Pi()
            Console.WriteLine("Would you like to see the primes? (Y/N)");

            string primeShow = Console.ReadLine();

            if (primeShow == "Y")
            {
                int j = 0;
                while (j < primes.Count)
                {
                    Console.WriteLine(primes[j]);
                    j++;
                }
            }
            else
            {
                System.Environment.Exit(69); ;
            }
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
