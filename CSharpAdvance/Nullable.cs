using System;

namespace CSharpAdvance
{
    public class Nullable<T> where T : struct
    {
        private readonly Object _value;

        public Nullable()
        {
            
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue => _value != null; // return True when its not null

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T) _value;
            return default(T);
        }
    }
}