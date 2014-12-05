using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP7
{
    public class Metronome : EventArgs
    {
        EventArgs e = null;

        public delegate void TickHandler(Metronome m, EventArgs eventArgs);

        public event TickHandler Tick;

        public void Start()
        {
            while (true)
            {
                Thread.Sleep(new TimeSpan(0,0,0,3));
                if (Tick != null)
                {
                    Tick(this, e);
                }
            }
        }
    }
}
