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
                Console.ReadLine();
            }).Wait();
        }
    }

    public static class TimeSpanExtensions
    {
        public static TaskAwaiter<object> GetAwaiter(this TimeSpan value)
        {
            var tcs = new TaskCompletionSource<object>();
            var timer = new Timer(state => {
                tcs.SetResult(null);
            }, null, value, TimeSpan.FromMilliseconds(-1));
            tcs.Task.ContinueWith(t => { timer.Dispose(); }, TaskContinuationOptions.ExecuteSynchronously);
            return tcs.Task.GetAwaiter();
        }
    }
}
