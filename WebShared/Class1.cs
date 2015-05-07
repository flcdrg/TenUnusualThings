// Run from UAC prompt!
// aspnet_intern -mode exec -sourcedir "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files" -interndir C:\ASPNETCommonAssemblies -minrefcount 2

using System;

namespace WebShared
{
    public class Class1
    {
        public string TestMethod()
        {



            return DateTime.UtcNow.ToString();
        }
    }
}
