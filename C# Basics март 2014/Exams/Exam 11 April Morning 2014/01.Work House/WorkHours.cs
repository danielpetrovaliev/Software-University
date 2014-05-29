using System;


class WorkHours
{
    static void Main()
    {
        decimal hours = int.Parse(Console.ReadLine());
        decimal days = int.Parse(Console.ReadLine());
        decimal productivityPercent = int.Parse(Console.ReadLine());
        int normalDayHours = 12;
        
        decimal workDays = days - days * 1 / 10;
        decimal WorkingTime = (int)(workDays * normalDayHours * productivityPercent / 100);

        if (hours <= WorkingTime)
        {
            Console.WriteLine("Yes");
            decimal diff = WorkingTime - hours;
            Console.WriteLine((int)diff);
        }
        else
        {
            Console.WriteLine("No");
            decimal diff = WorkingTime - hours;
            Console.WriteLine((int)diff);
        }


    }
}