using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ReactiveUI;

namespace ReactiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var obs = MyLongMethod();
            obs.ObserveOn(RxApp.MainThreadScheduler).Subscribe(s =>
            {
                var myCustomString = "salut " + s;
                Console.WriteLine(myCustomString);
            });
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("titi");
            }
        }


        public static IObservable<string> MyLongMethod()
        {
            return Observable.Start(() =>
            {
                Thread.Sleep(5000);
                return "toto";
            });
        }
    }
}
