using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort.Algorithm.Find
{
    public class BST<Key,Value> : IST<Key,Value>
    where Key:IComparable
    {
        Node _root = null;
        private class Node
        {
            public Key Key;
            public Value Value;
            public Node Left;
            public Node Right;
        }
        public Value Get(Key key)
        {
            return get(_root,key);
        }

        private Value get(Node root, Key key)
        {
            if (root == null)
                return default(Value);
            int cmp = key.CompareTo(root.Key);
            if (cmp == 0)
                return root.Value;
            else if (cmp < 0)
                return get(root.Left, key);
            else
                return get(root.Right,key);
        }

        public void Put(Key key, Value val)
        {

            _root = put(_root,key,val);
            //if (_root == null)
            //    _root = createNewNode(key,val);
            //else
            //    put(_root, key, val);

        }

        private Node put(Node root, Key key, Value val)
        {
            if (root == null)
                root = createNewNode(key, val);
            else
            {
                int cmp = key.CompareTo(root.Key);
                if (cmp == 0)
                    root.Value = val;
                else if (cmp < 0)
                    root.Left = put(root.Left, key, val);
                else
                    root.Right = put(root.Right, key, val);
            }
            return root;
        }

        private Node createNewNode( Key key, Value val)
        {
            return new Node() { Key = key, Value = val, Left = null, Right = null };
        }

        //private void put(Node root, Key key, Value val)
        //{
        //    int cmp = key.CompareTo(root.Key);
        //    if (cmp == 0)
        //        root.Value = val;
        //    else if (cmp < 0)
        //    {
        //        if (root.Left == null)
        //        {
        //            Node node =  createNewNode(key,val);
        //            root.Left = node;
        //        }
        //        else
        //            put(root.Left, key, val);
        //    }
        //    else
        //    {

        //        if (root.Right == null)
        //        {
        //            Node node = createNewNode(key, val);
        //            root.Right = node;
        //        }
        //        else
        //            put(root.Right, key, val);
        //    }
        //}

        public int Rank(Key key, int lo, int hi)
        {
            throw new NotImplementedException();
        }

        public Value[] Range(Key lo, Key hi)
        {
            throw new NotImplementedException();
        }
    }
}
