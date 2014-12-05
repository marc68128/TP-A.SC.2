using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    public delegate void MyDelegate();

    public delegate double MyDelegate2(double a, double b); 

    class Exercice
    {

        public static void Bienvenue()
        {
            Console.WriteLine("Bienvenue !!!");
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
    }

   
}
