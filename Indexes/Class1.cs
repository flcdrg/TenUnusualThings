using System;

namespace Indexes
{
    // http://damieng.com/blog/2012/10/29/8-things-you-probably-didnt-know-about-csharp
    public class BagOfTricks
    {
        private Random _random = new Random();

        public string this[string key]
        {
            get
            {
                return "key" + _random.Next().ToString();
            }
        }

        public string this[string key, int number]
        {
            get
            {
                return "key" + (_random.Next() + number).ToString();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var bag = new BagOfTricks();

            Console.WriteLine(bag["a", 50]);
            Console.ReadLine();
        }
    }
}
