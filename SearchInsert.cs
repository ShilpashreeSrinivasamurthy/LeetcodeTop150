// https://leetcode.com/problems/search-insert-position/description/?envType=study-plan-v2&envId=top-interview-150

  static int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right) 
            {
                int mid = left + (right - left) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
        // Time Complexity : O(log n) 
        // Space Complexity : O(1)
