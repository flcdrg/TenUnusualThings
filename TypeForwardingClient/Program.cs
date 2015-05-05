using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeForwardingClient
{
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
