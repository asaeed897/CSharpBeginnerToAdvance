using System;
using System.Collections;

namespace CSharpIntermediate
{
    public class Stack
    {
        private readonly ArrayList _list = new ArrayList();

        public void Push(Object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Argument can't be null.");
            }
            _list.Add(obj);
        }

        public Object Pop()
        {
            var lastElementIndex = _list.Count - 1;
            if (lastElementIndex < 0)
            {
                throw new InvalidOperationException("Pop operation is invalid on empty stack.");
            }
            var obj = _list[lastElementIndex];
            _list.RemoveAt(lastElementIndex);
            return obj;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public int Size()
        {
            return _list.Count;
        }
        
    }
}