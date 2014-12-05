using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public sealed class StBernard : Chien
    {
        private string Nom = "StBernard";

        public new void Appeller()
        {
            Console.WriteLine("Woof ! Woof! ");
        }
    }
}
