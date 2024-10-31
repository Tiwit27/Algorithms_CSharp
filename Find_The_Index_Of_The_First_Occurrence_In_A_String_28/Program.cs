namespace Find_The_Index_Of_The_First_Occurrence_In_A_String_28
{
    internal class Program
    {
        //Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
        static void Main(string[] args)
        {
            string haystack = "sadbutsad";
            string needle = "sad";
            Console.WriteLine(FindIndex(haystack, needle));    
        }
        public static int FindIndex(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
