namespace MindBoxLib
{
    public class SquareMeter
    {
        static double FindSquare(params double[] sides)
        {
            switch (sides.Length)
            {
                case 1:
                    return Math.PI * sides[0] * sides[0];
                case 3:
                    double p = sides.Sum() / 2;
                    return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
                default:
                    throw new ArgumentException("App doesn`t support this figure");
            }
        }
    }
}