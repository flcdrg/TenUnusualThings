//extern alias External;
//using ILog = External::log4net.ILog;

using log4net;

namespace ReferenceAliases
{
    // Reference aliases - http://stackoverflow.com/questions/286632/
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable 0168
            ILog logger;
        }
    }
}
