using System;
using System.Collections.Generic;
namespace DataStructures._3.BalancedBinaryTree
{
    public class AVLNode<K, V>
    {
        /// <summary>
        /// 节点元素
        /// </summary>
        public K Key;

        /// <summary>
        /// 增加一个高度信息
        /// </summary>
        public int BF;

        /// <summary>
        /// 节点中的附加值
        /// </summary>
        public HashSet<V> Data = new HashSet<V>();

        /// <summary>
        /// 左节点
        /// </summary>
        public AVLNode<K, V> Left;

        /// <summary>
        /// 右节点
        /// </summary>
        public AVLNode<K, V> Right;

        public AVLNode() { }

        public AVLNode(K key, V value, AVLNode<K, V> left, AVLNode<K, V> right)
        {
            //KV键值对
            this.Key = key;
            this.Data.Add(value);

            this.Left = left;
            this.Right = right;
        }
    }
}
