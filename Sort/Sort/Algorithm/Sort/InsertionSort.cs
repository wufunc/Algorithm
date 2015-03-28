using Sort.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Algorithm
{
    /// <summary>
    /// 1.时间复杂度O(n²),平均(n²)/4次,(n²)/4次交换
    /// 2.时间复杂度与初始数据是否有序相关，适合于已经部分有序的数据
    /// </summary>
    public class InsertionSort : ISort
    {
        public void Sort(int[] source)
        {
            for (int i = 1; i < source.Length; i++)
            {
                int temp = source[i];
                int j = i - 1;
                for(; j>=0;j--)
                {
                    source[j + 1] = source[j];
                    if(source[j] <= temp)
                        break;
                }
                source[j + 1] = temp;
            }
        }
    }
}
