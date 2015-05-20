using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DynamicHashes
{
    class Program
    {
        static void Main(string[] args)
        {
            var bag = new OldBag();

            bag.Values["a"] = "b";

            //bag.fred = "blah";
            //bag.a = "b";

            //Console.WriteLine(bag.a);
            Console.ReadLine();
        }
    }

    public class OldBag
    {
        private IDictionary<string, string> _values = new Dictionary<string, string>();

        public IDictionary<string, string> Values
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

    }

    public class Bag : DynamicObject
    {
        private IDictionary<string, string> _values;

        public Bag()
        {
            _values = new Dictionary<string, string>();
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = _values[binder.Name];

            return true;
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
