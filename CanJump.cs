// https://leetcode.com/problems/jump-game/description/?envType=study-plan-v2&envId=top-interview-150

bool CanJump(int[] nums)
        {
            int currentMaximumJump = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > currentMaximumJump)
                {
                    return false;
                }
                currentMaximumJump = Math.Max(currentMaximumJump, i + nums[i]);
            }
            return true;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
