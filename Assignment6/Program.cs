namespace Assignment6
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
            //Asks the user what their score is on a test
            Console.WriteLine("What is your score? ");
            string input = Console.ReadLine();
            int score = int.Parse(input);

            string grade = CalculateGrade(score);

            //Display result
            Console.WriteLine($"You got {grade}");
        }

        //Method that returns the grade after calculating
        string CalculateGrade(int score)
        {
            string grade = " ";

            if (score >= 90 && score <= 100) 
            {
                grade = "A";
            }
            else if (score >= 80 && score <= 89)
            {
                grade = "B";
            }
            else if (score >= 70 && score <= 79)
            {
                grade = "C";
            }
            else if (score >= 60 && score <= 69)
            {
                grade = "D";
            }
            else if (score >= 0 && score <= 59)
            {
                grade = "F";
            }

            return grade;
        }
    }
}
