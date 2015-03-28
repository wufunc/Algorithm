using Sort.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Algorithm
{
    public class MergeSort:ISort
    {
        int[] temp = null;
    
        public void Sort(int[] source)
        {
            temp = new int[source.Length];
            for (int step = 1; step < source.Length; step = step + step)
            {
                for (int lo = 0; lo < source.Length - step;lo+=step+step )
                {
                    AlgorithmUtil.Merge(source, lo, lo + step-1, Math.Min(lo + step + step-1, source.Length - 1),temp);
                }
            }
        }
    }
}
