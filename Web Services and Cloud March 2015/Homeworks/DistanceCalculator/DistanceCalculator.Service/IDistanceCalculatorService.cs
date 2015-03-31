using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DistanceCalculator.Service
{
    [ServiceContract]
    public interface IDistanceCalculatorService
    {
        [OperationContract]
        double CalcDistance(Point startPoint, Point endPoint);
    }

    [DataContract]
    public class Point
    {
        [DataMember]
        public int X { get; set; }

        [DataMember]
        public int Y { get; set; }
    }
}
