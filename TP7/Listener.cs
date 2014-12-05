using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    public class Listener
    {
        public void Subscribe(Metronome m)
        {
            m.Tick += HeardIt;
        }

        private void HeardIt(Metronome metronome, EventArgs eventArgs)
        {
            Console.WriteLine("Heard It !");
        }
    }
}
