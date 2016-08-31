using System;
namespace DataStructuresWithCSharp.BinarySearchTree
{
    public class BinarySearchTree<TKey, TValue> where TKey : IComparable<TKey>
    {

        private Node<TKey, TValue> root;
        public Node<TKey, TValue> Add(TKey key, TValue value, Node<TKey, TValue> tree)
        {
            if (tree == null)
            {
                tree = new Node<TKey, TValue>
                {
                    Key = key,
                    Value = value,
                    Left = null,
                    Right = null
                };
            }
            throw new NotImplementedException();
        }
        public void Add(TKey key, TValue value)
        {
            root = Add(key, value, root);
        }
    }
}
