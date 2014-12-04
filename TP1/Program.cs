using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer un entier entre 1 et 10 : ");
            var userInput = Console.ReadLine();
            var userInt = int.Parse(userInput);
            string numberAsString = NumberHelper.ConvertIntToString(userInt);
            Console.WriteLine(numberAsString);
            
            
            Console.Clear();
            Console.WriteLine("Veuillez entrer une date au format JJ/MM/AAAA : ");
            userInput = Console.ReadLine();
            DateTime userDateTime = Convert.ToDateTime(userInput); 
            Console.WriteLine(userDateTime.ToString("D"));
            Console.ReadLine();
        }
    }
}
