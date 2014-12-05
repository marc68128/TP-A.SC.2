using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVsDelegate
{
    public delegate void MyDelegate(string name);
    public class DelegateClass
    {
     
        public void MyMethod(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
