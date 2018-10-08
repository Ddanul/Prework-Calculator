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
            //function enter inputs
            Console.Write("Please enter 1st input: ");
            string functionInput1 = Console.ReadLine();
            int functionArg1 = int.Parse(functionInput1);
            Console.Write("Please enter 2nd input: ");
            string functionInput2 = Console.ReadLine();
            int functionArg2 = int.Parse(functionInput2);

            if (methodToUse == 1)
            {
                //invoking Add method using user inputs
                Console.WriteLine($"The sum of those two numbers is: {Add(functionArg1, functionArg2)}");
            }
            else if (methodToUse == 2)
            {
                //invoking Subtract method using user inputs.
                Console.WriteLine($"The difference of the two numbers is: {Subtract(functionArg1, functionArg2)}");
            }
            else if (methodToUse == 3)
            {
                //invoking Multiply method using user inputs.
                Console.WriteLine($"The product of the two numbers is: {Multiply(functionArg1, functionArg2)}");
            }
            else if (methodToUse == 4)
            {
                //incoking Divide method using user inputs.
                Console.WriteLine($"The quotient of the two numbers is: {Divide(functionArg1, functionArg2)}");
            }
            else { Console.WriteLine("Invalid selection.  Please restart the app and try again."); }
            Console.ReadLine();
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static decimal Divide(decimal num1, decimal num2){
            return num1 / num2;
        }
    }
}
