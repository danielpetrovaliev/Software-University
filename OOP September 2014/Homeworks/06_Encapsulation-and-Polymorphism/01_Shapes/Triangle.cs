using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    public class Triangle : BasicShape
    {

        private double includedAngle;

        public double IncludedAngle
        {
            get
            {
                return this.includedAngle;
            }

            set
            {
                if (value < 0 || value > 360)
                {
                    throw new ArgumentOutOfRangeException(
                        "IncludedAngle", "The included angle accepts only values between 0 and 360 deg");
                }

                this.includedAngle = value;
            }
        }

        public Triangle(double width, double height, double includedAngle)
            : base(width, height)
        {
            this.IncludedAngle = includedAngle;
        }

        public override double CalculateArea()
        {
            return (Math.Sin(this.IncludedAngle * Math.PI / 180) * this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width + this.Height + Math.Sqrt((this.Width * this.Width) 
                + (this.Height * this.Height) - (2 * this.Height * this.Width * Math.Cos(this.IncludedAngle * Math.PI / 180)));
        }
    }
}
