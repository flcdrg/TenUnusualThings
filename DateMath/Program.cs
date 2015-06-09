using System;
using System.Diagnostics;
using static System.Diagnostics.Debug;

namespace DateMath
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new DateTime(2014, 12, 31);

            WriteLine(d.ToString("d"));

            Debugger.Break();

            // years
            WriteLine(d.AddYears(2).Year);
            WriteLine(d.AddYears(1).AddYears(1).Year);

            // days
            WriteLine(d.AddDays(62).ToString("d"));
            WriteLine(d.AddDays(31).AddDays(31).ToString("d"));

            // months
            WriteLine(d.AddMonths(1).ToString("d"));

            WriteLine(d.AddMonths(2).ToString("d"));
            WriteLine(d.AddMonths(1).AddMonths(1).ToString("d"));

            WriteLine(d.AddMonths(3).ToString("d"));
            WriteLine(d.AddMonths(1).AddMonths(1).AddMonths(1).ToString("d"));

            WriteLine(d.AddMonths(4).ToString("d"));
            WriteLine(d.AddMonths(1).AddMonths(1).AddMonths(1).AddMonths(1).ToString("d"));
        }
    }
}
