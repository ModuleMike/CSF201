

using System.Reflection;

namespace SlopeofaLine
{
    public class ConsoleIO
    {

       public static Point GetPoint (string prompt)
        {
            Console.WriteLine(prompt);

            double x = GetCoordinateValue("Eneter X Coordinate: ");
            double y = GetCoordinateValue("Enter Y Coordinate: ");

            return new Point(x, y);

        }

        private static double GetCoordinateValue(string prompt)
        {
            double coord;

            do
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out coord))
                {
                    return coord;
                }
                Console.WriteLine("Invalid value, please provide a decimal value.");

            }while(true);
        }
        public static void OutputSlope(Line line)
        {
            if (line.Vertical)
            {
                Console.WriteLine($"A line with points {DisplayCoordinate(line.StartPoint)} and {DisplayCoordinate(line.EndPoint)}");
                return;
            }
            Console.WriteLine($"The slope of a line with points {DisplayCoordinate(line.StartPoint)} and {DisplayCoordinate(line.EndPoint)} is {line.CalculateSlope()}.");
        }
        private static string DisplayCoordinate(Point point)
        {
            return $"({point.X},{point.Y})";
        }
    }
}
