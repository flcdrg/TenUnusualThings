#define BEFORE
using System.Runtime.CompilerServices;

#if !BEFORE
[assembly: TypeForwardedTo(typeof(OldLibrary.Useful))]
#endif

namespace OldLibrary
{
#if BEFORE
    public class Useful
    {
        public int Calculation(int x, int y)
        {
            return x + 2 * y - 3;
        }
    }
#endif
}
