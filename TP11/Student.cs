using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    class Student
    {

        public Student(string id, string campus, string firstname, string name)
        {
            Name = name;
            FirstName = firstname;
            CampusName = campus;
            BoosterId = id;
        }

        public string Name { get; set; }
        public string FirstName { get; set; }
        public string BoosterId { get; set; }
        public string CampusName { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", Name, FirstName, CampusName, BoosterId);
        }
    }
}
