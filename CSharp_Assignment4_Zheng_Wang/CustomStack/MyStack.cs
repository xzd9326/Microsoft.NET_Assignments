using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class MyStack<T>
    {
        private T[] _array;
        private int _size;

        public int Count()
        {
            return _size;
        }

        public void Push(T element)
        {
            //Check Overflow, if does overflow, double array size
            if (_size == _array.Length)
            {
                T[] newArray = new T[2*_array.Length];
                Array.Copy(_array, newArray, _size);
                _array = newArray;
            }
            _array[_size++] = element;
        }
        public T Pop()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("stack is empty");
            }
            T element = _array[--_size];
            return element;
        }
        public MyStack()
        {
            _size = 0;
            _array = new T[4];
        }
        public MyStack(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException ("stack capacity should be greater than 0");
            }
            _size = 0;
            _array= new T[capacity];
        }

    }
}
