using System;

namespace Merge_Sorted_Array_88
{
    internal class Program
    {
        //You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively. Merge nums1 and nums2 into a single array sorted in non-decreasing order.
        static void Main(string[] args)
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int[] nums2 = [2, 5, 6];
            Merge(nums1,nums2);
        }
        public static void Merge(int[] nums1, int[] nums2)
        {
            nums1 = nums1.Concat(nums2).Where(x => x != 0).Order().ToArray();
            Console.WriteLine("[" + string.Join(',',nums1) + "]");
        }
    }
}
