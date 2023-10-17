

using static System.Formats.Asn1.AsnWriter;

namespace SlopeofaLine
{
    public class Line
    {
        public Point StartPoint { get; private set; }
        public Point EndPoint { get; private set; }
        public bool Vertical { get { return StartPoint.X - EndPoint.X == 0; } }

        public Line(Point start, Point end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public double CalculateSlope()
        {
            if(Vertical)
            {
                return 0;
            }
            return (EndPoint.Y - StartPoint.Y) - (EndPoint.X - StartPoint.X);
        }

            
        

    }
}
