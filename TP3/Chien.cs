using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Chien : Animal
    {
        private string Name = "Chien";
        private bool PoilLong = true;

        public override void Appeller()
        {
            Console.WriteLine("Waf ! Waf !");
        }
    }
}
