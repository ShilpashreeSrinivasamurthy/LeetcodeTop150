https://leetcode.com/problems/rotate-array/description/?envType=study-plan-v2&envId=top-interview-150
        void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
            foreach(int n in nums)
            {
                Console.WriteLine(n);
            }
        }

        void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
