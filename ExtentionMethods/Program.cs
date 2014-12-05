using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            Console.WriteLine(i.IsFour());
            i = 500; 
            Console.WriteLine(i.IsFour());

            Console.ReadLine();
        }
    }
}
