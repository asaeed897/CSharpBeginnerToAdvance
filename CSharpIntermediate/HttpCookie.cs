using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime Expiry { get; set; }

        public string this[string key]
        {
            get => _dictionary[key];
            set
            {
                if (key != null) _dictionary[key] = value;
            }
        }
    }
}