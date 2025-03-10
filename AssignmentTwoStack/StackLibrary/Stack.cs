using System;
using System.Collections;

namespace StackLibrary
{
    public class Stack
    {
        private readonly List<object> _array;
        private readonly int _size;
        public int Count
        {
            get { return _array?.Count ?? 0; }
        }

        public Stack()
        {
            _size = this.Count;
            _array = new List<object>();
        }

        public Stack(int size)
        {
            _size = size;
            _array = new List<object>(_size);
        }

        public Stack(ICollection collection)
             : this(collection?.Count ?? throw new InvalidOperationException(nameof(collection)))
        {
            IEnumerator en = collection.GetEnumerator();
            while (en.MoveNext())
            {
                Push(en.Current);
            }
        }

        public void Push(object? obj)
        {
            if (obj is not null)
            {
                _array.Add((Object)obj);
            }
        }

        public object? Pop()
        {

            if (this.Count < 1)
            {
                throw new InvalidOperationException();
            }

            object pop = _array[this.Count - 1];
            _array.RemoveAt(this.Count - 1);
            return pop;
        }

        public void Clear()
        {
            _array.Clear();

        }

        public object? Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }

            return _array[this.Count - 1];
        }
    }

}


