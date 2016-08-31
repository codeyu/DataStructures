using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1 };
            var index = BinarySearch(a, 13);
            Console.WriteLine("[{0}] = {1}", index, a[index]);
            Console.ReadKey();
        }
        // 查找整形数组中某个数，若存在，返回这个数（若有重复,则返回靠右边的）在数组中的索引（从0开始），不存在则返回不大于这个数的索引。
        public static int BinarySearch(int[] a, int x)
        {
            if (a.Length > 0)
            {
                var low = 0;
                var high = a.Length;
                int mid;
                while (high - low > 1)
                {
                    mid = low + (high - low) / 2;
                    if (x < a[mid])
                    {
                        high = mid;
                    }
                    else
                    {
                        low = mid;
                    }
                }
                return low;
            }

            return -1;
        }
    }
}
