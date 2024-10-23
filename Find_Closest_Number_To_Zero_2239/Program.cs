namespace Find_Closest_Number_To_Zero_2239
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an integer array nums of size n, return the number with the value closest to 0 in nums. If there are multiple answers, return the number with the largest value.
            Console.WriteLine("Give how many integers do you want to type: ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int minimum = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Type integer: ");
                nums[i] = int.Parse(Console.ReadLine());
                if(Math.Abs(minimum) > Math.Abs(nums[i]))
                {
                    minimum = nums[i];
                }
                else if(Math.Abs(minimum) == Math.Abs(nums[i]))
                {
                    if(minimum < nums[i])
                    {
                        minimum = nums[i];
                    }
                }
            }
            Console.WriteLine(minimum);

        }
    }

}
