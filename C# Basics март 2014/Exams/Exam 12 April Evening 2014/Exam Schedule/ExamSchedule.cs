using System;


class ExamSchedule
{
    static void Main()
    {
        string input = Console.ReadLine();
        input += ":";
        input += Console.ReadLine();
        input += ":";
        input += Console.ReadLine();
        input += ":";

        DateTime startTime = DateTime.Parse(input);
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        startTime = startTime.AddHours(durationHours);
        startTime = startTime.AddMinutes(durationMinutes);

        Console.WriteLine(startTime);

    }
}