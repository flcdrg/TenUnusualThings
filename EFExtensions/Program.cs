#define BEFORE
using System;
using System.Diagnostics;
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
                context.Database.Log = (sql) => Debug.WriteLine(sql);
#if BEFORE
                var q =
                    context.Stores.Where(
                        h => h.Name.StartsWith("E") && h.Name.EndsWith("E"));
#else
                var q = context.Stores.WhereStartsAndEndsWith(h => h.Name, "E");
#endif

                foreach (var storeName in q.Select(s => s.Name).ToList())
                {
                    Console.WriteLine(storeName);
                }
            }

            Console.ReadLine();
        }
    }
}
