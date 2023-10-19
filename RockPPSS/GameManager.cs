
namespace RockPPSS
{
    public class GameManager
    {
        Random _rand = new Random();
        int _win = 0;
        int _lose = 0;
        int _tie = 0;

        public string CompChoice()
        {
            
            int choice = _rand.Next(1, 4);
            if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }
        public void Match(string playerChoice, string compChoice)
        {
            if(playerChoice == compChoice)
            {
                Console.WriteLine($"You picked {playerChoice} and the Computer picked {compChoice}.");
                Console.WriteLine("You Tied!");
                _tie++;
            }
            else if (playerChoice == "Rock" && compChoice == "Scissors" ||  playerChoice == "Paper" && compChoice == "Rock" || playerChoice == "Scissors" && compChoice == "Paper")
            {
                Console.WriteLine($"You picked {playerChoice} and the Computer picked {compChoice}.");
                Console.WriteLine("You Won!");
                _win++;
            }
            else
            {
                Console.WriteLine($"You picked {playerChoice} and the Computer picked {compChoice}.");
                Console.WriteLine("You Lost!");
                _lose++;
            }
        }
        public void GameReport()
        {
            Console.WriteLine("Game Summary:");
            Console.WriteLine($"Wins: {_win}");
            Console.WriteLine($"Losses: {_lose}");
            Console.WriteLine($"Ties: {_tie}");
            Console.WriteLine("Thank you for playing Rock, Paper, Scissors!");
        }

    }
}
