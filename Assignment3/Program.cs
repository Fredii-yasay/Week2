namespace Assignment3
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
            //Asks user to enter an integer
            Console.WriteLine("Please input a number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            //Check value and change string 
            string check = CheckNumber(num);

            Console.WriteLine($"Your number is a {check}");
        }

        //Method to determine whether the number is positive, negative, or zero
        string CheckNumber(int number)
        {
            string result = " ";

            if (number == 0)
            {
                result = "zero";
            }
            else if (number > 0)
            {
                result = "positive";
            }
            else if (number > 0)
            {
                result = "negative";
            }

            return result;
        }
    }
}
