using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

// Code Contracts for .NET
// https://visualstudiogallery.msdn.microsoft.com/1ec7db13-3363-46c9-851f-1ce455f66970

namespace MainLibrary
{
    public class Rational
    {
        private readonly int _denominator;
        private int _numerator;

        public Rational(int numerator, int denominator)
        {
            Contract.Requires(denominator != 0);

            _numerator = numerator;
            _denominator = denominator;
        }

        public int Denominator
        {
            get
            {
                Contract.Ensures(Contract.Result<int>() != 0);

                return _denominator;
            }
        }

        public void Another(string name)
        {
            if (name == null) 
                throw new ArgumentNullException("name");
            Contract.EndContractBlock();

            Debug.WriteLine(name);
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_denominator != 0);
        }
    }
}