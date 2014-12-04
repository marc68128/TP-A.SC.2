using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Eleve
    {
        private string nom;
        private string prenom;
        public int Age;
        protected string email;

        public Eleve(string nom, string prenom, int age, string email)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.Age = age;
            this.email = email; 
        }

        public string GetName()
        {
            return string.Format("{0} {1}", nom, prenom); 
        }
    }
}
