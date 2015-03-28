using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Algorithm.Find
{
    public class ArrayST<Key,Value>:IST<Key,Value>
        where Key:IComparable
    {
        int  _capacity = 5;
        Key[] _keys = null;
        Value[] _vals = null;
        int _legth = 0;

        public ArrayST()
        {
            _keys = new Key[_capacity];
            _vals = new Value[_capacity];
        }
        public Value Get(Key key)
        {
            if(_legth == 0)
                return default(Value);
            int count = Rank(key,0,_legth-1);
            if (count < _legth && _keys[count].CompareTo(key) == 0)
                return _vals[count];
            else
                return default(Value);
        }

        public void Put(Key key, Value val)
        {
            if(_legth ==  _capacity)
                expandCapacity();
            if(_legth == 0)
            {
                _keys[0] = key;
                _vals[0] = val;
                _legth++;
            }
            int count = Rank(key, 0, _legth-1);
            if (count < _legth && _keys[count].CompareTo(key) == 0)
                _vals[count] = val;
            else
            { 
                for (int i = _legth; i > count; i--)
                {
                    _keys[i] = _keys[i - 1];
                    _vals[i] = _vals[i - 1];
                }
                _keys[count] = key;
                _vals[count] = val;
                _legth++;
            }

        }

        private void expandCapacity()
        {
            _capacity = _capacity * 2;
            Key[] keysNew = new Key[_capacity];
            Value[] valsNew = new Value[_capacity];
            Array.Copy(_keys, keysNew, _legth);
            Array.Copy(_vals, valsNew, _legth);
            _keys = keysNew;
            _vals = valsNew;
        }

        public int Rank(Key key, int lo, int hi)
        {
            if (lo > hi) return lo;
            int mid = (lo + hi) / 2;
            int cmp = key.CompareTo(_keys[mid]);
            if (cmp > 0)
                return Rank(key, mid+1,hi);
            else if(cmp<0)
                return Rank(key, lo,mid-1);
            else
                return  mid;
        }

        public Value[] Range(Key lo, Key hi)
        {
            throw new NotImplementedException();
        }
    }
}
