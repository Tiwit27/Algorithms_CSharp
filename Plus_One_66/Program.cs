namespace Plus_One_66
{
    internal class Program
    {
        //You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
        static void Main(string[] args)
        {
            int[] digits = {1,2,3};
            Console.WriteLine("[" + string.Join(',', PlusOne(digits)) + "]");
        }
        public static int[] PlusOne(int[] digits)
        {
            int digit = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                digit += digits[i] * Convert.ToInt32(Math.Pow(10, digits.Length - 1 - i));
            }
            digit += 1;
            int[] output = new int[digit.ToString().Length];
            for (int i = 0;i < digit.ToString().Length; i++)
            {
                output[i] = digit.ToString()[i] - 48;
            }
            return output;
        }
    }
}
