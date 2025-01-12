namespace Assignment2
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
            //Asks the user for an integer
            Console.WriteLine("Enter an integer: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            if (isEven(num))
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
        }

        //Method of checking if the number is even
        bool isEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
