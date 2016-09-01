using System;
using DataStructuresWithCSharp._1.BinarySearch;
using DataStructuresWithCSharp._2.BinarySearchTree;

namespace DataStructuresWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BinarySearch");
            int[] a = { 1,5,8,12,13,14,20,22,22,30,40,55,61,66 };
            var index = BinarySearch.Search(a, 13);
            Console.WriteLine("[{0}] = {1}", index, a[index]);
            Console.WriteLine("BinarySearchTree");
            BinarySearchTree<int,int> bst = new BinarySearchTree<int, int>();
            bst.Add(1,5);
            bst.Add(2, 3);
            bst.Add(4, 8);
            bst.Add(5, 6);
            Console.WriteLine("Node({0}) = {1}", 4, bst.Get(4));
            Console.ReadKey();
        }
    }
}
