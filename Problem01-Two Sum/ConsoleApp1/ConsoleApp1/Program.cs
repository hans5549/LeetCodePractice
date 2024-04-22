﻿namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = [2, 7, 11, 15];
            int target = 9;
            var result = TwoSum(nums, target);

            Console.WriteLine(result);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i, j];
                    }
                }
            }
            return [];
        }
    }
}