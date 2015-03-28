using Sort.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Algorithm
{
    public class MergeSortRecursion : ISort
    {
        int[] temp = null;
        public void Sort(int[] source)
        {
            temp = new int[source.Length];
            sort(source, 0,  source.Length - 1);
        }

        private void sort(int[] source, int lo, int hi)
        {
            if (lo<hi)
            {
                int mid = (lo + hi) / 2;
                sort(source, lo, mid);
                sort(source, mid+1,hi);
                AlgorithmUtil.Merge(source, lo, mid, hi, temp);
            }
        }

        
 
    }
}
