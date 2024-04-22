namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = "MCMXCIV";
            var result = RomanToInt(s);

            System.Console.WriteLine(result);
        }

        public static int RomanToInt(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && RomanCharToInt(s[i]) > RomanCharToInt(s[i - 1]))
                {
                    result += RomanCharToInt(s[i]) - 2 * RomanCharToInt(s[i - 1]);
                }
                else
                {
                    result += RomanCharToInt(s[i]);
                }
            }
            return result;
        }

        private static int RomanCharToInt(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
    }
}