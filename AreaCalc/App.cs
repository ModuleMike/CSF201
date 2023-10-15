namespace AreaCalc

{
    public class App
    {
        private ConsoleIO _io = new ConsoleIO();
        public void Run()
        {
            int menuNum = 0;
            do
            {
                menuNum = _io.GetMenuChoice();
                
                if (menuNum == 1)
                {
                    CalculateRectangle();
                }
                else if(menuNum == 2)
                {
                    CalculateCircle();
                }
                else if(menuNum == 3)
                {
                    CalculateTrianagle();
                }
                if(menuNum != 4)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            } while (menuNum != 4);
        }
        private void CalculateRectangle()
        {
            Rectangle _rec = new Rectangle();

            Console.Write("\nEnter Length: ");
            double length = _io.GetPositiveValue(Console.ReadLine());

            Console.Write("Enter Width: ");
            double width = _io.GetPositiveValue(Console.ReadLine());

            Console.WriteLine($"\nThe area of a rectangle {length}x{width} is {_rec.GetArea(length, width)}.");
        }
        private void CalculateCircle()
        {
            Circle _circ = new Circle();

            Console.Write("\nEnter Radius: ");
            double radius = _io.GetPositiveValue(Console.ReadLine());

            Console.WriteLine($"\nThe radius of a circle with radius {radius} is {_circ.GetArea(radius)}.");
        }
        private void CalculateTrianagle()
        {
            Triangle _tri = new Triangle();

            Console.Write("\nEnter Base: ");
            double tBase = _io.GetPositiveValue(Console.ReadLine());

            Console.Write("Enter Height: ");
            double tHeight = _io.GetPositiveValue(Console.ReadLine());

            Console.WriteLine($"\nThe radius of a triangle with a base {tBase} and height {tHeight} is {_tri.GetArea(tBase, tHeight)}.");
        }
    }
}
