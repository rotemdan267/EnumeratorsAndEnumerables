using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    public class Sidra10To100 : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i * 10;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class Hazakot : IEnumerable<long>
    {
        public long Num { get; set; }

        public Hazakot(long num)
        {
            Num = num;
        }

        public IEnumerator<long> GetEnumerator()
        {
            long hazka = 1;
            for (int i = 1; i <= 10; i++)
            {
                hazka *= Num;
                yield return hazka;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
