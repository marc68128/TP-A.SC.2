using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    public static class StringExtensions
    {
        public static bool IsOdd(this string s)
        {
            return s.EndsWith("0")
                   || s.EndsWith("2")
                   || s.EndsWith("4")
                   || s.EndsWith("6")
                   || s.EndsWith("8");
        }
    }
}
