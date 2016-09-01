using System;

namespace DataStructuresWithCSharp._2.BinarySearchTree
{
    public class BinarySearchTree<TKey, TValue> where TKey : IComparable<TKey>
    {

        private Node<TKey, TValue> _root;
        private static Node<TKey, TValue> Add(TKey key, TValue value, Node<TKey, TValue> tree)
        {
            if (tree == null)
            {
                return new Node<TKey, TValue>
                {
                    Key = key,
                    Value = value,
                    Left = null,
                    Right = null
                };
            }
            var cmp = key.CompareTo(tree.Key);
            if (cmp < 0)
            {
                tree.Left = Add(key, value, tree.Left);
            }
            else if (cmp > 0)
            {
                tree.Right = Add(key, value, tree.Right);
            }
            else
            {
                tree.Value = value;
            }
            return tree;

        }
        public void Add(TKey key, TValue value)
        {
            _root = Add(key, value, _root);
        }

        private static TValue Get(TKey key,  Node<TKey, TValue> tree)
        {
            var cmp = key.CompareTo(tree.Key);
            if (cmp < 0)
            {
                return Get(key, tree.Left);
            }
            if (cmp > 0)
            {
                return Get(key, tree.Right);
            }
            return tree.Value;
        }

        public TValue Get(TKey key)
        {
            return Get(key, _root);
        }
    }
}
