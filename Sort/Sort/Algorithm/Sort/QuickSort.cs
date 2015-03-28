using Sort.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Algorithm
{
    public class QuickSort : ISort
    {
        public void Sort(int[] source)
        {
            sort(source,0,source.Length-1);
        }

        private void sort(int[] source, int lo, int hi)
        {
            if(lo<hi)
            { 
                int i = partition(source,lo,hi);
                sort(source,lo,i-1);
                sort(source,i+1,hi);
            }
        }

        private int partition(int[] source, int lo, int hi)
        {
            int first = source[lo];
            int i = lo, j = hi + 1;
            while(true)
            {
                while( source[++i] < first )
                {
                    if (i >= hi)
                        break;
                }
                while(source[--j] > first )
                {
                    if (j <= lo)
                        break;
                }
                if (i < j)
                    AlgorithmUtil.Exchange(source, i, j);
                else
                    break;
            }
            AlgorithmUtil.Exchange(source,lo,j);
            return j;
        }


    }
}
