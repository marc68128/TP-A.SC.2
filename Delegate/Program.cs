using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate int Transformer(int x);
        static void Main(string[] args)
        {
            Transformer t = Triple;
            Console.WriteLine(t(2));

            Console.ReadLine();
        }

        public static int Triple(int x)
        {
            return x*3; 
        }
    }
}
