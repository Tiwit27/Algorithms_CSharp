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
            /*
            
            if(s.Length % 2 != 0)
            {
                return false;
            }
            else
            {
                char[] sChar = s.ToCharArray();
                for(int i = 0; i < sChar.Length / 2; i++)
                {
                    char lastChar = characters.Where(x => x.Value == sChar[sChar.Length - i - 1]).Select(x => x.Key).First();
                    if (sChar[i] != lastChar)
                    {
                        return false;
                    }
                }
                return true;
            }*/
        }
    }
}
