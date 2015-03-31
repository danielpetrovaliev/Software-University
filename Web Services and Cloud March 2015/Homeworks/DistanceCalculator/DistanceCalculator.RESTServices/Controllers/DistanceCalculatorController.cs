using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DistanceCalculator.RESTServices.Models;
using DistanceCalculator.RESTServices.Requests;

namespace DistanceCalculator.RESTServices.Controllers
{
    [RoutePrefix("api")]
    public class DistanceCalculatorController : ApiController
    {
        [Route("calculateDistance")]
        [HttpPost]
        public IHttpActionResult CalculateDistance(CalculateDistanceRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            int deltaX = request.StartPoint.X - request.EndPoint.X;
            int deltaY = request.StartPoint.Y - request.EndPoint.Y;
            double result = Math.Sqrt(deltaX*deltaX + deltaY*deltaY);

            return Ok(result);
        }
    }
}
