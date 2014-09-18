using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Computer
{
    private string name;
    private List<Component> components;


    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Computer Name can not be null or empty");
            }
            this.name = value;
        }
    }
    public List<Component> Components
    {
        get { return this.components; }
        set
        {
            if (value == null)
            {
                throw new ArgumentException("Components can not be null");
            }
            this.components = value;
        }
    }

    public decimal Price
    {
        get { return this.Components.Sum(a => a.Price);}
    }


    //Constructor
    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.Components = components;
    }

    public override string ToString()
    {
        decimal totalPrice = 0.0m;
        string result = String.Format("Computer: \n Name:{0}\n Components: \n", this.Name);
        foreach (Component component in Components)
        {
            result += component + "\n";
            totalPrice += component.Price;

        }

        result += "Price: " + totalPrice + " BGN";
        return result;
    }
}