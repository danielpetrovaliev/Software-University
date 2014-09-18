using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Battery
{
    private string description;
    private double lifeInHours;

    public string Description
    {
        get { return this.description; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException("Description can not be null");
            }
            this.description = value;
        }
    }

    public double LifeInHours 
    {
        get { return this.lifeInHours;}
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Life in Hours can not be negative");
            }
        } 
    }

    //Constructor
    public Battery(string description, double batteryLifeinHours)
    {
        this.Description = description;
        this.LifeInHours = batteryLifeinHours;
    }
    

    public override string ToString()
    {
        string result = "";
        if (this.Description != null)
        {
            result = String.Format(
            "({0}, {1} hours)", this.Description, this.LifeInHours);
        }
        else
        {
            result = "(" + this.LifeInHours +" hours)";
        }
        return result;
    }
}