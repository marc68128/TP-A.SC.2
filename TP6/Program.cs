using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate d = Exercice.Bienvenue;
            d();

            MyDelegate2 d2 = Exercice.Add;
            Console.WriteLine(d2(2, 3));

            Console.ReadLine();
        }
    }
}
