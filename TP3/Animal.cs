using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public abstract class Animal
    {
        private string Name;
        private bool PoilLong;

        public virtual void Appeller()
        {
            Console.WriteLine("Bonjour, je suis un animal !");
        }
    }
}
