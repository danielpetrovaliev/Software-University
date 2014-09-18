using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Component
{
    private string name;
    private string details;
    private decimal price;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Component Name can not be null or empty");
            }
            this.name = value;
        }
    }

    public string Details
    {
        get { return details; }
        set { this.details = value; }
    }

    public decimal Price
    {
        get { return price; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Price can not be negative");
            }
            this.price = value; 
        }
    }

    //Constructor
    public Component(string name, string details, decimal price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }
    public Component(string name, decimal price)
        : this(name, null, price)
    {
    }

    public override string ToString()
    {
        string result = String.Format("   Component: (Name: {0}, ", this.Name);
        if (this.Details != null)
        {
            result += "Details: " + this.Details + ", ";
        }

        result += " Price: " + this.Price + ")";
        return result;
    }
}

