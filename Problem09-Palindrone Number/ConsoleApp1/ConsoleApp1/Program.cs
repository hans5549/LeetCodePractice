namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
        }

        public static bool IsPalindrome(int x)
        {
            string s = x.ToString();
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }

        public static bool IsPalindrome2(int x)
        {
            if (x < 0) return false;
            if (x / 10 == 0) return true;

            var tmp = x;
            var y = tmp % 10;
            while (tmp / 10 != 0)
            {
                y = (y * 10) + (tmp /= 10) % 10;
            }

            return y == x ? true : false;
        }
    }
}