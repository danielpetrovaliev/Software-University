using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private string screen;
    private decimal price;
    private Battery battery;

    //Constructors
    public Laptop(string model, decimal price, string manufacturer, string processor, string graphicsCard,
        string battery, double batteryLife, string screen, int ram)
    {
        this.Model = model;
        this.Battery = new Battery(battery, batteryLife);
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Screen = screen;
        this.Price = price;
    }
    public Laptop(string model, decimal price, string manufacturer, string processor, string graphicsCard,
        double batteryLife, string screen, int ram)
        : this(model, price, manufacturer, processor, graphicsCard, null, batteryLife, screen, ram)
    {

    }
    public Laptop(string model, decimal price)
        : this(model, price, null, null, null, null, 0, null, 0)
    {

    }


    public string Model
    {
        get { return this.model; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException("Model can't be empty");
            }
            this.model = value;
        }
    }
    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException("Processor can't be empty");
            }
            this.processor = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException("Manufacturer can't be empty");
            }
            this.manufacturer = value;
        }
    }

    public int Ram
    {
        get { return this.ram; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentNullException("Ram can't be negative");
            }
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException("Graphics Card can't be empty");
            }
            this.graphicsCard = value;
        }
    }

    public string Screen 
    {
        get { return this.screen; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException("Screen can't be empty");
            }
            this.screen = value;
        }
    }

    public decimal Price 
    {
        get { return this.price; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentNullException("Price can't be negative");
            }
            this.price = value;
        }
    }

    public Battery Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }


    public override string ToString()
    {
        string result = "";
        if (this.Model != null && this.Price > 0 && this.Processor == null)
        {
            result = String.Format(
            "Laptop(Model: {0}, Price: {1} lv.)", this.Model, this.Price);
        
        }
        else
        {
            result = String.Format(
            "Laptop(Model: {0}, Manufacturer: {1}, Processor: {2}, Graphics card: {3}, RAM: {4} GB, Battery: {5}, Screen: {6}, Price: {7} lv.)", this.Model, this.Manufacturer, this.Processor, this.GraphicsCard, this.Ram, this.Battery, this.Screen, this.Price);
        
        }
        return result;
    }



}
