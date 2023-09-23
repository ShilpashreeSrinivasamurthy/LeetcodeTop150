        int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int j = 0; j  < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    int temp = nums[k];
                    nums[k] = nums[j];
                    nums[j] = temp;
                    k++;
                }
            }
            return k;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
