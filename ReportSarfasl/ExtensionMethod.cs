using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSarfasl
{
    public static class ExtensionMethod
    {
        public static string ToMan(this decimal i)
        {
            return i.ToString("#,0.0000");
        }
    }
}
