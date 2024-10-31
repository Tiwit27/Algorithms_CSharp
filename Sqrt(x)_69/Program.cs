namespace Sqrt_x__69
{
    internal class Program
    {
        //Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.
        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(9));
        }
        public static int MySqrt(int x)
        {
            if(x == 1)
            {
                return x;
            }
            else
            {
                for (double i = 0; i <= x; i++)
                {
                    if(i * i > x)
                    {
                        return Convert.ToInt32(i - 1);
                    }
                }
            }
            return 0;
        }
    }
}
