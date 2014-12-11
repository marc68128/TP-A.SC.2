using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9
{
    public static class StringExtension
    {
        public static bool IsNumeric(this string s)
        {
            int a;
            return int.TryParse(s, out a);
        }
    }
}
