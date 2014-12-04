using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public static class NumberHelper
    {
        public static string ConvertIntToString(int i)
        {
            switch (i)
            {
                case 1 :
                    return "un";
                case 2:
                    return "deux";
                case 3:
                    return "trois";
                case 4:
                    return "quatre";
                case 5:
                    return "cinq";
                case 6:
                    return "six";
                case 7:
                    return "sept";
                case 8:
                    return "huit";
                case 9:
                    return "neuf";
                case 10:
                    return "dix"; 
            }
            return "invalid number"; 
        }
    }
}
