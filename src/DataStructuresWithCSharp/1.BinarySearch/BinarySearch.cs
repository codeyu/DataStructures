namespace DataStructuresWithCSharp._1.BinarySearch
{
    public static class BinarySearch
    {
        // 查找整形数组中某个数，若存在，返回这个数（若有重复,则返回靠右边的）在数组中的索引（从0开始），不存在则返回不大于这个数的索引。
        public static int Search(int[] a, int x)
        {
            if (a.Length <= 0) return -1;
            var low = 0;
            var high = a.Length;
            while (high - low > 1)
            {
                var mid = low + (high - low) / 2;
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
    }
}
