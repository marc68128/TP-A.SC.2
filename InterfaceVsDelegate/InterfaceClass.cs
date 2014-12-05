using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVsDelegate
{
    public class InterfaceClass : IInterfaceClass
    {
        public void MyMethod(string s)
        {
            Console.WriteLine("Hello " + s);
        }
    }
}
