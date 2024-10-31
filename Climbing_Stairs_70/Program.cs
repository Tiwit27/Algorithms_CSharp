namespace Climbing_Stairs_70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClimbStairs(45));
        }
        public static int ClimbStairs(int n)
        {
            if(n == 2)
            {
                return 2;
            }
            else if(n == 1)
            {
                return 1;
            }    
            else
            {
                return ClimbStairs(n - 1) + ClimbStairs(n-2);
            }
        }
    }
}
