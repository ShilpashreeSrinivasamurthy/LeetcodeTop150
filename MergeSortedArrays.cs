// https://leetcode.com/problems/merge-sorted-array/description/?envType=study-plan-v2&envId=top-interview-150

void MergeSortedArrays(int[] nums1, int m, int [] nums2, int n)
        {
            int count1 = m - 1;
            int count2 = n - 1;
            int totalCount = m + n - 1;
            while (count1 >= 0 && count2 >= 0)
            {
                nums1[totalCount--] = nums1[count1] >= nums2[count2] ? nums1[count1--] : nums2[count2--];
            }
            while (count2 >= 0)
            {
                nums1[totalCount--] = nums2[count2--];
            }

            foreach(int i in nums1)
            {
                Console.WriteLine(i);
            }
        }

// Time Complexity = O(m + n)
// Space Complexity = O(1)
