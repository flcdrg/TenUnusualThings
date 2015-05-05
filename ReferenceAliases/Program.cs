extern alias External;

using ILog = External::log4net.ILog;

namespace ReferenceAliases
{
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable 0168
            ILog logger;
        }
    }
}
