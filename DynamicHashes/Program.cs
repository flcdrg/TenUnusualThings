using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DynamicHashes
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic bag = new Bag();

            //bag.Values["a"] = "b";

            bag.a = "b";

            Console.WriteLine(bag.a);
            Console.ReadLine();
        }
    }

    public class Bag : DynamicObject
    {
        private IDictionary<string, string> _values;

        /*
        private IDictionary<string, string> Values
        {
            get
            {
                return _values;
            }
            set
            {
                _values = value;
            }
        }
        */
        public Bag()
        {
            _values = new Dictionary<string, string>();
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = _values[binder.Name];

            return true;
            //return base.TryGetMember(binder, out result);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _values[binder.Name] = (string)value;
            return true;
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _values.Keys;
        }
    }
}
