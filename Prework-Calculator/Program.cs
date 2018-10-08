using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add function enter inputs
            Console.Write("Please enter 1st input for Add function: ");
            string addFunctionInput1 = Console.ReadLine();
            int addFunctionArg1 = int.Parse(addFunctionInput1);
            Console.Write("Please enter 2nd input for Add function: ");
            string addFunctionInput2 = Console.ReadLine();
            int addFunctionArg2 = int.Parse(addFunctionInput2);
            //invoking Add function using user inputs
            Console.WriteLine($"The sum of those two numbers is: {Add(addFunctionArg1, addFunctionArg2)}");

            
            Console.ReadLine();
        }

        static int Add(int add1, int add2)
        {
            return add1 + add2;
        }
    }
}
