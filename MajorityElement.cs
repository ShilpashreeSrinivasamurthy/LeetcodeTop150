https://leetcode.com/problems/majority-element/description/?envType=study-plan-v2&envId=top-interview-150
int? MajorityElement (int[] nums)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach(int n in nums)
            {
                if (!dictionary.ContainsKey(n))
                {
                    dictionary.Add(n, 1);
                }
                else
                {
                    int count = dictionary[n] + 1;
                    if (count > nums.Length/2)
                    {
                        return n;
                    }
                    dictionary[n] = count;
                }
            }
            return null;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
