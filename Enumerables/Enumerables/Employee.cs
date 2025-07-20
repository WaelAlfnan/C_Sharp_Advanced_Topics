using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerables
{
    internal class Employee : IEnumerable<PayItem>
    {
        private readonly List<PayItem> _payItems = new();
        public string Name { get; set; }
        public void AddPayItem(string name, int value)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            _payItems.Add(new PayItem { Name = name, Value = value });
        }
        public IEnumerator<PayItem> GetPayItems()
        {
            Console.WriteLine("GetPayItemsCalled");
           return _payItems.GetEnumerator();
        }
        //public PayItem GetPayItem(int index) => _payItems[index];

        public PayItem this[int index]
        {
            get => _payItems[index];
        }
        public IEnumerator<PayItem> GetEnumerator()
        {
            Console.WriteLine("GetEnumeratorCalled");
            //return _payItems.GetEnumerator();
            //return new PayItemsEnumerator(_payItems);
            foreach (var item in _payItems)
                yield return item;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
