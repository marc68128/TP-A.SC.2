using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Chien ChihuahuaCache = new Chihuahua();
            Chien StBernardCache = new StBernard();

            ChihuahuaCache.Appeller();
            StBernardCache.Appeller();
            
            Console.Read();
        }

    }

}
