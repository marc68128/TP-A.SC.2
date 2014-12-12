using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("00001", "Nantes", "Nicolas", "Dumez"), 
                new Student("00002", "Paris", "John", "Doe"),
                new Student("00003", "Lyon", "Pierre", "Yves"),
                new Student("00004", "Marseille", "Jacques", "Dupond"),
                new Student("00005", "Nantes", "Jacques", "Durant"),
                new Student("00006", "Lyon", "Julien", "Martin"),
            };

            //var nantes =
            //    from student in students
            //    where student.CampusName == "Nantes"
            //    select student;

            var nantes =
                students.Where(student => student.CampusName == "Nantes").ToList();

            //var containD =
            //    from student in students
            //    where student.Name.Contains("d") || student.Name.Contains("D")
            //    select student;

            var containD =
                students.Where(s => s.Name.ToLower().Contains("d")).ToList();

            //var odd =
            //    from student in students
            //    where student.BoosterId.IsOdd()
            //    select student; 

            var odd =
                students.Where(s => s.BoosterId.IsOdd()).ToList();

            foreach (var student in odd)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();

        }
    }
}
