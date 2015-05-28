using System;
using System.Runtime.CompilerServices;
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
        public static TaskAwaiter GetAwaiter(this TimeSpan value)
        {
            return Task.Delay(value).GetAwaiter();
        }
    }
}
