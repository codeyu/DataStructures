using System;
using System.Linq;
using DataStructures._1.BinarySearch;
using DataStructures._2.BinarySearchTree;

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
            bst.Add(22, 11);
            bst.Add(1,5);
            bst.Add(2, 3);
            bst.Add(4, 8);
            bst.Add(5, 6);
            bst.Add(8, 12);
            bst.Add(10, 100);
            bst.Add(15, 18);
            bst.Add(17, 180);
            bst.Add(50, 44);
            Console.WriteLine("Node({0}) = {1}", 4, bst.Get(4));
            Console.WriteLine("FindRange({0},{1}) = {2}", 4, 18, string.Join(",", bst.FindRange(4, 18)));
            Console.ReadKey();
        }
    }
}
