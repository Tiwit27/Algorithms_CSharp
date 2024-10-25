using System.Globalization;

namespace Roman_To_Integer_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M. Given a roman numeral, convert it to an integer.
            Console.Write("Give number in Roman system: ");
            var x = Console.ReadLine();
            Console.WriteLine(RomanToInt(x));
            
        }
        static int RomanToInt(string roman)
        {
            var digits = new Dictionary<string, int>
            {
                {"I", 1},
                {"V", 5},
                {"X",10},
                {"L",50},
                {"C",100},
                {"D",500},
                {"M",1000}
            };
            var charList = roman.ToCharArray();
            int result = 0;
            for (int i = 0; i < charList.Length; i++)
            {
                if (i < charList.Length - 1)
                {
                    if (charList[i] == 'I')
                    {
                        if (charList[i + 1] == 'V')
                        {
                            result += 4;
                            i++;
                            continue;
                        }
                        else if (charList[i + 1] == 'X')
                        {
                            result += 9;
                            i++;
                            continue;
                        }
                    }
                    else if (charList[i] == 'X')
                    {
                        if (charList[i + 1] == 'L')
                        {
                            result += 40;
                            i++;
                            continue;
                        }
                        else if (charList[i + 1] == 'C')
                        {
                            result += 90;
                            i++;
                            continue;
                        }
                    }
                    else if (charList[i] == 'C')
                    {
                        if (charList[i + 1] == 'D')
                        {
                            result += 400;
                            i++;
                            continue;
                        }
                        else if (charList[i + 1] == 'M')
                        {
                            result += 900;
                            i++;
                            continue;
                        }
                    }
                    result += digits[charList[i].ToString()];
                }
                else
                {
                    result += digits[charList[i].ToString()];
                } 
            }
            return result;
        }
    }
}
