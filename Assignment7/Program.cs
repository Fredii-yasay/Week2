namespace Assignment7
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
            //Asks the user for the year
            Console.WriteLine("What year is it? ");
            string input = Console.ReadLine();
            int year = int.Parse(input);

            //if-else statement to display input depending on the year
            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }

        //?thod to check if the inputted year is a leap year or not
        bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && (!(year % 100 == 0) || year % 400 == 0)); 
        }
    }
}
