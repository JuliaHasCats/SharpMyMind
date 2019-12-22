using System;
namespace SharpMyMind.Problems
{
    public class TwoPointer
    {
        /*Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.
         * The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.
         * You may assume that each input would have exactly one solution and you may not use the same element twice.
         * Input: numbers={2, 7, 11, 15}, target=9
         * Output: index1=1, index2=2
         * Time Complexcity = n
        */
        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length <= 1)
            {
                return null;
            }
            int first = 0;
            int second = numbers.Length - 1;
            int[] result = new int[2];
            while (second >= first)
            {
                int curr = numbers[first] + numbers[second];
                if (curr == target)
                {
                    result[0] = first + 1;
                    result[1] = second + 1;
                    return result;
                }
                else if (curr < target)
                {
                    first++;
                }
                else
                {
                    second--;
                }
            }
            return result;
        }
    }
}
