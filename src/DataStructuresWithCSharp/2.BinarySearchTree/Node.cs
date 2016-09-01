namespace DataStructuresWithCSharp._2.BinarySearchTree
{
    public class Node<TKey, TValue>
    {
        public TKey Key;
        public TValue Value;
        public Node<TKey,TValue> Left, Right;

        public Node() { } 
        public Node(TKey key, TValue value, Node<TKey, TValue> left = null, Node<TKey, TValue> right = null)
        {
            Key = key;
            Value = value;
            Left = left;
            Right = right;
        }
    }

}
