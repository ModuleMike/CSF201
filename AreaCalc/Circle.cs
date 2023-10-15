namespace AreaCalc

{
    public class Circle
    {
        public double GetArea(double radius)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }
    }
}
