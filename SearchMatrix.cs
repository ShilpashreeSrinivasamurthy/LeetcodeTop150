https://leetcode.com/problems/search-a-2d-matrix/?envType=study-plan-v2&envId=top-interview-150

bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int left = 0;
            int right = rows * columns - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int value = matrix[mid / columns , mid % columns];
                if (target == value)
                {
                    return true;
                }
                if (target < value)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return false;
        }
        // Time Complexity : O(log (m * n)) 
        // Space Complexity : O(1)
