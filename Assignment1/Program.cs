namespace Assignment1
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
            //Asks the User for age input (assume they type in a nummber)
            Console.WriteLine("Hello, what is your age? ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            //If user passes the condition, they may pass, if not, they cannot
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }
        }
    }
}
