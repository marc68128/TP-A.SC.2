using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Chien c = new Chien();
            c.Age = 2;
            c.Description();
            IAnimal animal = new Chien();
            Console.WriteLine(c.CompareTo(animal));
            Console.Read();
        }
    }
}
