using System;
using System.Net;
using DistanceCalculator.Client.DistanceCalculatorServiceReference;
using DistanceCalculator.RESTServices.Requests;
using Newtonsoft.Json;

namespace DistanceCalculator.Client
{
    class CalculatorClient
    {
        static void Main()
        {
            DistanceCalculatorServiceClient service = new DistanceCalculatorServiceClient();

            var result = service.CalcDistance(new Point() {X = 1, Y = 2}, new Point() {X = 3, Y = 5});

            Console.WriteLine("Result from soap service: " + result);

            using (WebClient webClient = new WebClient())
            {
                var calcDistanceRequest = new CalculateDistanceRequest()
                {
                    StartPoint = new RESTServices.Models.Point
                    {
                        X = 3,
                        Y = 4
                    },
                    EndPoint = new RESTServices.Models.Point
                    {
                        X = 13,
                        Y = 21
                    }
                };

                webClient.Headers.Set("Content-type", "application/json");

                var distanceRequestAsJsonString = JsonConvert.SerializeObject(calcDistanceRequest);

                var response = webClient.UploadString("http://localhost:24084/Api/calculateDistance",
                    distanceRequestAsJsonString);

                Console.WriteLine();
                Console.WriteLine("Result from web service: " + response);
            }
        }
    }
}
