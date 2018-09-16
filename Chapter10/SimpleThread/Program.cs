using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(ChildThread);
            t.Name = "Interrupt";
            t.Start();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            t.Interrupt();
        }
        static void ChildThread()
        {
            try
            {
                Thread.Sleep(Timeout.Infinite);
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine($"Thread '{Thread.CurrentThread.Name}' was interrupted");
            }
            finally
            {
                //Any cleanup here
            }
        }
    }
}
