using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class Chien : IAnimal, IComparable
    {
        public string Nom { get; set; }
        public int Age { get; set; }

        public void Description()
        {
            Console.WriteLine("I am a dog !");
        }

        public int CompareTo(object obj)
        {
            if (obj is Chien)
            {
                var chien = obj as Chien;
                if (this.Age > chien.Age)
                {
                    return 1; 
                }
                else if (this.Age == chien.Age)
                {
                    return 0;
                }
                else
                {
                    return -1; 
                }
            }
            throw new Exception();
        }
    }
}
