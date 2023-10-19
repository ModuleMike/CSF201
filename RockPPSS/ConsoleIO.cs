namespace RockPPSS
{
    public class ConsoleIO
    {
        public static string PlayerChoice()
        {          
            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter your choice (R)ock, (P)aper, (S)cissors: ");
                char input = Console.ReadKey().KeyChar;
                if (char.ToUpper(input) == 'R')
                {
                    Console.WriteLine();
                    return "Rock";
                }
                else if (char.ToUpper(input) == 'P')
                {
                    Console.WriteLine();
                    return "Paper";
                }
                else if (char.ToUpper(input) == 'S')
                {
                    Console.WriteLine();
                    return "Scissors";
                }
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please choose between (R) / (P) / (S)");
            }
        }
        public static bool PlayAgain()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Do you want to play again (Y/N): ");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();
                if (char.ToUpper(input) == 'Y')
                {                   
                    return true;
                }
                else if (char.ToUpper(input) == 'N')
                {
                    return false;
                }
            }
        }
    }
}
