using System;
namespace SharpMyMind.Problems
{
    public static class Uncategorized
    {
        /*
         * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
         * You may assume that each input would have exactly one solution, and you may not use the same element twice.
         * https://leetcode.com/problems/two-sum/description/
         * time complexity n^2
        */
        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length <= 1)
            {
                return null;
            }
            int[] result = new int[2];
            for (int first = 0; first < nums.Length; first++)
            {
                for (int second = first + 1; second < nums.Length; second++)
                {
                    if (nums[first] + nums[second] == target)
                    {
                        result[0] = first;
                        result[1] = second;
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
