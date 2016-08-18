using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinClasses.LINQ.Utils
{
    public static class ExtensionMethodSample
    {
        public static string ReplaceR(this string sentence)
        {
            return sentence.Replace("R", "");
        }

        public static string ReplaceRNoExtension(string sentence)
        {
            return sentence.Replace("R", "");
        }
    }
}
