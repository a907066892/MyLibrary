using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    public class MyEnumbertor : IEnumerator
    {
        public MyEnumbertor(string[] array) 
        {
          _array= array;

    }
        private string[] _array;
        private int position;
        public object Current => _array[position];

        public bool MoveNext()
        {

            position ++;
            return position > _array.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
