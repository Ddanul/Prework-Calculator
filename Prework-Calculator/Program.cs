using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input to select which method to use.
            Console.Write("Type number to choose method - (1) Add, (2) Subtract, (3) Multiply, (4) Divide: ");
            string method = Console.ReadLine();
            int methodToUse = int.Parse(method);

            //Add function enter inputs
            Console.Write("Please enter 1st input: ");
            string functionInput1 = Console.ReadLine();
            int addFunctionArg1 = int.Parse(functionInput1);
            Console.Write("Please enter 2nd input: ");
            string functionInput2 = Console.ReadLine();
            int addFunctionArg2 = int.Parse(functionInput2);

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
