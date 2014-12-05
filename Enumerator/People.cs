using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    public class People : IEnumerable
    {
        private Person[] _persons; 
        public People(Person[] persons)
        {
            _persons = persons;
        }

        public IEnumerator GetEnumerator()
        {
            return new PeopleEnum(_persons);
        }
    }

    class PeopleEnum : IEnumerator
    {
        private Person[] _persons;
        private int _current = -1;

        public PeopleEnum(Person[] persons)
        {
            _persons = persons;
        }
        public bool MoveNext()
        {
            return ++_current < _persons.Length;
        }

        public void Reset()
        {
            _current = -1;
        }

        public object Current
        {

            get
            {
                try
                {
                    return _persons[_current];
                }
                catch (Exception)
                {
                    throw new InvalidOperationException();
                }

            }
        }
    }


}

