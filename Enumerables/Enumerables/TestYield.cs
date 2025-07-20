using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerables
{
    internal class TestYield : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            yield return 1;//yield generate Enumerator
            yield return 2;
            yield break;
            yield return 3;
            yield return 4;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
