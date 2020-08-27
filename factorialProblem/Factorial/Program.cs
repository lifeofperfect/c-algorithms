using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for a number
            Console.WriteLine("Please provide a number");
            int factorialNumber = Int32.Parse(Console.ReadLine());

            //result of the factorial
            int factorialResult = 1;

            //check if provided number is less or greater than zero
            if(factorialNumber < 0)
            {
                Console.WriteLine("Please provide a number greater than 0");
            }else
            {
                //find factorial
                for (int i = 1; i <= factorialNumber; i++)
                {
                    factorialResult = factorialResult * i;
                }

                //result of the factorial
                Console.WriteLine("{0}! has a factorial of {1}", factorialNumber, factorialResult);
            }

            
        }
    }
}
