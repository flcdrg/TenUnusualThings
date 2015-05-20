#define BEFORE
using System;
using System.Linq;

namespace EFExtensions
{
    class Program
    {
        // http://trentacular.com/2010/08/linq-to-entities-wild-card-like-extension-method/
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
#if BEFORE
                var q =
                    context.SalesOrderHeaders.Where(
                        h => h.Customer.Store.Name.StartsWith("E") && h.Customer.Store.Name.EndsWith("E"));
#else
                var q = context.SalesOrderHeaders.WhereStartsAndEndsWith(h => h.Customer.Store.Name, "E");
#endif
                foreach (var header in q.ToList())
                {
                    Console.WriteLine(header.Customer.Store.Name);
                }
            }

            Console.ReadLine();
        }
    }
}
