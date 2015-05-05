using System;

namespace Indexes
{
    public class BagOfTricks
    {
        private Random _random = new Random();

        public string this[string key, int number]
        {
            get
            {
                return number.ToString();
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
