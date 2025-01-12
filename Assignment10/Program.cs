namespace Assignment10
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
            //Asks the user to enter a character
            Console.WriteLine("Enter a letter: ");
            string input = Console.ReadLine();

            if (IsLetterVowel(input))
            {
                Console.WriteLine("Your letter is a vowel");
            }
            else
            {
                Console.WriteLine("Your letter is a consonant");
            }
        }

        //Checks if the letter is a vowel
        bool IsLetterVowel(string input)
        {
            bool result = false;
            switch (input)
            {
                case "a":
                    result = true;
                    break;

                case "e":
                    result = true;
                    break;

                case "i":
                    result = true;
                    break;

                case "o":
                    result = true;
                    break;

                case "u":
                    result = true;
                    break;
            }

            return result;
        }
    }
}
