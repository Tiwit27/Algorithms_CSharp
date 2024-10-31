using System.Data;

namespace Remove_Element_27
{
    internal class Program
    {
        //Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
        static void Main(string[] args)
        {
            int[] nums = {0,1,2,2,3,0,4,2};
            int val = 2;
            var result = RemoveElement(nums, val);
            char[] undescores = new char[nums.Length - result.Item2.Length];
            for (int i = 0; i < undescores.Length; i++)
            {
                undescores[i] = '_';
            }
            Console.WriteLine(result.Item1 + ", nums = [" + string.Join(',', result.Item2) + "," + string.Join(',', undescores) + "]");
        }
        public static (int, int[]) RemoveElement(int[] nums, int val)
        {
            var numsWithoutRemoved = nums.Where(x => x != val).ToArray();
            return (numsWithoutRemoved.Length, numsWithoutRemoved);
        }
    }
}
