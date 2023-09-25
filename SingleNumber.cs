// https://leetcode.com/problems/single-number/?envType=study-plan-v2&envId=top-interview-150

        int SingleNumber(int[] nums)
        {
            int singleNumber = 0;
            foreach(int i in nums)
            {
                singleNumber = singleNumber ^ i;
            }
            return singleNumber;
        }
        // Time Complexity : O(n) 
        // Space Complexity : O(1)
