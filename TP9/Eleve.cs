using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TP9
{
    public class Eleve
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Eleve(string nom, string prenom, int age, string email)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Email = email;
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", Nom, Prenom);
            }
        }
    }
}
