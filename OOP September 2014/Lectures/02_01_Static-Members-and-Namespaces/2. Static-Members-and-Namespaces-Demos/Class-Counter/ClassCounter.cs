using System;

public class Person
{
    private static int instanceCounter = 0;

    public string Name { get; set; }

    public static int PersonCounter
    {
        get
        {
            return Person.instanceCounter;
        }
    }

    public Person(string name = null)
    {
        Person.instanceCounter++;
        this.Name = name;
    }
}

class ClassCounter
{
    static void Main()
    {
        Person p = new Person("Pesho");
        Console.WriteLine("Person name: {0}", p.Name);

        Person g = new Person("Gosho");
        Console.WriteLine("Person name: {0}", g.Name);

        Console.WriteLine("Persons count: {0}", Person.PersonCounter);
    }
}
