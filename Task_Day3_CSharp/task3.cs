using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Day3_CSharp
{
    internal class task3
    {
        public static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 }; // Example array of integers
            int target = 9; // Example target sum
            int[] result = TwoSum(nums, target);

            if (result != null)
            {
                Console.WriteLine($"Indices of the two numbers that add up to {target}: {result[0]}, {result[1]}");
            }
            else
            {
                Console.WriteLine("No solution found.");
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numIndexMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numIndexMap.ContainsKey(complement))
                {
                    return new int[] { numIndexMap[complement], i };
                }
                if (!numIndexMap.ContainsKey(nums[i]))
                {
                    numIndexMap[nums[i]] = i;
                }
            }

            return null; // No solution found

        }
    }
}