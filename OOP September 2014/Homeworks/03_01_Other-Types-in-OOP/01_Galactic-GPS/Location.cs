using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum Planet
{
    Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
}
public struct Location
{
    private double latitude;
    private double longitude;
    private Planet planet;

    public Location(double latitude, double longitude, Planet planet) : this()
    {
        this.Latitude = latitude;
        this.Longitude = longitude;
        this.Planet = planet;
    }


    public double Latitude 
    {
        get { return this.latitude; }
        set { this.latitude = value; }
    }
    public double Longitude 
    {
        get { return this.longitude; }
        set { this.longitude = value; } 
    }
    public Planet Planet 
    {
        get { return this.planet;}
        set { this.planet = value;}
    }

    

    public override string ToString()
    {
        string result = String.Format("{0}, {1} - {2}", this.latitude, this.longitude, this.planet);
        return result;
    }
}