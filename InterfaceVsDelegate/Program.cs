using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVsDelegate
{
    class Program
    {

        static void Main(string[] args)
        {
            DelegateClass cls = new DelegateClass();
            MyDelegate d = cls.MyMethod;
            d("Supinfo");

            IInterfaceClass cls2 = new InterfaceClass();
            cls.MyMethod("Supinfo");

            Console.ReadLine(); 
        }

        
    }
}
