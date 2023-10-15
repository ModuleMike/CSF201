namespace AreaCalc

{
    public class ConsoleIO
    {
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Area Calculator");
            Console.WriteLine("=================");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Quit\n");      
        }
        public int GetMenuChoice()
        {
            int menuNum = 0;
            DisplayMenu();
            do
            {
                Console.Write("Enter choice: ");
                if (int.TryParse(Console.ReadLine(), out menuNum) && menuNum < 4 && menuNum > 0)
                {
                        return menuNum;
                }
                else if (menuNum == 4)
                {
                    return menuNum;
                }

                Console.WriteLine("Invalid input!\n");

            } while (true);
        }
        public double GetPositiveValue(string input)
        {
            double valNum;
            do
            {
                if (double.TryParse(input, out valNum))
                {
                    return valNum;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Invalid input!\n");
                        Console.Write("Please Enter Another Number: ");
                        if (double.TryParse(Console.ReadLine(), out valNum))
                        {
                            return valNum;
                        }
                    } while (true);     
                }                
            } while (true);
        }
    }
}
