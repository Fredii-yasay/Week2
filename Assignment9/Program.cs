namespace Assignment9
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

            //Display result of the grade
            Console.WriteLine($"Grade: You got {grade}");

            //Display the feedback
            GetGradeFeedback(grade);
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

        void GetGradeFeedback(string grade)
        {
            if (grade == "A")
            {
                Console.WriteLine("Feedback: Excellent Work!");
            }
            else if (grade == "B")
            {
                Console.WriteLine("Feedback: Good job, but there's room for improvement.");
            }
            else if (grade == "C")
            {
                Console.WriteLine("Feedback: You passed, but consider reviewing the material.");
            }
            else if (grade  == "D")
            {
                Console.WriteLine("Feedback: Barely passed, you should work harder.");
            }
            else if (grade == "F")
            {
                Console.WriteLine("Feedback: Failed, please seek help.");
            }
        }
    }
}
