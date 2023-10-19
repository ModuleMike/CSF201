

namespace RockPPSS
{
    public class App
    {

        public static void Run()
        {
            bool replay = true;
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            GameManager game = new GameManager();
            while (replay)
            {
                string playerChoice = ConsoleIO.PlayerChoice();
                string compChoice = game.CompChoice();
                game.Match(playerChoice, compChoice);
                replay = ConsoleIO.PlayAgain();
            }
            game.GameReport();

        }

    }
}
