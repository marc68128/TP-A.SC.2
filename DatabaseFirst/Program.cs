using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PoudlardEntities())
            {
                var student = context.Etudiant.First();

                context.Etudiant.Add(new Etudiant());
                context.SaveChanges();

                Console.WriteLine(student.nom);
                Console.ReadLine();
            }
        }
    }
}
