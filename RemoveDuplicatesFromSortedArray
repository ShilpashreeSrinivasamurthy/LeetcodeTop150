// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/?envType=study-plan-v2&envId=top-interview-150
int RemoveDuplicatesFromSortedArray(int[] nums)
        {
            int count = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
