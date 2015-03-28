using Sort.Algorithm;
using Sort.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort
{
    public class TestSort : ITest
    {

        public void Test()
        {
            int[] source = new int[] { 10, 1, 2, 4, 3, 5, 7, 6, 0, 9, 8 };
            ISort sort = new UserDefinedSort();
            sort.Sort(source);
            printResult(source);
            Console.ReadKey();
        }

        private static void printResult(int[] source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }
    }
}
