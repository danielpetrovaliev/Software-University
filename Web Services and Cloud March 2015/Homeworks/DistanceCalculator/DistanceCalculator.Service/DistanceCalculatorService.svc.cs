using System;

namespace DistanceCalculator.Service
{
    public class DistanceCalculatorService : IDistanceCalculatorService
    {
        public double CalcDistance(Point startPoint, Point endPoint)
        {
            int deltaX = startPoint.X - endPoint.X;
            int deltaY = startPoint.Y - endPoint.Y;

            return Math.Sqrt(deltaX*deltaX + deltaY*deltaY);
        }
    }
}
