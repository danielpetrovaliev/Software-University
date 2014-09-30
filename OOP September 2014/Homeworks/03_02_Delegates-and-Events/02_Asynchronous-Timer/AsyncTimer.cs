using System;
using System.ComponentModel;
using System.Threading;
using System.Timers;


public class AsyncTimer
{
    private int tickCount;
    private int interval;
    Action<string> method;

    public AsyncTimer(Action<string> method, int tickCount, int interval)
    {
        this.method = method;
        this.tickCount = tickCount;
        this.interval = interval;
    }

    public int TickCount
    {
        get
        {
            return tickCount;
        }
    }

    public int Interval
    {
        get
        {
            return interval;
        }
    }

    private void Update()
    {
        while (this.tickCount > 0)
        {
            Thread.Sleep(this.Interval);
            if (method != null)
            {
                method(this.tickCount + "");
            }
            this.tickCount--;
        }
    }

    public void Start()
    {
        Thread thread = new Thread(this.Update);
        thread.Start();
    }
}
