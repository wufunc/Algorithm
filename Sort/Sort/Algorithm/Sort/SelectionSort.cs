using Sort.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Algorithm
{
    /// <summary>
    /// 1.时间复杂度O(n²),平均n次交换，(n²)/2次比较
    /// 2.时间复杂度不随问题规模变化而变化
    /// </summary>
    public class SelectionSort:ISort
    {
        public void Sort(int[] source)
        {
            for (int i = 0; i < source.Length-1; i++)
            {
                int minValueIndex = i;
                for (int j = i + 1; j < source.Length; j++)
                {
                    if(source[j]< source[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }
                AlgorithmUtil.Exchange(source, i, minValueIndex);
            }
        }
    }
}
