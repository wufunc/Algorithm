using Sort.Algorithm;
using Sort.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest test = new TestFind();
            test.Test();
        }


    }
}
