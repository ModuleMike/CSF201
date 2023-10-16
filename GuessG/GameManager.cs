namespace GuessG
{
    public class GameManager
    {
        Random randy = new Random();
        private int _number;
        private int _maxValue;
        private int _count = 1;
        public void SecretNumber(int maxValue)
        {
            _number = randy.Next(1, maxValue + 1);
            _maxValue = maxValue;
        }
        public void Match()
        {
            Console.WriteLine($"\nI'm thinking of a number between 1 and {_maxValue}. Can you guess it?");
            do
            {
                int guess = ConsoleIO.Guess(_maxValue);
                {
                    if (guess == _number)
                    {
                        Console.WriteLine("You got it!");
                        Console.WriteLine($"It took you {_count} guesses.\n");
                        break;
                    }
                    else if (guess < _number)
                    {
                        Console.WriteLine("Higher\n");
                        _count++;
                    }
                    else
                    {
                        Console.WriteLine("Lower\n");
                        _count++;
                    }
                }
            } while (true);
        }
    }
}