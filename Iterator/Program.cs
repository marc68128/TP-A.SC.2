using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var suite = Puissance(50);
            foreach (var i in suite)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static IEnumerable<int> Puissance(int cnt)
        {
            int ret = 1; 
            for (int i = 0; i < cnt; i++)
            {
                yield return ret;
                ret *= 2; 
            }
        }
    }
}
