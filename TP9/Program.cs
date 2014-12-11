using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Eleve> eleves = new List<Eleve>()
            {
                new Eleve("toto", "toto", 18, "toto@toto.fr"),
                new Eleve("titi", "toto", 18, "toto@toto.fr"),
                new Eleve("tutu", "toto", 18, "toto@toto.fr"),
                new Eleve("tata", "toto", 18, "toto@toto.fr"),
                new Eleve("tototo", "toto", 18, "toto@toto.fr"),
                new Eleve("tititi", "toto", 18, "toto@toto.fr"),
                new Eleve("tututu", "toto", 18, "toto@toto.fr"),
                new Eleve("tatata", "toto", 18, "toto@toto.fr"),
            };

            eleves.Add(new Eleve("totototo", "toto", 18, "toto@toto.fr"));
            eleves.Add(new Eleve("titititi", "toto", 18, "toto@toto.fr"));

            Console.WriteLine("Entrez un nombre (entre 1 et 10) :");
            var nb = Console.ReadLine();

            if (nb.IsNumeric())
            {
                var i = int.Parse(nb);
                var student = eleves[i - 1];
                Console.WriteLine(student.FullName);
            }
            else if(nb.ToLower() == "fibs")
            {
                foreach (var i in Fib(10))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }

        static IEnumerable<int> Fib(int cnt)
        {
            int prev = 1;
            int current = 1; 

            for (int i = 0; i < cnt; i++)
            {
                yield return prev;
                var next = prev + current;
                prev = current;
                current = next; 
            }
        }
    }
}
