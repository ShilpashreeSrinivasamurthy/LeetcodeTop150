// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/?envType=study-plan-v2&envId=top-interview-150

        int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;
            while (numbers[start] + numbers[end] != target)
            {
                if (numbers[start] + numbers[end] < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            return new int[] { start + 1, end + 1 };
        }
        // Time Complexity : O(n) 
        // Space Complexity : O(1)
