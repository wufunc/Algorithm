using Sort.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Algorithm
{
    /// <summary>
    /// worng algorithm
    /// </summary>
    public class UserDefinedSort:ISort
    {
        public void Sort(int[] source)
        {
            int n = source.Length - 1;
            int k = n / 2;
            while(k>0)
            {
                blance(source, k, n);
                k--;
            }
            test[] tts = new test[2]{ new test(),new test()};
            Array.Sort(tts);

            Console.WriteLine(tts.Length);
            
        }
        private class test:IComparable<int>
        {


            public int CompareTo(int other)
            {
                return 1;
            }
        }
        private void blance(int[] source, int k, int n)
        {
            int j = 2 * k;
            if (j <= n)
            {
                BalnceDirection dir = new BalnceDirection();
                if (j < n)
                {
                    if (source[j] > source[j + 1])
                    {
                        dir.Left = true;
                        dir.Right = true;
                        AlgorithmUtil.Exchange(source, j, j + 1);
                    }
                    if (source[k] < source[j])
                    {
                        dir.Left = true;
                        AlgorithmUtil.Exchange(source, k, j);
                    }
                    if (source[k] > source[j + 1])
                    {
                        dir.Right = true;
                        AlgorithmUtil.Exchange(source, k, j + 1);
                    }
                }
                else
                    if (source[k] < source[j])
                    {
                        dir.Left = true;
                        AlgorithmUtil.Exchange(source, k, j);
                    }
                j = 2 * j;
                if (dir.Left)
                    blance(source,j,n);
                if (dir.Right)
                    blance(source,j+1,n);
            }
            
        }

        private class BalnceDirection
        {
            public bool Left;
            public bool Right;
        }
    }
}
