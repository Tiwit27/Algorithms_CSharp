namespace Add_Binary_67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "1010";
            string b = "1011";
            Console.WriteLine(AddBinary(a,b));
        }
        public static string AddBinary(string a, string b)
        {
            a = a.PadLeft(b.Length, '0');
            b = b.PadLeft(a.Length, '0');
            List<int> digits = new List<int>();
            for (int i = a.Length - 1; i >= 0; i--)
            {
                var sum = a[i] + b[i] - 96;
                digits.Insert(0, sum);
            }
            for (int i = digits.Count - 1; i >= 0; i--)
            {
                if(digits[i] >= 2)
                {
                    digits[i] -= 2;
                    if(i > 0)
                    {
                        digits[i - 1]++;
                    }
                    else
                    {
                        digits.Insert(0, 1);
                    }
                }
            }
            string result = String.Join("", digits);
            return result;
        }
    }
}
