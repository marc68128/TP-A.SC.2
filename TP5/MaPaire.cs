using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class MaPaire<T, U>
    {
        public T Premier { get; set; }
        public U Second { get; set; }

        public MaPaire(T prem, U sec)
        {
            Premier = prem;
            Second = sec;
        }

        public MaPaire<U, T> Swap()
        {
            return new MaPaire<U, T>(Second, Premier);
        }

        public override string ToString()
        {
            return string.Format("Valeur 1 : {0} – Valeur 2 : {1}", Premier, Second);
        }
    }
}
