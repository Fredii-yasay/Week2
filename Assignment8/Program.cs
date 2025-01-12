namespace Assignment8
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
            //Asks the user for a number from 1-7
            Console.WriteLine("Please write a number from 1-7: ");
            string input = Console.ReadLine();
            int daynum = int.Parse(input);

            string day = GetDayOfWeek(daynum);

            //Displays the input
            Console.WriteLine($"The day is: {day}");
        }

        //Method to get the day of the week from input
        string GetDayOfWeek(int day)
        {
            string result = " ";
            switch (day)
            {
                case 1: //If input is 1, it is a Monday
                    result = "Monday";
                    break;

                case 2: //If input is 2, it is Tuesday
                    result = "Tuesday";
                    break;

                case 3: //If input is 3, it is Wednesday
                    result = "Wednesday";
                    break;

                case 4: //If input is 4, it is Thursday
                    result = "Thursday";
                    break;

                case 5: //If input is 5, it is Friday
                    result = "Friday";
                    break;

                case 6: //If input is 6, it is Saturday
                    result = "Saturday";
                    break;

                case 7: //If input is 7, is it Sunday
                    result = "Sunday";
                    break;

                default: //If input is beyond the scope, return Wrong
                    result = "Wrong";
                    break;
            }

            return result;
        }
    }
}
