namespace Valid_Parentheses_20
{
    internal class Program
    {
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        static void Main(string[] args)
        {
            string s = "([])";
            Console.WriteLine(IsValid(s));
        }
        public static bool IsValid(string s)
        {
            Dictionary<char, char> characters = new Dictionary<char, char>()
            {
                {'(', ')'},
                {'{', '}'},
                {'[', ']'}
            };
            List<char> charsToClose = new List<char>();
            foreach (var character in s)
            {
                if (characters.ContainsKey(character))
                {
                    charsToClose = charsToClose.Prepend(characters.GetValueOrDefault(character)).ToList();
                }
                else if (charsToClose.Count != 0 && charsToClose[0] == character)
                {
                    charsToClose.RemoveAt(0);
                }
                else
                {
                    return false;
                }
            }
            if(charsToClose.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
