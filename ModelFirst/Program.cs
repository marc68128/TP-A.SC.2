using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyModelContainer())
            {
                var teacher = new Teacher()
                {
                    Name = "Martin"
                };

                var student = new Student()
                {
                    Age = 20,
                    Name = "Dupont",
                    Teacher = teacher
                };

                context.Teachers.Add(teacher);
                context.Students.Add(student);
                context.SaveChanges(); 

                context.Students.ToList();
            }
        }
    }
}
