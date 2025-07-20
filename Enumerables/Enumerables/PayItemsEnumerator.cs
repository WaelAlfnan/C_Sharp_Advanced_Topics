using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerables
{
    internal class PayItemsEnumerator : IEnumerator<PayItem>
    {
        private readonly List<PayItem> _payItems = new();
        private int _currentIndex = -1;
        public PayItemsEnumerator(List<PayItem> payItems)
        {
            _payItems = payItems; 
        }
        public PayItem Current => _payItems[_currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            //_currentIndex++;
            //if (_currentIndex < _payItems.Count)
            //    return true;
            //else return false;
            return ++_currentIndex < _payItems.Count;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
