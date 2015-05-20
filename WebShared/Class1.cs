// Run from UAC prompt!
// aspnet_intern -mode exec -sourcedir "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files" -interndir C:\ASPNETCommonAssemblies -minrefcount 2

using System;

namespace WebShared
{
    // http://blogs.technet.com/b/sateesh-arveti/archive/2011/11/30/look-at-sharing-common-assemblies-in-asp-net-4-5.aspx
    // http://www.asp.net/aspnet/overview/aspnet-and-visual-studio-2012/whats-new#_Toc_perf_3
    public class Class1
    {
        public string TestMethod()
        {



            return DateTime.UtcNow.ToString();
        }
    }
}
