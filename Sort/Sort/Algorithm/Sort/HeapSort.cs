using Sort.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Algorithm
{
    public class HeapSort:ISort
    {
        public void Sort(int[] source)
        {
            int n = source.Length - 1;
            int k = n/2;
            while( k>0 )
            {
                sink(source,k--,n);
            }
            
            while (n > 1)
            {
                AlgorithmUtil.Exchange(source, 1, n--);
                sink(source, 1,n);
            }
        }

        private void sink(int[] source, int k,int n)
        {
            while(2*k<n+1)
            {
                int j = 2*k;
                if (j + 1 < n && source[j] < source[j + 1])
                    j++;
                if (source[k] < source[j])
                    AlgorithmUtil.Exchange(source,k,j);
                k = j;
            }
        }
    }
}
