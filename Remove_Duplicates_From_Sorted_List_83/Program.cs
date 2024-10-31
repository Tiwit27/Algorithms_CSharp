namespace Remove_Duplicates_From_Sorted_List_83
{
    internal class Program
    {
        //Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.
        static void Main(string[] args)
        {
            List<int> head = [1, 1, 2,3,3];
            Console.WriteLine("[" + String.Join(',', DeleteDuplicates(head)) + "]");
        }
        public static List<int> DeleteDuplicates(List<int> head)
        {
            return head.Distinct().ToList();
        }
    }
}
