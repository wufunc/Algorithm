using Sort.Algorithm.Find;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Test
{
    public class TestFind:ITest
    {
        public void Test()
        {
            IST<int, string> st = new BST<int, string>();
            st.Put(1,"b");
            st.Put(2,"a");
            st.Put(3,"c");
            st.Put(4,"e");
            st.Put(5,"d");
            st.Put(6,"f");
            st.Put(6,"g");
            if (!string.IsNullOrEmpty(st.Get(3)))
                Console.WriteLine(st.Get(3));
            if(!string.IsNullOrEmpty(st.Get(4)))
                Console.WriteLine(st.Get(4));
            if (!string.IsNullOrEmpty(st.Get(1)))
                Console.WriteLine(st.Get(1));
            if (!string.IsNullOrEmpty(st.Get(6)))
                Console.WriteLine(st.Get(6));
            if(!string.IsNullOrEmpty(st.Get(8)))
                Console.WriteLine(st.Get(8));
            Console.ReadLine();

        }
    }
}
