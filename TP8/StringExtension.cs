using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    public static class StringExtension
    {
        public static int WordCount(this string s)
        {
            var splitedString = s.Split(new char[] {',', '.', '?', ' '});
            return splitedString.Length; 
        }
    }
}
