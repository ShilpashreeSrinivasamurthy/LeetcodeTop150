// https://leetcode.com/problems/find-peak-element/description/?envType=study-plan-v2&envId=top-interview-150

        int GetPeakElement(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] <= nums[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return nums[left];
        }
        // Time Complexity : O(log (n)) 
        // Space Complexity : O(1)
