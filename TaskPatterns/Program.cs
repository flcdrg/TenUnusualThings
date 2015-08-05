#define First
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
                Console.WriteLine("Starting [{0}]", Thread.CurrentThread.ManagedThreadId);
                await TimeSpan.FromSeconds(15);

                Console.WriteLine("End [{0}]", Thread.CurrentThread.ManagedThreadId);
                Console.ReadLine();
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
            Console.WriteLine("Sleeping for {0} seconds. Don't you wish you set to to something smaller? [{1}]", _value.TotalSeconds, Thread.CurrentThread.ManagedThreadId);

            // Original
            // Thread.Sleep(_value);

            // NotifyCompletion 
            Task.Delay(_value).GetAwaiter().OnCompleted(continuation);

            Console.WriteLine("After Sleep [{0}]", Thread.CurrentThread.ManagedThreadId);
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
#if First
        public static TimeSpanAwaiter GetAwaiter(this TimeSpan value)
        {
            return new TimeSpanAwaiter(value);
        }
#elif Simple
        // Easy
        public static TaskAwaiter GetAwaiter(this TimeSpan value)
        {
            return Task.Delay(value).GetAwaiter();
        }
#else
        // TaskCompletionSource Way
        public static TaskAwaiter<object> GetAwaiter(this TimeSpan value)
        {
            Console.WriteLine("Sleeping for {0} seconds. Don't you wish you set to to something smaller? [{1}]", value.TotalSeconds, Thread.CurrentThread.ManagedThreadId);

            var tcs = new TaskCompletionSource<object>();
            var timer = new Timer(state => {
                tcs.SetResult(null);
            }, null, value, TimeSpan.FromMilliseconds(-1));
            tcs.Task.ContinueWith(t =>
            {
                timer.Dispose();
                Console.WriteLine("After Sleep [{0}]", Thread.CurrentThread.ManagedThreadId);

            }, TaskContinuationOptions.ExecuteSynchronously);

            return tcs.Task.GetAwaiter();
        }
#endif
    }
}
