namespace Length_Of_Last_Word_58
{
    internal class Program
    {
        //Given a string s consisting of words and spaces, return the length of the last word in the string.
        static void Main(string[] args)
        {
            string s = "luffy is still joyboy";
            Console.WriteLine(LengthLastWord(s));
        }
        public static int LengthLastWord(string s)
        {
           return s.Split(' ').Where(x => x.Length > 0).Last().Length;
        }
    }
}
