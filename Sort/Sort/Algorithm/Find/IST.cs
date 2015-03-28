using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Algorithm.Find
{
    public interface IST<Key,Value>
        where Key:IComparable
    {
        Value Get(Key key);
        void Put(Key key, Value val);
        int Rank(Key key,int lo ,int hi);
        Value[] Range(Key lo,Key hi);

    }
}
