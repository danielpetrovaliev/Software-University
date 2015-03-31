using DistanceCalculator.RESTServices.Models;

namespace DistanceCalculator.RESTServices.Requests
{
    public class CalculateDistanceRequest
    {
        public Point StartPoint { get; set; }

        public Point EndPoint { get; set; }
    }
}