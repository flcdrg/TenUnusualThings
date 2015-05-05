using System.Runtime.CompilerServices;

//[assembly: TypeForwardedTo(typeof(OldLibrary.Useful))]

namespace OldLibrary
{
#if true
    public class Useful
    {
        public int Calculation(int x, int y)
        {
            return x + 2 * y - 3;
        }
    }
#endif
}
