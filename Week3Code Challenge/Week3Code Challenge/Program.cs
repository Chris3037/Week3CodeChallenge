using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            FindManyPrimes(10001);
            Console.WriteLine();
            EvenFibonacciSequencer(2000000);
            Console.WriteLine();
            LongestCollatzSequencer();
            End();
        }

        //FindManyPrimes Functions
        static void FindManyPrimes(int thisMany)
        {
            int primeNums = 0;
            int number = 2;

            while (primeNums < thisMany)
            {
                if (IsPrime(number))
                {
                    primeNums++;
                }
                number++;
            }
            number--;
            Console.WriteLine("The " + thisMany + "st prime number is " + number);
        }

        //IsPrime
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

        //EvenFibonacciSequencer Function
        static void EvenFibonacciSequencer(int maxValue)
        {
            int number = 2;
            int fibNum = 0;
            int fibOne = 1;
            int fibTwo = 1;
            int fibTemp = 0;
            while (number < maxValue)
            {
                if (fibOne % 2 == 0)
                {
                    fibNum += fibOne;
                }
                fibTemp = fibOne;
                number += fibOne;
                fibOne += fibTwo;
                fibTwo = fibTemp;
            }
            Console.WriteLine("The " + number + "th fibonacci number (minus odds) is " + fibNum);
        }

        //LongestCollatzSequencer Function
        static void LongestCollatzSequencer()
        {
            int onNum = 0;
            int highestCounter = 0;
            int newCounter = 0;
            int highestNum = 0;
            int highestSegment = 0;

            for (int i = 1; i <= 1000000; i++)
            {
                onNum++;
                long number = i;
                int counter = 0;
                int segments = 1;

                while (number != 1)
                {
                    if (number % 2 == 0)
                    {
                        number = number / 2;
                        segments++;
                    }
                    else
                    {
                        number = number * 3;
                        number = number + 1;
                        segments++;
                    }
                    counter++;
                }

                newCounter = counter;
                if (highestCounter < newCounter)
                {
                    highestCounter = counter;
                    highestNum = onNum;
                }
                if (highestSegment < segments)
                {
                    highestSegment = segments;
                }
            }
            Console.WriteLine("The number that produces the longest chain is: " + highestNum);
            Console.WriteLine("That chain is " + highestSegment + " segments long.");
        }

        //End Function
        static void End()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
