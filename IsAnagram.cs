// https://leetcode.com/problems/valid-anagram/description/?envType=study-plan-v2&envId=top-interview-150

        bool IsAnagram(string s, string t)
        {
            if(s == t)
            {
                return true;
            }
            if(s.Length != t.Length)
            {
                return false;
            }
            int[] counter = new int[26];
            foreach (char c in s)
            {
                counter[c - 'a']++;
            }
            foreach (char c in t)
            {
                counter[c - 'a']--;
            }
            foreach (int i in counter)
            {
                if (i != 0)
                {
                    return false;
                }
            }
            return true;
        }
        // Time Complexity : O(n) 
        // Space Complexity : O(1)
