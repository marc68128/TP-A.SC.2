using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            People p  = new People(new Person[]
            {
                new Person("toto", "tutu"),
                new Person("Marc", "Unterseh"),
                new Person("fjds", "tututu"), 
            });

            foreach (Person perso in p)
            {
                Console.WriteLine(perso.FirstName);
            }
            Console.ReadLine();
        }
    }
}
