namespace TheLockedDoor
{
    public class Prompt
    {
        public static int SetPasscode()     // Prompt Request Starting Passcode
        {
            while (true)
            {
                Console.Write("\nSet Passcode :  ");
                if (int.TryParse(Console.ReadLine(), out int newPasscode))
                {
                    Console.Clear();
                    return newPasscode;
                }
                InvalidInput();
            }
        }
        public static int EnterPasscode()   // Prompt Enter Passcode
        {
            while (true)
            {
                Console.Write("\nEnter Passcode:  ");
                if (int.TryParse(Console.ReadLine(), out int passcode))
                {
                    return passcode;
                }
                else InvalidInput();
            }
        }
        public static string RequestDoorPrompt()
        {
            while (true)
            {
                Console.Write("\nDo you want to Open, Close, Lock, or Unlock the door?  ");
                string response = Console.ReadLine().Trim().ToLower();
                if (response == "open" || response == "close" || response == "lock" || response == "unlock")
                {
                    return response;
                }
            }
        }
        public static void InvalidInput()   // Prompt Invalid Input
        {
            Console.WriteLine($"That is not a valid input... Try something else...\n");
        }
        public static void InvalidRequest()   // Prompt Invalid Input
        {
            Console.WriteLine($"That doesn't work... Try something else...\n");
        }
        public static (string, string) CurrentDoorStatus(bool open, bool unlock)
        {
            (string o, string u) response = (OpenCloseStatus(open), UnlockLockStatus(unlock));
            Console.WriteLine($"The door is currently {response.o} and {response.u}");
            return response;
        }
        public static string OpenCloseStatus(bool open)
        {
            if (open)
            {
                return "open";
            }
            else return "closed";
        }
        public static string UnlockLockStatus(bool unlock)
        {
            if (unlock)
            {
                return "unlocked";
            }
            else return "locked";
        }
    }
}