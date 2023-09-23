// https://leetcode.com/problems/container-with-most-water/description/?envType=study-plan-v2&envId=top-interview-150

static int MaxArea(int[] heights)
        {
            int maxArea = 0;
            int left = 0;
            int right = heights.Length - 1;
            while (left < right)
            {
                int width = right - left;
                int height = Math.Min(heights[left], heights[right]);
                int area = width * height;
                maxArea = Math.Max(area, maxArea);
                if (heights[left] < heights[right])
                {
                    left++;
                }
                else if (heights[left] > heights[right])
                {
                    right--;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return maxArea;
        }
        // Time Complexity : O(n) 
        // Space Complexity : O(1)
