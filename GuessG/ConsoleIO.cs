namespace GuessG
{
    public class ConsoleIO
    {
        public static int MaxValue()
        {  
            while (true)
            {
                Console.Write("Enter the maximum value for the number you are seeking: ");
                if (int.TryParse(Console.ReadLine(), out int max))
                {
                    if (max > 0)
                    {
                        return max;
                    }
                }
                Console.WriteLine("\nInvalid input. Value must be greater than 1.");
            }
        }
        public static int Guess(int maxValue)
        {
            while (true)
            {
                Console.Write("Enter your guess: ");
                if (int.TryParse(Console.ReadLine(), out int guess) && guess > 0 && guess <= maxValue)
                {
                    return guess;
                }
                Console.WriteLine($"\nInvalid input. Value must be between 1 and {maxValue}");
            }
        }
        public static bool Replay()
        {
            while (true)
            {      
                Console.Write("Would you like ot play again? (yes/no): ");
                string input = Console.ReadLine().ToUpper().Trim();
                    if(input == "NO")
                    {
                        return false; 
                    }
                    else if(input == "YES")
                    {
                        return true;
                    }                
                Console.WriteLine("\nInvalid input. Please select 'yes' or 'no'!");
            }
        }
    }
}