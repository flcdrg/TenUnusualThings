using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace TaskPatterns
{
    // http://blogs.msdn.com/b/pfxteam/archive/2011/01/13/10115642.aspx
    class Program
    {
        public static void Main()
        {
            Task.Run(async () =>
            {
                Console.WriteLine("Starting");
                await TimeSpan.FromSeconds(15);

                Console.WriteLine("Ending");

            }).Wait();
        }
    }

    public class TimeSpanAwaiter : INotifyCompletion
    {
        private readonly TimeSpan _value;

        public TimeSpanAwaiter(TimeSpan value)
        {
            _value = value;
        }

        public void OnCompleted(Action continuation)
        {
            Thread.Sleep(_value);
            continuation();
        }

        public bool IsCompleted
        {
            get { return false; }
        }

        public void GetResult()
        {
        }
    }

    public static class TimeSpanExtensions
    {
        public static TimeSpanAwaiter GetAwaiter(this TimeSpan value)
        {
            return new TimeSpanAwaiter(value);
        }
    }
}
