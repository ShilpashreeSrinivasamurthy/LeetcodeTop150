// https://leetcode.com/problems/jump-game-ii/?envType=study-plan-v2&envId=top-interview-150
 static int CanJump2(int[] nums)
        {
            int stepCount = 0;
            int lastMaximumJump = 0;
            int currentMaxiumJump = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                currentMaxiumJump = Math.Max(currentMaxiumJump, i + nums[i]);

                if(i == lastMaximumJump)
                {
                    lastMaximumJump = currentMaxiumJump;
                    stepCount++;
                }
            }

            return stepCount;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
