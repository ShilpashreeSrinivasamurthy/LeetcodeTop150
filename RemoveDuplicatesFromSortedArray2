 int RemoveDuplicatesFromSortedArray2(int[] nums)
        {
            int count = 1;
            int k = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    if(k < 2)
                    {
                        nums[count] = nums[i];
                        count++;
                        k++;
                    }
                }
                else
                {
                    nums[count] = nums[i];
                    count++;
                    k = 1;
                }
            }
            return count;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
