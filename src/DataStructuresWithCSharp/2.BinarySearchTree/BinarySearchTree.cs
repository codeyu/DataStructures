using System;
using System.Collections;
using System.Collections.Generic;

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

        public TKey Min()
        {
            return Min(_root).Key;
        }

        private Node<TKey, TValue> Min(Node<TKey, TValue> node)
        {
            return node.Left == null ? node : Min(node.Left);
        }

        public TKey Max()
        {
            return Max(_root).Key;
        }

        private Node<TKey, TValue> Max(Node<TKey, TValue> node)
        {
            return node.Right == null ? node : Max(node.Right);
        }

        private Node<TKey, TValue> Delete(Node<TKey, TValue> x, TKey key)
        {
            if (x == null)
            {
                return null;
            }
            var cmp = key.CompareTo(x.Key);
            if (cmp < 0)
            {
                x.Left = Delete(x.Left, key);
            }
            else if (cmp > 0)
            {
                x.Right = Delete(x.Right, key);
            }
            else
            {
                if (x.Right == null) return x.Left;
                if (x.Left == null) return x.Right;
                Node<TKey, TValue> node = x;
                x = Min(node.Right);
                x.Right = DeleteMin(node.Right);
                x.Left = node.Left;
            }
            return x;
        }

        public void Delete(TKey key)
        {
            _root = Delete(_root, key);
        }
        private Node<TKey, TValue> DeleteMin(Node<TKey, TValue> node)
        {
            if (node.Left == null) return node.Right;
            node.Left = DeleteMin(node.Left);
            return node;
        }

        public void DeleteMin()
        {
            _root = DeleteMin(_root);
        }

        private void FindRange(Node<TKey, TValue> x, Queue<TKey> queue, TKey low, TKey high)
        {
            if (x == null) return;
            var cmpLow = low.CompareTo(x.Key);
            var cmpHigh = high.CompareTo(x.Key);
            if (cmpLow < 0) FindRange(x.Left, queue, low, high);
            if (cmpLow <= 0 && cmpHigh >= 0) queue.Enqueue(x.Key);
            if (cmpHigh > 0) FindRange(x.Right, queue, low, high);
        }

        public IEnumerable<TKey> FindRange(TKey low, TKey high)
        {
            Queue<TKey> queue = new Queue<TKey>();
            FindRange(_root, queue, low, high);
            return queue;
        }
    }
}
