using System;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");
            Console.WriteLine("Please enter number as per options");
            Console.WriteLine("1: For Fibonacci series");
            Console.WriteLine("2: For checking Perfect number");
            Console.WriteLine("3: For finding prime number");
            Console.WriteLine("4: For finding reverse number");

            int check = Convert.ToInt32((string)Console.ReadLine());
            switch (check)
            {

                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.FibonacciSeries();
                    break;
                case 2:
                    PerfectNum perfectNum = new PerfectNum();
                    perfectNum.Perfect_Num();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.PrimeNum();
                    break;
                case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.ReverseNum();
                    break;
                default:
                    Console.WriteLine("Please SELECT correct number ! ");
                    break;

            }

        }
    }
}