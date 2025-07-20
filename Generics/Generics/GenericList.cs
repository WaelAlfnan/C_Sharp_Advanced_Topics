using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //public class GenericList<T1, T2, T3> where T1 : class, new()
        //where T2 : class, new()
        //where T2 : Employee, new()  // Employee : and its chiled enter in this

    public class GenericList<T> where T : class, new()
    {
        private readonly List<T> _items = new();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public int Count => _items.Count;
    }
}
