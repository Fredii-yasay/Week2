using System.Net.NetworkInformation;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            //Asks the user for 2 integers.
            Console.WriteLine("Please type in 2 integers: ");

            //First number
            string input1 = Console.ReadLine();
            int num1 = int.Parse(input1);

            //Second number
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);

            //Asks user what arithmetic they would like the calculator to perform
            Console.WriteLine("Hello, what calculation would you like to do?");
            Console.WriteLine("1. +   2. -   3. *   4. / ");
            string input3 = Console.ReadLine();
            int arithmetic = int.Parse(input3);
            int Calc = Calculator(arithmetic, num1, num2);

            Console.WriteLine($"The result is {Calc}");
        }
        int Calculator(int arithmetic, int num1, int num2)
        {
            int result = 0;

            switch (arithmetic)
            {
                //Addition arithemetic
                case 1:
                    result = num1 + num2;
                    break;

                //Subtraction arithmetic
                case 2:
                    result = num1 - num2;
                    break;

                //Multiplication arithmetic
                case 3:
                    result = num1 * num2;
                    break;

                //Division arithmetic
                case 4:
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("This is not a valid choice!");
                    break;
            }

            return result;
        }
    }
}
