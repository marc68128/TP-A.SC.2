using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    public static class IntExtension
    {
        public static bool IsFour(this int i)
        {
            return i == 4; 
        }
    }
}
