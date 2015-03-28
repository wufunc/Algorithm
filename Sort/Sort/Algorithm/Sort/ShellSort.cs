using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Algorithm
{
    public class ShellSort : ISort
    {
        public void Sort(int[] source)
        {
            int h = 1;
            while (h < source.Length/3)
            {
                h = h * 3+1;
            }
            while (h >= 1)
            {
                for (int i = h; i < source.Length; i += h)
                {
                    int temp = source[i];
                    int j = i - h;
                    for (; j >= 0; j -= h)
                    {
                        source[j + h] = source[j];
                        if (source[j] < temp)
                            break;
                    }
                    source[j + h] = temp;

                }
                h = h / 3;
            }
        }
    }
}
