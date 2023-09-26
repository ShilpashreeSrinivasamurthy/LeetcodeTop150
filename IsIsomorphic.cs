// https://leetcode.com/problems/isomorphic-strings/description/?envType=study-plan-v2&envId=top-interview-150

bool IsIsomorphic(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }
            if(s == t)
            {
                return true;
            }
            int[] counter1 = new int[256];
            int[] counter2 = new int[256];
            
            for (int i = 0; i < s.Length; i++)
            {
                if(counter1[s[i]] != counter2[t[i]])
                {
                    return false;
                }
                counter1[s[i]] = i + 1;
                counter2[t[i]] = i + 1;
            }
            return true;
        }
        // Time Complexity : O(n) 
        // Space Complexity : O(1)
