using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var eleve = new Eleve("Sion", "Genders", 30, "toto@supinfo.com");
            //Console.WriteLine(eleve.GetName());
            //Console.ReadLine(); 

            Console.WriteLine("Veuillez entrer un nom : ");
            var lastname = Console.ReadLine();
            Console.WriteLine("Veuillez entrer un prenom : ");
            var firstname = Console.ReadLine();
            Console.WriteLine("Veuillez entrer un age : ");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer une adresse email : ");
            var mail = Console.ReadLine();

            var eleve = new Eleve(lastname, firstname, age, mail);
            Console.WriteLine(eleve.GetName());
            Console.ReadLine(); 
        }
    }

}
