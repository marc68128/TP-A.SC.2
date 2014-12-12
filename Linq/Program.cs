using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myData = new List<string>()
            {
                "salut", 
                "ok", 
                "marc", 
                "Arnaud", 
                "Vincent", 
                "moi"
            };

            var result = myData.Where(s => s.StartsWith("m")).ToList();

            foreach (var s in result)
            {
               // Console.WriteLine(s);
            }


            List<int> list1 = new List<int>() { 1, 2, 3, 4 };
            List<int> list2 = new List<int>() { 3, 4, 5, 6 };

            var union = list1.Union(list2);
            var inter = list1.Intersect(list2);
            var except = list1.Except(list2);

            Console.WriteLine("Union :");
            foreach (var i in union)
            {
                Console.Write(i + " - ");
            }
            Console.WriteLine();
            Console.WriteLine("Intersect :");
            foreach (var i in inter)
            {
                Console.Write(i + " - ");
            }
            Console.WriteLine();
            Console.WriteLine("Except :");
            foreach (var i in except)
            {
                Console.Write(i + " - ");
            }


            Console.ReadLine();

        }
    }
}
