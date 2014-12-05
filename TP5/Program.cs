using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            MaPaire<string, int> maPaire = new MaPaire<string, int>("Dumez", 42);
            MaPaire<int, string> maPaireInverse = maPaire.Swap(); 

            Console.WriteLine(maPaire);
            Console.WriteLine(maPaireInverse);

            MaPaire<string, int>[] mesPaires = new MaPaire<string, int>[3];
            mesPaires[0] = new MaPaire<string, int>("toto", 22);
            mesPaires[1] = new MaPaire<string, int>("tutu", 25);
            mesPaires[2] = new MaPaire<string, int>("tata", 26);

            foreach (var maPaire2 in mesPaires)
            {
                Console.WriteLine(maPaire2.ToString());
            }

            MaPaire<MaPaire<int, int>, string> maPaire3 = new MaPaire<MaPaire<int, int>, string>(new MaPaire<int, int>(10,20), "salut" );
            Console.WriteLine(maPaire3);

            Console.ReadLine(); 
        }
    }
}
