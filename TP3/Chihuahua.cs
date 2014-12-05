using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public sealed class Chihuahua : Chien
    {
        private string Nom = "Chihuahua";

        public override void Appeller()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
}
