namespace GuessG
{
    public class App
    {
        public static void Run()

        { 
            GameManager session = new GameManager();
            bool replay = true;

            while (replay) {
                Console.Clear();
                Console.WriteLine("Welcome to the Guessing Game!");
                int maxValue = ConsoleIO.MaxValue();
                session.SecretNumber(maxValue);
                session.Match();
                replay = ConsoleIO.Replay();
            }
        }

    }
}
