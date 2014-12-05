using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = "toto";
                var b = 3;
                var c = 0;
                var d = b/c;
                if (b == 2)
                {
                    throw new System.Exception("b ne doit pas être egal à deux");
                }
                Console.WriteLine("Tout est ok !");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (System.Exception e)
            {

            }
            finally
            {
                
            }

            Console.ReadLine();
        }
    }
}
