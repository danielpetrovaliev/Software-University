using System;


class Program
{
    private static void OnChange(object sender, EventArgs eventArgs)
    {
        Console.WriteLine("");
    }
    static void Main()
    {
        Student stu = new Student("gosho", 31);
        stu.Name = "min4o";
        stu.Age = 20;

    }
}