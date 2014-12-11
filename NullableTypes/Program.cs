using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = 1;

            if (i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
            Console.ReadLine();
        }
    }
}
