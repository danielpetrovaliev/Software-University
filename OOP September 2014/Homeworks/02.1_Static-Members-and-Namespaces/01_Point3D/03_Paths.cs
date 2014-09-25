using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class _03_Paths
{
    private List<Point3D> Points = new List<Point3D>();

    public _03_Paths(params Point3D[] points)
    {
        this.Points = new List<Point3D>();
        this.Points.AddRange(points);
    }
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("Path: {");
        result.Append(string.Join(", ", this.Points));
        result.Append("}");
        return result.ToString();
    }

    public void WriteToFile(string fileName)
    {
        File.WriteAllText(fileName, this.ToString());
    }
    public static _03_Paths ReadFromFile(string fileName)
    {
        string text = File.ReadAllText(fileName);
        string pattern = @"X = (.*?), Y = (.*?), Z = (.*?)\)";
        Regex rgx = new Regex(pattern);
        MatchCollection matches = rgx.Matches(text);
        _03_Paths path = new _03_Paths();
        for (int i = 0; i < matches.Count; i++)
        {
            double x = Double.Parse(matches[i].Groups[1].Value);
            double y = Double.Parse(matches[i].Groups[2].Value);
            double z = Double.Parse(matches[i].Groups[3].Value);
            Point3D point = new Point3D(x, y, z);
            path.Points.Add(point);
        }
        return path;
    }
}


