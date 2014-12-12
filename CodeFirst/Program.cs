using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Model;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var teacher = new Teacher();
                teacher.Name = "Dupont";

                var student = new Student();
                student.Name = "Unterseh";
                student.FirstName = "Marc";
                student.Teacher = teacher;

                context.Teachers.Add(teacher);
                context.Students.Add(student);

                context.SaveChanges(); 
            }
        }
    }
}
