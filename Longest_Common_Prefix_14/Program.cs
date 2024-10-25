namespace Longest_Common_Prefix_14
{
    internal class Program
    {
        //Write a function to find the longest common prefix string amongst an array of strings.
        static void Main(string[] args)
        {
            
            string[] strs = { "flower", "flow", "floght" };
            Console.WriteLine("All strings in array have this common prefix: " + FindPrefix(strs));
        }
        static string FindPrefix(string[] strs)
        {
            bool isContinue = true;
            string prefix = string.Empty;
            foreach (char letter in strs[0])
            {
                foreach(string str in strs)
                {
                    if (str[strs[0].IndexOf(letter)] != letter)
                    {
                        isContinue = false;
                        break;
                    }
                }
                if(!isContinue)
                {
                    break;
                }
                else
                {
                    prefix += letter;
                }
            }
            return prefix;
        }
    }
}
