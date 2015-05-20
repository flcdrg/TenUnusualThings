using System;

namespace TypeForwardingClient
{
    // Type forwarding
    // https://msdn.microsoft.com/en-us/library/ms404275(v=vs.110).aspx
    // http://www.codeproject.com/Articles/27268/Type-Forwarding-in-NET
    class Program
    {
        static void Main(string[] args)
        {
            var c = new OldLibrary.Useful();
            Console.WriteLine(c.Calculation(4, 5));
            Console.ReadLine();
        }
    }
}
