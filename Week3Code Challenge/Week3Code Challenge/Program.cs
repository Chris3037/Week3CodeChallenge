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
            //EvenFibonacciSequencer(2000000);
            //LongestCollatzSequencer();
            End();
        }

        //FindManyPrimes Functions
        static void FindManyPrimes(int thisMany)
        {
            int primeNums = 0;
            int number = 1;

            while(primeNums < thisMany)
            {
                if (IsPrime(number))
                {
                    primeNums++;
                }
                number++;
            }
            Console.WriteLine(number-1);
        }

        //IsPrime
        public static bool IsPrime(int number)
        {
            if (number == 2 || number == 3 || number == 5 || number == 7)
            {
                return true;
            }
            else if (number % 1 == 0 && number % number == 0 && number % 2 != 0 && number % 3 != 0 && number % 4 != 0 && number % 5 != 0 && number % 6 != 0 && number % 7 != 0 && number % 8 != 0 && number % 9 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //EvenFibonacciSequencer Function
        static void EvenFibonacciSequencer(int maxValue)
        {

        }

        //LongestCollatzSequencer Function
        static void LongestCollatzSequencer()
        {
            int counter = 0;
            for (int i = 0; i == 1 ; i++)
            {
            }
                Console.WriteLine(counter);
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
