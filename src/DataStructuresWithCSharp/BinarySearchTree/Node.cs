namespace DataStructuresWithCSharp.BinarySearchTree
{
    public class Node<TKey, TValue>
    {
        public TKey Key;
        public TValue Value;
        public Node<TKey,TValue> Left, Right;
    }

}
