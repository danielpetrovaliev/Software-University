using System;
using System.Timers;

class AsyncTimerDemo
{
    public static void Main()
    {
        Action<string> method =
            delegate(string str)
            {
                Console.WriteLine(str);
                Console.Beep();
            };
        Action<string> method2 = str => Console.WriteLine("Hurry up!"); ;

        AsyncTimer timer = new AsyncTimer(method, 100, 1000);
        AsyncTimer timer2 = new AsyncTimer(method2, 100, 1000);
        timer.Start();
        timer2.Start();
    
    }
}
