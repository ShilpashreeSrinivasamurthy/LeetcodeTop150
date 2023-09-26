//https://leetcode.com/problems/two-sum/description/?envType=study-plan-v2&envId=top-interview-150

        int[] TwoSumHashMap(int[] numbers, int target)
        {
            int[] result = new int[2];
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dict.ContainsValue(target - numbers[i]))
                {
                    result[0] = dict.First(x => x.Value == (target - numbers[i])).Key;
                    result[1] = i;
                    return result;
                }
                dict.Add(i, numbers[i]);
            }
            return result;
        }
        // Time Complexity : O(n) 
        // Space Complexity : O(1)
