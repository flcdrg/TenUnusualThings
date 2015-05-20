using System;

namespace Generics
{
    // http://stackoverflow.com/a/1332344/25702
    class Program
    {
        static void Main(string[] args)
        {

            RealTurtle t = new RealTurtle();

            Console.WriteLine(t);
            Console.WriteLine(t.MyType().GetType());
            Console.ReadLine();
        }
    }

    public class Turtle<T> where T : Turtle<T>
    {
        public override string ToString()
        {
            return typeof(T).Name + " " + base.ToString();
        }

        public T MyType()
        {
            return (T)this;
        }
    }

    class RealTurtle : Turtle<RealTurtle>
    {
    }
}
