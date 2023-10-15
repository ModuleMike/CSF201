namespace AboutMe
{
    public static class Prompter
    {      
        public static string ValidString(string prompt)
        {
            string input;
            int intPut;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                Console.WriteLine("You must enter atleast one character!");  
            } while (true);
        }
        public static DateTime ValidDateTime(string date)
        {
            DateTime input;
            do
            {
                Console.Write(date);
                if(DateTime.TryParse(Console.ReadLine(), out input))
                {
                    if(DateTime.Today > input)
                    {
                        return input;
                    }
                }
                Console.WriteLine("You must enter a valid date!");
            } while (true);
        }
        public static int ValidInt(string age, int min, int max)
        {
            int input;
            do
            {  
                Console.Write(age);
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if(input >= min && input <= max)
                    {
                        return input;
                    }
                }
                Console.WriteLine($"You must enter a valid Age between {min} and {max}!");
            } while (true);
        }
        public static string ValidChar(string status)
        {
            string input;
            do
            {
                input = Console.ReadLine().ToUpper();
                

                if (input == "S" || input == "M")
                {
                    return input;
                }
                Console.WriteLine("You must enter (S)ingle or (M)arried!");

            } while (true);
        }
    }
}
