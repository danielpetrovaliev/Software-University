using System;

public delegate void ChangedPropertyEventHandler(object sender, PropertyChangedEventArgs args);
class Student
{
    private string name;
    private int age;
    public event ChangedPropertyEventHandler Change;


    public Student(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.Change += this.Message;
    }

    public string Name 
    {
        get { return this.name;}
        set 
        {
            var ev = new PropertyChangedEventArgs { OldName = this.name, Name = value, ChangedProperty = "Name" };
            this.name = value;
            this.OnChange(this, ev);
        }
    }
    public int Age 
    {
        get { return this.age;}
        set 
        {
            var ev = new PropertyChangedEventArgs { OldAge = this.age, Age = value, ChangedProperty = "Age" };
            this.age = value;
            this.OnChange(this, ev);
        }
    }

    protected void OnChange(object sender, PropertyChangedEventArgs args)
    {
        if (Change != null)
        {
            Change(sender, args);   
        }
    }
    private void Message(object sender, PropertyChangedEventArgs args)
    {
        if (args.ChangedProperty == "Name")
        {
            Console.WriteLine("Property changed: Name (from {1} to {0}).", args.Name, args.OldName);
        }
        if (args.ChangedProperty == "Age")
        {
            Console.WriteLine("Property changed: Age (from {1} to {0}).", args.Age, args.OldAge);
        }
    }
}