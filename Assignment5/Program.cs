namespace Assignment5
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
            //Asks user for 3 numbers
            Console.WriteLine("Enter 3 numbers: ");

            //First number
            string input1 = Console.ReadLine();
            int num1 = int.Parse(input1);

            //Second number
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);

            //Third number
            string input3 = Console.ReadLine();
            int num3 = int.Parse(input3);

            //Call method to find maximum
            int maximum = FindMax(num1, num2, num3);
            Console.WriteLine($"The maximum number is {maximum}");
        }

        //Method to find the maximum of the 3 numbers inputted
        int FindMax(int a, int b, int c)
        {
            int result = 0;

            if (a > b && a > c) 
            {
                result = a;
            }
            else if (a < b && b > c)
            {
                result = b;
            }
            else if (b < c && c > a)
            {
                result = c;
            }

            return result;
        }
    }
}
