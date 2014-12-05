using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class Program
    {
        static void Main(string[] args)
        {
            Metronome m = new Metronome(); 
            Listener l = new Listener();
            Listener l2 = new Listener();

            l.Subscribe(m);
            l2.Subscribe(m);
            m.Start();
        }
    }
}
