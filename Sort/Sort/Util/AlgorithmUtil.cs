using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Util
{
    public class AlgorithmUtil
    {
        

        public static void Exchange(int[] source, int i, int j)
        {
            int temp = source[i];
            source[i] = source[j];
            source[j] = temp;
        }
        public static void Merge(int[] source, int lo, int mid, int hi,int[] temp)
        {
            for (int k = lo; k <= hi; k++)
            {
                temp[k] = source[k];
            }
            int i = lo, j = mid + 1;
            int q = lo;
            while (q <= hi)
            {
                if (i > mid)
                    source[q] = temp[j++];
                else if (j > hi)
                    source[q] = temp[i++];
                else if (temp[i] > temp[j])
                    source[q] = temp[j++];
                else
                    source[q] = temp[i++];
                q++;
            }
        }
    }
}
