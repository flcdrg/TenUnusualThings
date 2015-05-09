using System;
using System.Linq;

namespace EFExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var q = context.SalesOrderHeaders.WhereStartsAndEndsWith(c => c.Customer.Store.Name, "E");

                foreach (var header in q.ToList())
                {
                    Console.WriteLine(header.Customer.Store.Name);
                }
            }

            Console.ReadLine();
        }
    }
}
