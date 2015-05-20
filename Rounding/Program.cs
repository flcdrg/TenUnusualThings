using System;

namespace Rounding
{
    // http://stackoverflow.com/questions/194484/whats-the-strangest-corner-case-youve-seen-in-c-sharp-or-net/195143
    class Program
    {
        static void Main(string[] args)
        {
            for (decimal d = 0.1M; d < 1.0M; d += 0.1M)
            {
                Console.WriteLine("{0} {1}", d, Math.Round(d));
            }

            Console.ReadLine();
        }
    }
}
