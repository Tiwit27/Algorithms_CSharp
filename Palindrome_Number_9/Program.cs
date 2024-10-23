using System.Security.AccessControl;

namespace Palindrome_Number_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an integer x, return true if x is a palindrome, and false otherwise.
            int x = 121;
            Console.WriteLine(IsPalindrome(x));
        }
        static bool IsPalindrome(int x)
        {
            string xReverse = "";
            string stringX = x.ToString();
            for (int i = stringX.Length -1; i >= 0; i--)
            {
                xReverse += stringX[i];
            }
            if(xReverse == x.ToString())
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
