namespace Merge_Two_Sorted_Lists_21
{
    internal class Program
    {
        /*You are given the heads of two sorted linked lists list1 and list2.
        Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
        Return the head of the merged linked list.*/
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() {1,2,4};
            List<int> list2 = new List<int>() {1,3,4};
            Console.WriteLine("[" + string.Join(",",MergeTwoList(list1, list2)) + "]");
        }
        public static List<int> MergeTwoList(List<int> l1, List<int> l2)
        {
            List<int> mergeList = new List<int>();
            mergeList.AddRange(l1);
            mergeList.AddRange(l2);
            return (mergeList.Order()).ToList();
        }
    }
}
