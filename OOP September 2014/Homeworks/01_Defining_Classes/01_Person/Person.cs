using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{
    private string name;
    private int age;
    private string email;

    
    public string Name 
    {
        get { return this.name; }
        set 
        { 
            if (string.IsNullOrEmpty(value))throw new ArgumentNullException("Name can not be empty");
            this.name = value;
        }
    }
    public int Age 
    {
        get { return this.age; }
        set 
        { 
            if (value > 100 || value < 1) throw new ArgumentOutOfRangeException("age must be between 1 and 100");
            this.age = value;
        }
    }
    public string Email 
    {
        get { return this.email; }
        set
        {
            if (value != null && !value.Contains("@"))
            {
                throw new ArgumentException("Email must be correct");
            }
            this.email = value;
        }
    }

    //Constructors
    public Person(string name, int age, string email)
    {
        this.Age = age;
        this.Name = name;
        this.Email = email;
    }
    public Person(string name, int age)
        : this(name, age, null)
    {

    }

    public override string ToString()
    {
        string result = String.Format(
            "Person(Name: {0}, Age: {1}", this.Name, this.Age);

        if (!string.IsNullOrEmpty(this.Email))
        {
            result += ", Email: " + this.Email + ")";
        }
        else
        {
            result += ")";
        }

        return result;
    }
    
}