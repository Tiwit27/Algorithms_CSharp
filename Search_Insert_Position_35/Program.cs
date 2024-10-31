namespace Search_Insert_Position_35
{
    internal class Program
    {
        //Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 7;
            Console.WriteLine(SearchInsert(nums, target));
        }
        public static int SearchInsert(int[] nums, int target)
        {
            int index = Array.IndexOf(nums, target);
            if(index == -1)
            {
                nums = nums.Append(target).Order().ToArray();
                index = Array.IndexOf(nums, target);
            }
            return index;
        }
    }
}
