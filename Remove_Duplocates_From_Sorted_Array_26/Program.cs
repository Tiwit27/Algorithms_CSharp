using System;

namespace Remove_Duplocates_From_Sorted_Array_26
{
    internal class Program
    {
        //Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
        static void Main(string[] args)
        {
            int[] nums = {1,0,0,1,1,1,2,2,3,3,4};
            nums = nums.Order().ToArray();
            var result = RemoveDuplicates(nums);
            char[] dash = new char[nums.Length - result.Item1];
            for (int i = 0; i < dash.Length; i++)
            {
                dash[i] = '_';
            }
            Console.WriteLine(result.Item1 + ", nums: [" + string.Join(',', result.Item2) + ',' + string.Join(',', dash) + "]");
        }
        public static (int, int[]) RemoveDuplicates(int[] nums)
        {
            int[] numsWithoutDupl = nums.Distinct().ToArray();
            var k = nums.Distinct().ToArray().Length;
            return (k, numsWithoutDupl);
        }
    }
}
