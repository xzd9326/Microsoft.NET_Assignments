using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T>
    {
        private T[] _array;
        private int _size;

        public MyList()
        {
            _size = 0;
            _array = new T[0];
        }
        public void Add(T element)
        {
            if (_size == _array.Length)
            {
                if (_array.Length == 0)
                {
                    _array = new T[4];
                }
                else
                {
                    T[] newArray = new T[2 * _array.Length];
                    Array.Copy(_array, newArray, _size);
                    _array = newArray;
                }
            }
            _array[_size++] = element;
        }

        public T Remove(int index)
        {
            if (index > _size)
            {
                Console.WriteLine("index out of range");
                return default(T);
            }
            T tmp = _array[index];
            _size--;
            Array.Copy(_array, index + 1, _array, index, _size - index);
            return tmp;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_array[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        public void Clear()
        {
            Array.Clear(_array, 0, _size);
            _size = 0;
        }

        public void InsertAt(T element, int index)
        {
            if (index > _size)
            {
                //throw new ArgumentOutOfRangeException("index out of range");
                Console.WriteLine("index out of range");
                return;
            }

            if (_size == _array.Length)
            {
                if (_array.Length == 0)
                {
                    _array = new T[4];
                }
                else
                {
                    T[] newArray = new T[2 * _array.Length];
                    Array.Copy(_array, newArray, _size);
                    _array = newArray;
                }
            }
            Array.Copy(_array, index, _array, index + 1, _size - index);
            _array[index] = element;
            _size++;
        }
        public void DeleteAt(int index)
        {
            if (index > _size)
            {
                Console.WriteLine("index out of range");
                return;
            }
            _size--;
            Array.Copy(_array, index + 1, _array, index, _size - index);
        }

        public T Find(int index)
        {
            if (index > _size)
            {
                Console.WriteLine("index out of range");
                return default(T);
            }
            T element = _array[index];
            return element;
        }
    }
}
