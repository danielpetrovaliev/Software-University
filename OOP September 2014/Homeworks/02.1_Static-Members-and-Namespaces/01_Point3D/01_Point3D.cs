using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public static readonly Point3D StartingPoint = new Point3D(0, 0, 0);

    public Point3D(double x, double y, double z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public override string ToString()
    {
        string result = String.Format("(X = {0}, Y = {1}, Z = {2})", this.X, this.Y, this.Z);
        return result;
    }
}

