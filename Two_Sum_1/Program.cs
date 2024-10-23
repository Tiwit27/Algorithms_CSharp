namespace Two_Sum_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            You may assume that each input would have exactly one solution, and you may not use the same element twice.
            You can return the answer in any order.*/
            int[] nums = { 2, 3, 11, 7 };
            int target = 9;
            int[] result = FindSum(nums, target);
            Console.WriteLine(result[0] + " " + result[1]);
        }
        static int[] FindSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= target)
                {
                    for (int y = 0; y < nums.Length; y++)
                    {
                        if(y == i)
                        {
                            continue;
                        }
                        else
                        {
                            if (nums[y] + nums[i] == target)
                            {
                                return [y, i];
                            }
                        }
                    }
                }
            }
            return [];
        }
    }
}
